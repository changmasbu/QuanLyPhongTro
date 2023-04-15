
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
    public partial class frmThuePhong : Form
    {
        private Database db;
        private string iDThuePhong;
        public frmThuePhong()
        {

            InitializeComponent();
        }
        private void LoadDSThuePhong()
        {
            List<CustomParameter> lst = new List<CustomParameter>
        {
           new CustomParameter
            {
                key="@tuKhoa",
                value=txtTuKhoa.Text
           }
        };
            dgvThuePhong.AutoGenerateColumns = false;
            dgvThuePhong.DataSource = db.SelectData("LoadDSHopDong", lst);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmThue().ShowDialog();
            LoadDSThuePhong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSThuePhong();
        }

        private void dgvThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSThuePhong();

        }

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThuePhong.Columns["btnThanhToan"].Index)
                {
                    var IDHopDong = dgvThuePhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    new frmThanhToan(IDHopDong).ShowDialog();
                }
    
                if (e.ColumnIndex == dgvThuePhong.Columns["btnGiaHan"].Index)
                {
                    var IDHopDong = dgvThuePhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var lst = new List<CustomParameter>
                    {
                        new CustomParameter
                        {
                            key = "@Id",
                            value = IDHopDong
                        }
                    };

                    if (db.ExeCute("GiaHan", lst) == 1)
                    {
                        MessageBox.Show("Gia hạn phòng thành công!", "Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}



    