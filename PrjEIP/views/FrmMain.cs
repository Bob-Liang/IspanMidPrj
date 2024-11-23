using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEIP.views
{
    public partial class FrmMain : Form
    {
        CUservice CUservice=new CUservice();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            (new FrmLogIn()).ShowDialog();
            FrmLogIn frm = new FrmLogIn();
            setButtonVisibility(frm.checkCurrentUser());
        }

        //寫一個方法,依照輸入的權限控制顯示按鈕的狀態
        private void setButtonVisibility(string userId)
        {
            UserRole role = CUservice.GetUserRole(userId);
            if (role == UserRole.Admin)
            {
                toolStripButton2.Visible = true;
            }
            else
            {
                toolStripButton2.Visible = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmEmployeeList frm = new FrmEmployeeList();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmTimeStamp frm = new FrmTimeStamp();
            frm.ShowDialog();
        }
    }
}
