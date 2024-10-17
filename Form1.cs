using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dangky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Gọi phương thức tự động tạo ra trong Form1.Designer.cs
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle changes to the name field if necessary
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle changes to the email field if necessary
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle changes to the password field if necessary
        }

        private void buttondangky_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text; // Tên
            string email = textBox1.Text; // Email
            string password = textBox2.Text; // Mật khẩu

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Thất bại");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự, bao gồm ít nhất 1 ký tự đặc biệt.", "Thất bại");
                return;
            }

            MessageBox.Show("Đăng ký thành công", "Thành công");
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            var specialCharPattern = @"[!@#$%^&*(),.?""{}|<>]"; // Không có khoảng trắng giữa các ký tự
            return Regex.IsMatch(password, specialCharPattern);
        }
    }
}
