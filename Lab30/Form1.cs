using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Lab30
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + textBox8.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    await LoadFtpDirectoryAsync(tbHost.Text);
                    MessageBox.Show("���� " + textBox8.Text + " ��������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            await LoadFtpDirectoryAsync(tbHost.Text);
        }

        private async Task LoadFtpDirectoryAsync(string url)
        {
            treeView1.Nodes.Clear();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        TreeNode rootNode = new TreeNode(url);
                        treeView1.Nodes.Add(rootNode);

                        while (!reader.EndOfStream)
                        {
                            string line = await reader.ReadLineAsync();
                            string formattedLine = FormatFtpLine(line);
                            rootNode.Nodes.Add(formattedLine);
                        }

                        rootNode.Expand();
                    }
                }
            }
        }

        private string FormatFtpLine(string line)
        {
            string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 9)
            {
                return line;
            }
            string permissions = tokens[0];
            string hardLinks = tokens[1];
            string owner = tokens[2];
            string group = tokens[3];
            string size = tokens[4];
            string month = tokens[5];
            string day = tokens[6];
            string yearOrTime = tokens[7];
            string name = tokens[8];

            return $"{size.PadLeft(10)} {month} {day.PadLeft(2)} {yearOrTime} {name}";
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox10.Text = openFileDialog1.FileName;

                    // ���������� ����������� URI ��� FTP-������������
                    string host = tbHost.Text;
                    if (!host.EndsWith("/"))
                    {
                        host += "/";
                    }

                    string uploadPath = host + Uri.EscapeUriString(openFileDialog1.SafeFileName);

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(uploadPath));
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    byte[] file = File.ReadAllBytes(textBox10.Text);

                    using (Stream strz = await request.GetRequestStreamAsync())
                    {
                        await strz.WriteAsync(file, 0, file.Length);
                    }

                    await LoadFtpDirectoryAsync(tbHost.Text);
                    MessageBox.Show(openFileDialog1.SafeFileName + " �����������");
                }
                else
                {
                    MessageBox.Show("���� �� ������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + textBox7.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                await LoadFtpDirectoryAsync(tbHost.Text);
                MessageBox.Show("������� " + textBox7.Text + " ��������");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + textBox6.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                MessageBox.Show("����� �����: " + response.ContentLength.ToString() + " K");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + textBox11.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream fileStream = new FileStream(textBox10.Text, FileMode.Create))
                    {
                        await responseStream.CopyToAsync(fileStream);
                    }
                }

                MessageBox.Show("���� " + textBox11.Text + " �����������");
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + textBox4.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.RenameTo = textBox5.Text;

            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                MessageBox.Show("���� " + textBox4.Text + " ������������� �� " + textBox5.Text);
                await LoadFtpDirectoryAsync(tbHost.Text);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string host = tbHost.Text;
                string path = textBox8.Text;

                if (!host.EndsWith("/"))
                {
                    host += "/";
                }

                string fullPath = new Uri(new Uri(host), Uri.EscapeUriString(path)).ToString();
                MessageBox.Show("������ ����: " + fullPath);

                // �������� ��������� ��������
                if (await DirectoryExistsAsync(fullPath))
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fullPath);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;

                    using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                    {
                        await LoadFtpDirectoryAsync(tbHost.Text);
                        MessageBox.Show("������� " + textBox8.Text + " ��������");
                    }
                }
                else
                {
                    MessageBox.Show("������� �� ��������: " + fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private async Task<bool> DirectoryExistsAsync(string directoryPath)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(directoryPath);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("settings.txt"))
            {
                writer.WriteLine(tbHost.Text);
                writer.WriteLine(tbUser.Text);
                writer.WriteLine(tbPass.Text);
            }
            MessageBox.Show("������������ ���������");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("settings.txt"))
            {
                tbHost.Text = reader.ReadLine();
                tbUser.Text = reader.ReadLine();
                tbPass.Text = reader.ReadLine();
            }
            MessageBox.Show("������������ �����������");
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string host = tbHost.Text;
                    if (!host.EndsWith("/"))
                    {
                        host += "/";
                    }

                    string uploadPath = host + Uri.EscapeUriString(openFileDialog1.SafeFileName);

                    Uri ftpUri = new Uri(uploadPath);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUri);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;

                    byte[] file = File.ReadAllBytes(openFileDialog1.FileName);

                    using (Stream strz = await request.GetRequestStreamAsync())
                    {
                        await strz.WriteAsync(file, 0, file.Length);
                    }

                    using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                    {
                        await LoadFtpDirectoryAsync(tbHost.Text);
                        MessageBox.Show("���� ����������� � ��������� ��'��: " + response.ResponseUri);
                    }
                }
                else
                {
                    MessageBox.Show("���� �� ������");
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is FtpWebResponse ftpResponse)
                {
                    MessageBox.Show("�������: " + ftpResponse.StatusDescription);
                }
                else
                {
                    MessageBox.Show("�������: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string host = tbHost.Text;
                if (!host.EndsWith("/"))
                {
                    host += "/";
                }

                string filePath = host + Uri.EscapeUriString(textBox6.Text);

                Uri ftpUri = new Uri(filePath);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUri);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    MessageBox.Show("���� ����������� �����: " + response.LastModified.ToString());
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is FtpWebResponse ftpResponse)
                {
                    MessageBox.Show("�������: " + ftpResponse.StatusDescription);
                }
                else
                {
                    MessageBox.Show("�������: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // ���������� ����������� URI ��� FTP-������������
                    string host = tbHost.Text;
                    if (!host.EndsWith("/"))
                    {
                        host += "/";
                    }

                    string uploadPath = host + Uri.EscapeUriString(openFileDialog1.SafeFileName);

                    Uri ftpUri = new Uri(uploadPath);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUri);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.AppendFile;

                    byte[] file = File.ReadAllBytes(openFileDialog1.FileName);

                    using (Stream strz = await request.GetRequestStreamAsync())
                    {
                        await strz.WriteAsync(file, 0, file.Length);
                    }

                    await LoadFtpDirectoryAsync(tbHost.Text);
                    MessageBox.Show(openFileDialog1.SafeFileName + " ������");
                }
                else
                {
                    MessageBox.Show("���� �� ������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }
    }

}
