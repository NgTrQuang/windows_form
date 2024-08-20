using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frmDoiMK : Form
    {
        private string mssv;
        public frmDoiMK(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauHienTai = txtMKCu.Text;
            string matKhauMoi = txtMKMoi.Text;
            string xacNhanMatKhauMoi = txtXacNhanMK.Text;

            // Kiểm tra mật khẩu hiện tại
            if (!KiemTraMatKhauHienTai(matKhauHienTai))
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài của mật khẩu mới
            if (matKhauMoi.Length < 7)
            {
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất 7 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới
            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật mật khẩu mới vào cơ sở dữ liệu
            if (CapNhatMatKhauMoi(matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi đổi mật khẩu. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraMatKhauHienTai(string matKhauHienTai)
        {
            try
            {
                MyPublics.ConnectDatabase();

                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    string sqlSelect = "SELECT Count(*) FROM SinhVien WHERE MSSV = @MSSV AND MatKhau = @MatKhau";
                    SqlCommand cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", mssv);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", MyPublics.MaHoaPassword(matKhauHienTai));
                    int result = (int)cmdCommand.ExecuteScalar(); // trả về số lượng bản ghi 
                    return result > 0;
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật mật khẩu mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MyPublics.conMyConnection.Close();
            }
        }

        private bool CapNhatMatKhauMoi(string matKhauMoi)
        {
            try
            {
                MyPublics.ConnectDatabase();

                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    string sqlUpdate = "Update SinhVien Set MatKhau = @MatKhau Where MSSV = @MSSV";
                    SqlCommand cmdCommand = new SqlCommand(sqlUpdate, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", mssv);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", MyPublics.MaHoaPassword(matKhauMoi));
                    int rowsAffected = cmdCommand.ExecuteNonQuery(); // trả về số lượng hàng đã thực hiện thay đổi trong cơ sở dữ liệu
                    return rowsAffected > 0;
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật mật khẩu mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MyPublics.conMyConnection.Close();
            }
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtMKCu.Focus();
            txtMKCu.PasswordChar = '*';
            txtMKMoi.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';
        }
    }
}
