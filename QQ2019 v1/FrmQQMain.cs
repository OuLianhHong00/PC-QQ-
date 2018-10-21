using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 编写者：欧连红
/// </summary>
namespace QQ2019_v1
{
    //主界面
    public partial class FrmQQMain : Form
    {
        public FrmQQMain()
        {
            InitializeComponent();
        }
        
        private void FrmQQMain_Load(object sender, EventArgs e)
        {
            //绘制头向为圆形
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(picQQHead.ClientRectangle);
            Region region = new Region(gp);
            picQQHead.Region = region;
            gp.Dispose();
            region.Dispose();
            GraphicsPath pi = new GraphicsPath();
            pi.AddEllipse(picHead.ClientRectangle);
            Region r = new Region(pi);
            picHead.Region = r;
            pi.Dispose();
            r.Dispose();
            pnlLitterSearch.BackColor= Color.FromArgb(80, 255, 255, 255);
            picSearch.BackColor= Color.FromArgb(20, 255, 255, 255);
            lblSearch.BackColor= Color.FromArgb(20, 255, 255, 255);
            lblSearch.Width = 260;

            lblMessage.ForeColor = Color.Blue;
            tcContent.SelectedTab = tcContent.TabPages[0];

            lblFriends.BackColor = Color.GreenYellow;
            lblFriends.ForeColor = Color.Blue;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picNarror_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //点击搜索->出现搜索框
        private void lblSearch_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            tbSearch.Visible = true;
            picSearchClose.Visible = true;
            picSearch.BackgroundImage = Properties.Resources.search_1;
            pnlLitterSearch.BackColor = Color.White;
            tbSearch.Height = 40;
            lblMessage.ForeColor = Color.Gray;
            lblContact.ForeColor = Color.Gray;
            lblDynamic.ForeColor = Color.Gray;
            tcContent.SelectedTab = tcContent.TabPages[3];
            pnlTab.Visible = false;
        }
        //关闭搜索框
        private void picSearchClose_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            tbSearch.Visible = false;
            picSearchClose.Visible = false;
            picSearch.BackgroundImage = Properties.Resources.search;
            pnlLitterSearch.BackColor = Color.FromArgb(30, 255, 255, 255); ;
            lblSearch.Width = 260;
            pnlTab.Visible = true;
        }
        //消息
        private void lblMessage_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
            lblContact.ForeColor = Color.Gray;
            lblDynamic.ForeColor = Color.Gray;
            picMessage.Visible = false;
            tcContent.SelectedTab = tcContent.TabPages[0];
           
        }
        private void lblMessage_MouseEnter(object sender, EventArgs e)
        {
            if (tcContent.SelectedTab == tcContent.TabPages[0])
            {
                picMessage.Visible = true;
            }
            else {
                lblMessage.ForeColor = Color.Black;
            }
        }

        private void lblMessage_MouseLeave(object sender, EventArgs e)
        {
            if (tcContent.SelectedTab == tcContent.TabPages[0])
            {
                picMessage.Visible = false;
            }
            else {
                lblMessage.ForeColor = Color.Gray;
            }
        }
        //联系人
        private void lblContact_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Gray;
            lblContact.ForeColor = Color.Blue;
            lblDynamic.ForeColor = Color.Gray;
            tcContent.SelectedTab = tcContent.TabPages[1];
        }
        private void lblContact_MouseEnter(object sender, EventArgs e)
        {
            lblContact.ForeColor = Color.Black;
        }

        private void lblContact_MouseLeave(object sender, EventArgs e)
        {
            if (tcContent.SelectedTab == tcContent.TabPages[1])
            {
                lblContact.ForeColor = Color.Blue;
            }
            else {
                lblContact.ForeColor = Color.Gray;
            }
        }
        //动态
        private void lblDynamic_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Gray;
            lblContact.ForeColor = Color.Gray;
            lblDynamic.ForeColor = Color.Blue ;
            tcContent.SelectedTab = tcContent.TabPages[2];
        }
        private void lblDynamic_MouseEnter(object sender, EventArgs e)
        {
            lblDynamic.ForeColor = Color.Black;
        }

        private void lblDynamic_MouseLeave(object sender, EventArgs e)
        {
            if (tcContent.SelectedTab == tcContent.TabPages[2])
            {
                lblDynamic.ForeColor = Color.Blue;
            }
            else {
                lblDynamic.ForeColor = Color.Gray;
            }
        }
        //给panTab添加下边框
        private void pnlTab_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlTab.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, //左边
　　　　　  Color.Transparent, 1, ButtonBorderStyle.Solid, //上边
　　　　　  Color.Transparent, 1, ButtonBorderStyle.Solid, //右边
　　　　　  Color.DimGray, 1, ButtonBorderStyle.Solid);//底边
        }

        private void lblFriends_Click(object sender, EventArgs e)
        {
            lblFriends.BackColor = Color.GreenYellow;
            lblFriends.ForeColor = Color.Blue;
            lblGroupChat.BackColor = Color.Transparent;
            lblGroupChat.ForeColor = Color.Gray;
            libFriend.Visible = true;
            libGroupChat.Visible = false;
        }

        private void lblGroupChat_Click(object sender, EventArgs e)
        {
            lblGroupChat.BackColor = Color.GreenYellow;
            lblGroupChat.ForeColor = Color.Blue;
            lblFriends.BackColor = Color.Transparent;
            lblFriends.ForeColor = Color.Gray;
            libGroupChat.Visible = true;
            libFriend.Visible = false;
        }
        //窗体移动
        //点下窗体
        bool isDrag;//是否点左键
        Point clickPoint;//左上角坐标
        private void FrmQQMain_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            clickPoint = new Point(e.X, e.Y);
        }

        private void FrmQQMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                int offsetX = e.X - clickPoint.X;
                int offsetY = e.Y - clickPoint.Y;
                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
        }

        private void FrmQQMain_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }
    }
}
