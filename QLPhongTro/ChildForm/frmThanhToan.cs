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
    public partial class frmThanhToan : Form
    {
        private Database db;
        private string IDThuePhong;
        public frmThanhToan(string IDThuePhong)
        {
            this.IDThuePhong = IDThuePhong;
            db = new Database();
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
 DataRow dr;
        private void LoadHopDongThuePhong()
        {
            List<CustomParameter> lst = new List<CustomParameter> {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = IDThuePhong
                }
            };

            dr = db.SelectData("LoadHopDong", lst).Rows[0];
            lblKhachHang.Text = dr["HoTen"].ToString();
            lblTenPhong.Text = dr["TenPhong"].ToString();
            lblGiaPhong.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["GiaPhong"].ToString()));
            lblTienDien.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienDien"].ToString()));
            lblTienNuoc.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienNuoc"].ToString()));
            lblTienKhac.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienKhac"].ToString()));
            lblSoNoConThieu.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["SoNoConThieu"].ToString()));
            lblTienThang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TongTienCuaThang"].ToString()));
            lblTongTienTT.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TongTienPhaiTra"].ToString()));
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHopDongThuePhong();
        }

        private void txtThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            lblConLai.Text = string.Format("{0:N0} VNĐ",(int.Parse(dr["TongTienPhaiTra"].ToString()) - int.Parse(txtThanhToan.Text)));


        }

        private void frmThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@Id",
                    value = IDThuePhong
                },
                 new CustomParameter
                 {
                     key = "@SoTien",
                     value = txtThanhToan.Text
                 }
            };

            var kq = db.ExeCute("ThanhToan",lst);
            if (kq == 1)
            {
                 MessageBox.Show("Thanh toán thành công!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "FAILED!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();


        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();



        }

        private void lblConLai_Click(object sender, EventArgs e)
        {

        }
    }
}
