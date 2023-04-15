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
    public partial class frmDichVu : Form
    {
        private Database db;
        
        public frmDichVu()
        {
            db = new Database();
            InitializeComponent();
        }
        private void frmDichVu_Load_1(object sender, EventArgs e)
        {
            LoadDSDV();
            dgvDichVu.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void LoadDSDV()
        {
           
            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
             new CustomParameter()
             {
                key = "@timKiem",
                value= timKiem
             }
        };
            var dt = db.SelectData("LoadDSDV", lstPra);
            dgvDichVu.DataSource = dt;
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txttenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ ","Ràng buộc dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return; 
            }
            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                key = "@tenDV",
                value = txttenDV.Text
                }
            };
            if (db.ExeCute("ThemDV", lstPara) == 1 )
                {
                MessageBox.Show("Thêm mới dịch vụ thành công!");
                LoadDSDV();
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này hay không?", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>
            {
                new CustomParameter
                {
                     key="@id",
                    value = txttenDV.Text
                }
                  };
                var kq = db.ExeCute("XoaDV", lstPara);

                if (kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDSDV();
                    txttenDV.Text = null; 
                }
            }
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int id = -1;
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString());
            txttenDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
