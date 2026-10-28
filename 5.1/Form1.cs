using System;
using System.Windows.Forms;
using MySqlConnector; // Sử dụng thư viện MySqlConnector bạn vừa cài

namespace Bai4_1
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến XAMPP MySQL (Database tên là "đăng nhập")
        private string connectionString = "Server=localhost;Database=đăng nhập;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();

            // Gán phím tắt Enter và Esc
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mặc định ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Ẩn/hiện mật khẩu theo CheckBox
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Kiểm tra lỗi trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            // Kiểm tra đăng nhập trực tiếp từ Database XAMPP (MySQL)
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM taikhoan WHERE Username = @user AND Password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công từ XAMPP MySQL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}