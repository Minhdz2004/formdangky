namespace dangky
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttondangky = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 128);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Tên";
            textBox3.Size = new Size(260, 27);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 181);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 228);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mật khẩu";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // buttondangky
            // 
            buttondangky.Location = new Point(242, 289);
            buttondangky.Name = "buttondangky";
            buttondangky.Size = new Size(180, 34);
            buttondangky.TabIndex = 3;
            buttondangky.Text = "Đăng ký";
            buttondangky.UseVisualStyleBackColor = true;
            buttondangky.Click += buttondangky_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 61);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 4;
            label1.Text = "Đăng ký ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 131);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 188);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 234);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // Form1
            // 
            ClientSize = new Size(736, 442);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttondangky);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Name = "Form1";
            Text = "Form Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox3; // Tên
        private System.Windows.Forms.TextBox textBox1; // Email
        private System.Windows.Forms.TextBox textBox2; // Mật khẩu
        private System.Windows.Forms.Button buttondangky; // Nút Đăng ký
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
