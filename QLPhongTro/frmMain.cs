using QLPhongTro.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro
{
    public partial class frmMain : Form
    {
       


        public frmMain()
        {
            InitializeComponent();
        }

        #region gui
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.res;

              
               

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.maxi;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        //hàm add form lên groupbox có tên là grbContent
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            var f = new frmWelcome();
            AddForm(f);

        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            AddForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            AddForm(f);
        }

        private void dichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDichVu();
            AddForm(f);
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pblBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
