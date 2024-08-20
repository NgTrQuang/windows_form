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
    public partial class frmThongTinDangNhap : Form
    {
        private string mssv;
        //private DataTable dtThongTin;
        public frmThongTinDangNhap(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }
        private void frmThongTinDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                MyPublics.ConnectDatabase();

                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    string sqlSelect = "SELECT * FROM SinhVien WHERE MSSV = @MSSV";
                    SqlCommand cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", mssv);
                    SqlDataReader drReader = cmdCommand.ExecuteReader();

                    if (drReader.HasRows)
                    {
                        drReader.Read();
                        txtMSSV.Text = drReader["MSSV"].ToString();
                        txtHoLot.Text = drReader["HoLot"].ToString();
                        txtTen.Text = drReader["Ten"].ToString();
                        txtPhai.Text = drReader["Phai"].ToString();
                        txtNgaySinh.Text = ((DateTime)drReader["NgaySinh"]).ToString("dd/MM/yyyy");
                        txtLop.Text = drReader["MSLop"].ToString();
                        txtQuyenSD.Text = drReader["QuyenSD"].ToString();
                        DieuKienBinhThuong();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên.", "Thông báo");
                    }

                    drReader.Close();
                    MyPublics.conMyConnection.Close();
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin sinh viên: " + ex.Message, "Thông báo");
            }
        }

        void DieuKienBinhThuong()
        {
            txtMSSV.ReadOnly = true;
            txtHoLot.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtPhai.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtLop.ReadOnly = true;
            txtQuyenSD.ReadOnly = true;
        }
    }
}
