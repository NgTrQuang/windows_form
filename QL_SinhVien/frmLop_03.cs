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
    public partial class frmLop_03 : Form
    {
        DataTable dtLop = new DataTable("Lop");
        bool blnThem = false;
        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AdminKhoa") {
                btnThem.Enabled = true; 
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true; 
            } else 
            { 
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false; 
                btnXoa.Enabled = false; 
            }
            if (MyPublics.strQuyenSD == "AdminLop")
                if (txtMSLop.Text == MyPublics.strLop)
                    btnChinhSua.Enabled = true;
                else
                    btnChinhSua.Enabled = false;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            txtMSLop.ReadOnly = true; 
            txtMSLop.BackColor = Color.White; 
            txtTenLop.ReadOnly = true; 
            txtTenLop.BackColor = Color.White; 
            txtKhoaHoc.ReadOnly = true; 
            txtKhoaHoc.BackColor = Color.White; 
            dgvLop.Enabled = true;
        }
        void GanDuLieu()
        {
            if (dtLop.Rows.Count > 0)
            {
                txtMSLop.Text = dgvLop[0, dgvLop.CurrentRow.Index].Value.ToString();
                txtTenLop.Text = dgvLop[1, dgvLop.CurrentRow.Index].Value.ToString();
                txtKhoaHoc.Text = dgvLop[2, dgvLop.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMSLop.Clear();
                txtTenLop.Clear();
                txtKhoaHoc.Clear();
            }
        }
        public frmLop_03()
        {
            InitializeComponent();
        }

        private void frmLop_03_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From Lop";
            MyPublics.OpenData(strSelect, dtLop);
            dgvLop.DataSource = dtLop;
            txtMSLop.MaxLength = 8;
            txtTenLop.MaxLength = 40;
            GanDuLieu();
            dgvLop.Width = 440;
            dgvLop.Columns[0].Width = 95;
            dgvLop.Columns[0].HeaderText = "Mã số";
            dgvLop.Columns[1].Width = 190;
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].Width = 95;
            dgvLop.Columns[2].HeaderText = "Khóa học";
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.EditMode = DataGridViewEditMode.EditProgrammatically;

            DieuKhienKhiBinhThuong();

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
            if (MyPublics.strQuyenSD == "AdminLop")
                if (txtMSLop.Text == MyPublics.strLop)
                    btnChinhSua.Enabled = true;
                else
                    btnChinhSua.Enabled = false;
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMSLop.ReadOnly = false;
            txtTenLop.ReadOnly = false;
            txtKhoaHoc.ReadOnly = false;
            txtMSLop.Clear();
            txtTenLop.Clear();
            txtKhoaHoc.Clear();
            dgvLop.Enabled = false;
            txtMSLop.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtTenLop.ReadOnly = false;
            txtKhoaHoc.ReadOnly = false;
            dgvLop.Enabled = false;
            txtTenLop.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        void LuuLopMoi()
        {
            string strSql = "Insert Into Lop Values(@MSLop, @TenLop, @KhoaHoc)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSLop", txtMSLop.Text);
            cmdCommand.Parameters.AddWithValue("@TenLop", txtTenLop.Text);
            cmdCommand.Parameters.AddWithValue("@KhoaHoc", txtKhoaHoc.Text); // Cập nhật dữ liệu về Server
            cmdCommand.ExecuteNonQuery(); MyPublics.conMyConnection.Close(); // Cập nhật dữ liệu cho DataTable
            dtLop.Rows.Add(txtMSLop.Text, txtTenLop.Text, txtKhoaHoc.Text);
            dgvLop.CurrentCell = dgvLop[0, dgvLop.Rows.Count - 1];
            GanDuLieu();
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }

        void CapNhatLop()
        {
            string strSql = "Update Lop Set TenLop = @TenLop, KhoaHoc = @KhoaHoc Where MSLop = @MSLop";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed) MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSLop", txtMSLop.Text);
            cmdCommand.Parameters.AddWithValue("@TenLop", txtTenLop.Text);
            cmdCommand.Parameters.AddWithValue("@KhoaHoc", txtKhoaHoc.Text); // Cập nhật dữ liệu về Server

            cmdCommand.ExecuteNonQuery();

            MyPublics.conMyConnection.Close(); // Cập nhật dữ liệu cho DataTable

            int curRow = dgvLop.CurrentRow.Index;
            dtLop.Rows[curRow][1] = txtTenLop.Text;
            dtLop.Rows[curRow][2] = txtKhoaHoc.Text;
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int khoa;
            if (txtMSLop.Text == "") 
            { 
                MessageBox.Show("Lỗi chưa nhập mã số lớp!");
                txtMSLop.Focus(); 
                return; 
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên lớp!");
                txtTenLop.Focus(); return; 
            }
            if ((!int.TryParse(txtKhoaHoc.Text, out khoa)) || (khoa <= 0)) 
            {
                MessageBox.Show("Lỗi nhập khóa học!"); 
                txtKhoaHoc.Clear(); 
                txtKhoaHoc.Focus(); 
                return;
            }
            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMSLop.Text, "MSLop", "Lop")) 
                {
                    MessageBox.Show("Mã số lớp này đã có rồi !");
                    txtMSLop.Focus(); 
                } 
                else
                    LuuLopMoi();
            else CapNhatLop();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMSLop.Text, "MSLop", "SinhVien"))
                MessageBox.Show("Phải xóa sinh viên thuộc lớp trước!");
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDelete = "Delete Lop Where MSLop = @MSLop";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSLop", txtMSLop.Text); // Cập nhật dữ liệu về Server
                                                                                 
                    cmdCommand.ExecuteNonQuery(); 
                    MyPublics.conMyConnection.Close(); // Cập nhật dữ liệu cho DataTable
                                                       
                    dtLop.Rows.RemoveAt(dgvLop.CurrentRow.Index);
                    GanDuLieu(); 
                } 
            } 
        }
    }
}
