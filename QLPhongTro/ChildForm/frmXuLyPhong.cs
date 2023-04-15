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
    public partial class frmXuLyPhong : Form
    {
        private String idPhong;
        private Database db;
        public frmXuLyPhong(String idPhong)
        {
            this.idPhong = idPhong;
            InitializeComponent();
        }
            
            

private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiPhong();
            if (string.IsNullOrEmpty(idPhong))//neu idPhong duoc qua la null = them moi 
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else //neu idPhong # null =cap nhat thong tin phong 
            {
                lblTitle.Text = "Cập nhật thông tin phòng";

                var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@idPhong",
                    value  = idPhong
                }
            };
                var phong = db.SelectData("[selectPhong]", lstPara).Rows[0];
                cbbLoaiPhong.SelectedValue = phong["IDLoaiPhong"].ToString();
                txtTenPhong.Text = phong["TenPhong"].ToString();
                if (phong["trangthai"].ToString() == "1")
                {
                    ckbHoatDong.Checked = true;
                }
                else
                    ckbHoatDong.Checked = false;

            }
        }
        private void LoadLoaiPhong()
        {
            var dt = db.SelectData("loadDsLoaiPhong");
            cbbLoaiPhong.DataSource = dt;
            cbbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbbLoaiPhong.ValueMember = "ID";
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   
                var idLoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
                var tenPhong = txtTenPhong.Text.Trim();
                var trangThai = ckbHoatDong.Checked?1:0;

                if (string.IsNullOrEmpty(tenPhong))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng", "Rằng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();

                return;
                }
            if (string.IsNullOrEmpty(idPhong))//trường hợp thêm mới phòng ko co idPhong<=> null
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key="@idLoaiPhong",
                        value=idLoaiPhong
                    },
                    new CustomParameter()
                    {
                        key = "@tenPhong",
                        value = tenPhong
                    },
                    new CustomParameter()
                    {
                        key ="@trangThai",
                        value=  trangThai.ToString()
                        }
                };
                var rs = db.ExeCute("[themMoiPhong]", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lai gia tri cua component sau khi them moi thanh cong 
                    txtTenPhong.Text = null;
                    cbbLoaiPhong.SelectedIndex = 0;
                }
            }
            else//trường hợp cập nhật phòng đã tồn tại <=> idPhong co gia tri #null
            {
                var lstPara = new List<CustomParameter>()
            {
               new CustomParameter
               {
                   key =  "@idPhong",
                   value=idPhong
               },

               new CustomParameter
               {
                   key="@tenPhong",
                   value=txtTenPhong. Text
               },
               new CustomParameter
                   {
                   key = "@idLoaiPhong",
                   value =  cbbLoaiPhong.SelectedValue.ToString()
                   },
               new CustomParameter
               {
                      key = "@trangThai",
                   value = trangThai.ToString()
                   }
               };
                var kq = db.ExeCute("updatePhong", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);//hien thong bao thanh cong 
                    this.Dispose();//dong frmXuLyPhong
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);//hien thong bao that bai
                }
                }
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pblBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

        }

        private void ckbHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
