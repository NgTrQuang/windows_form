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
    public partial class frmDangNhap : Form
    {
        private frmMain fMain;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(frmMain fm) : this()
        {
            fMain = fm;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            txtMSSV.Focus();
            txtMSSV.Text = "1065779";
            txtMatKhau.Text = "1065779";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlSelect, strPasswordSV;
            try
            {
                MyPublics.ConnectDatabase();

                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MyPublics.strMSSV = txtMSSV.Text;
                    strPasswordSV = MyPublics.MaHoaPassword(txtMatKhau.Text);
                    sqlSelect = "Select MSLop, QuyenSD From SinhVien Where MSSV = @MSSV And MatKhau = @MatKhau";
                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", strPasswordSV);
                    drReader = cmdCommand.ExecuteReader();
                    if (drReader.HasRows)
                    {
                        drReader.Read();
                        MyPublics.strLop = drReader.GetString(0);
                        MyPublics.strQuyenSD = drReader.GetString(1);
                        drReader.Close();
                        // Hàm xác định học kỳ chưa sử dụng
                        // MyPublics.XacDinhHKNK();
                        fMain.mnuDuLieu.Enabled = true;
                        fMain.mnuCapNhat.Enabled = true;
                        fMain.mnuDangNhap.Enabled = false;
                        //fMain.mnuDoiMK.Enabled = true;
                        fMain.mnuThoatDangNhap.Enabled = true;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("MSSV hoặc mật khẩu sai!", "Thông báo");
                        txtMSSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối",
               "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MyPublics.conMyConnection != null)
                MyPublics.conMyConnection = null;
            fMain.mnuDuLieu.Enabled = false;
            fMain.mnuCapNhat.Enabled = false;
            fMain.mnuThoatDangNhap.Enabled = false;
            //fMain.mnuDoiMK.Enabled = false;
            this.Close();
        }
    }
}
