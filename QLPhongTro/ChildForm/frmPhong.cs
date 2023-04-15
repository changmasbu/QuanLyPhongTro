using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmPhong : Form
    {
        private Database db;

        private int rowIndex = -1;//bien luu chi so phong 
        public frmPhong()
        {
            InitializeComponent();
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDsPhong();
            #region chinhcot
            //dat lai ten cot
            dgvPhong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["tenphong"].HeaderText = "Phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["trangthai"].HeaderText = "Trạng thái";
            //set kích thước các cột
            dgvPhong.Columns["id"].Width = 50;
            dgvPhong.Columns["tenloaiphong"].Width = 200;
            dgvPhong.Columns["dongia"].Width = 100;
            dgvPhong.Columns["trangthai"].Width = 100;
            dgvPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phong tu dong co gian theo form 

            //căn chỉnh vị trí của cột
            dgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//Can phai cho cot don gia

            //dịnh dạng phan nghin cho cot đơn giá phòng
            dgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";
            #endregion
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog();//truyen vao tham so null de xac dinh truong hop them moi phong 
            LoadDsPhong();
        }

        private void LoadDsPhong()
        {
            db = new Database();
            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
       new CustomParameter()
       {
           key="@timKiem",
           value=timKiem
        }
       };
            var dt = db.SelectData("LoadDsPhong", lstPra);
            dgvPhong.DataSource = dt;
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng đc chọn
            var idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog();//truyen idPhong dechon qua frmXuLyPhong de xac dinh truong cap nhat phong
            LoadDsPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + dgvPhong.Rows[rowIndex].Cells["tenphong"].Value.ToString() + " hay không?", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>
            {
                new CustomParameter
                {
                     key="@idPhong",
                     value=dgvPhong. Rows[rowIndex].Cells["ID"].Value. ToString()
                }
                  };
                var kq = db.ExeCute("deletePhong", lstPara);

                if (kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDsPhong();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
    

    

      