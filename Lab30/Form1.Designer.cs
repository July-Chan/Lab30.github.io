namespace Lab30
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbHost = new TextBox();
            tbUser = new TextBox();
            tbPass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(1028, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(582, 748);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 27);
            label1.TabIndex = 1;
            label1.Text = "Хост";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Name = "label2";
            label2.Size = new Size(181, 27);
            label2.TabIndex = 1;
            label2.Text = "Ім'я користувача";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(222, 13);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(331, 35);
            tbHost.TabIndex = 2;
            tbHost.Text = "ftp://";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(222, 54);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(331, 35);
            tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(222, 95);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(331, 35);
            tbPass.TabIndex = 2;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 191);
            label4.Name = "label4";
            label4.Size = new Size(163, 27);
            label4.TabIndex = 1;
            label4.Text = "Операції з FTP";
            // 
            // button1
            // 
            button1.Location = new Point(24, 244);
            button1.Name = "button1";
            button1.Size = new Size(373, 46);
            button1.TabIndex = 3;
            button1.Text = "Розмір файлу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 296);
            button2.Name = "button2";
            button2.Size = new Size(373, 46);
            button2.TabIndex = 3;
            button2.Text = "Створити каталог";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(24, 348);
            button3.Name = "button3";
            button3.Size = new Size(373, 46);
            button3.TabIndex = 3;
            button3.Text = "Видалити каталог";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 401);
            button4.Name = "button4";
            button4.Size = new Size(373, 46);
            button4.TabIndex = 3;
            button4.Text = "Видалити файл";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(25, 453);
            button5.Name = "button5";
            button5.Size = new Size(372, 46);
            button5.TabIndex = 3;
            button5.Text = "Завантажити на FTP";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(25, 505);
            button6.Name = "button6";
            button6.Size = new Size(372, 46);
            button6.TabIndex = 3;
            button6.Text = "Завантажити";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 557);
            button7.Name = "button7";
            button7.Size = new Size(372, 46);
            button7.TabIndex = 3;
            button7.Text = "Перейменувати";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(23, 609);
            button8.Name = "button8";
            button8.Size = new Size(372, 46);
            button8.TabIndex = 3;
            button8.Text = "Додати до файлу";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(24, 662);
            button9.Name = "button9";
            button9.Size = new Size(371, 46);
            button9.TabIndex = 3;
            button9.Text = "Отримати дати модифікації";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(26, 714);
            button10.Name = "button10";
            button10.Size = new Size(369, 46);
            button10.TabIndex = 3;
            button10.Text = "Завантажити з унікальним ім'ям";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(415, 561);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(285, 35);
            textBox4.TabIndex = 2;
            textBox4.Text = "Поточне ім'я";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(707, 561);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(298, 35);
            textBox5.TabIndex = 2;
            textBox5.Text = "Нове ім'я";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(415, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(590, 35);
            textBox6.TabIndex = 2;
            textBox6.Text = "Файл";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(415, 301);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(590, 35);
            textBox7.TabIndex = 2;
            textBox7.Text = "Каталог";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(415, 405);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(590, 35);
            textBox8.TabIndex = 2;
            textBox8.Text = "Файл";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(415, 353);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(590, 35);
            textBox9.TabIndex = 2;
            textBox9.Text = "Каталог";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(415, 457);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(590, 35);
            textBox10.TabIndex = 2;
            textBox10.Text = "Каталог";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(415, 509);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(590, 35);
            textBox11.TabIndex = 2;
            textBox11.Text = "Файл";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(415, 717);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(590, 35);
            textBox13.TabIndex = 2;
            textBox13.Text = "Файл";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(415, 665);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(590, 35);
            textBox14.TabIndex = 2;
            textBox14.Text = "Файл";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(415, 613);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(590, 35);
            textBox15.TabIndex = 2;
            textBox15.Text = "Файл";
            // 
            // button11
            // 
            button11.Location = new Point(28, 799);
            button11.Name = "button11";
            button11.Size = new Size(369, 46);
            button11.TabIndex = 3;
            button11.Text = "Зберегти налаштування";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1241, 799);
            button12.Name = "button12";
            button12.Size = new Size(369, 46);
            button12.TabIndex = 3;
            button12.Text = "Завантажити налаштування";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(590, 27);
            button13.Name = "button13";
            button13.Size = new Size(373, 88);
            button13.TabIndex = 3;
            button13.Text = "Підключитися";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 874);
            Controls.Add(button4);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button13);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox7);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(textBox15);
            Controls.Add(textBox11);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(tbHost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            ShowIcon = false;
            Text = "Лабораторна 30 Кривонос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbHost;
        private TextBox tbUser;
        private TextBox tbPass;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
