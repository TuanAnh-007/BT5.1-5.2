using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector; // Sử dụng thư viện MySQL đã cài đặt

namespace Bai4_2
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối tới XAMPP MySQL (Dùng chung database "đăng nhập")
        private string connectionString = "Server=localhost;Database=đăng nhập;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình MaskedTextBox cho SĐT theo yêu cầu: (000) 000-0000
            mtxtPhone.Mask = "(000) 000-0000";

            // 2. Cấu hình DateTimePicker hiển thị định dạng ngắn (dd/MM/yyyy)
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // 3. Nạp danh sách Khóa học vào ComboBox sử dụng Binding (DisplayMember & ValueMember)
            var courseList = new List<CourseItem>
            {
                new CourseItem { CourseId = "C#", CourseName = "Lập trình C# WinForms" },
                new CourseItem { CourseId = "WEB", CourseName = "Lập trình Web căn bản" },
                new CourseItem { CourseId = "SQL", CourseName = "Cơ sở dữ liệu MySQL / XAMPP" },
                new CourseItem { CourseId = "DSA", CourseName = "Cấu trúc dữ liệu và giải thuật" }
            };

            cboCourse.DataSource = courseList;
            cboCourse.DisplayMember = "CourseName"; // Hiển thị tên khóa học cho người dùng chọn
            cboCourse.ValueMember = "CourseId";     // Giá trị ẩn bên dưới

            // Mặc định chọn giới tính Nam
            radMale.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu từ các điều khiển trên giao diện
            string fullName = txtFullName.Text.Trim();
            string phone = mtxtPhone.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string gender = radMale.Checked ? "Nam" : "Nữ";
            string courseName = cboCourse.Text; // Lấy tên khóa học được chọn

            // Kiểm tra dữ liệu bắt buộc không được để trống
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            // Thực hiện lưu dữ liệu xuống cơ sở dữ liệu XAMPP MySQL
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO hocvien (HoTen, DienThoai, NgaySinh, GioiTinh, KhoaHoc) VALUES (@hoten, @sdt, @ngaysinh, @gioitinh, @khoahoc)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hoten", fullName);
                        cmd.Parameters.AddWithValue("@sdt", phone);
                        cmd.Parameters.AddWithValue("@ngaysinh", birthDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@gioitinh", gender);
                        cmd.Parameters.AddWithValue("@khoahoc", courseName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu database: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tổng hợp và in thông tin đăng ký lên MessageBox theo đúng yêu cầu
            string info = "--- ĐĂNG KÝ HỌC VIÊN THÀNH CÔNG ---\n\n" +
                          $"Họ và tên: {fullName}\n" +
                          $"Số điện thoại: {phone}\n" +
                          $"Ngày sinh: {birthDate.ToString("dd/MM/yyyy")}\n" +
                          $"Giới tính: {gender}\n" +
                          $"Khóa học: {courseName}";

            MessageBox.Show(info, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Lớp hỗ trợ Binding cho ComboBox
    public class CourseItem
    {
        public string CourseId { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
    }
}