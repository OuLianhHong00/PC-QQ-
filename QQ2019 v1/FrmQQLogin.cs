using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 编写者：欧连红
/// 软件名称：QQ2019 v1
/// </summary>
namespace QQ2019_v1
{
    //登录和设置界面
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// tabpage1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //设置的点击事件
        private void picSetting_Click(object sender, EventArgs e)
        {
            tabLoginAndSetting.SelectedTab = tabLoginAndSetting.TabPages[1];
        }
        //关闭的点击事件
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //缩小的点击事件
        private void picNarrow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //鼠标靠近时的关闭、缩小、设置颜色变化
        private void picSetting_MouseEnter(object sender, EventArgs e)
        {
            picSetting.BackColor= Color.FromArgb(30, 255, 255, 255);
        }

        private void picSetting_MouseLeave(object sender, EventArgs e)
        {
            picSetting.BackColor = Color.Transparent;
        }

        private void picNarrow_MouseEnter(object sender, EventArgs e)
        {
            picNarrow.BackColor= Color.FromArgb(30, 255, 255, 255);
        }

        private void picNarrow_MouseLeave(object sender, EventArgs e)
        {
            picNarrow.BackColor = Color.Transparent;
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }
       //输入账号和密码处的动态变化
        private void tbAccount_MouseClick(object sender, MouseEventArgs e)
        {
            picAccount.BackgroundImage = Properties.Resources.icon_1;
            picOtherAccount.BackgroundImage = Properties.Resources.down1;
            panAccount.BackColor = Color.Blue;
            picPassword.BackgroundImage = Properties.Resources.lock_2;
            panPassword.BackColor = Color.LightGray;

        }
        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            picAccount.BackgroundImage = Properties.Resources.iconqq;
            panAccount.BackColor = Color.LightGray;
            picPassword.BackgroundImage = Properties.Resources.lock_1;
            panPassword.BackColor = Color.Blue;
        }
        private void picOtherAccount_MouseEnter(object sender, EventArgs e)
        {
            picOtherAccount.BackgroundImage = Properties.Resources.down1;
        }

        private void picOtherAccount_MouseLeave(object sender, EventArgs e)
        {
            picOtherAccount.BackgroundImage = Properties.Resources.down2;
        }

        private void picKeyBoard_MouseEnter(object sender, EventArgs e)
        {
            picKeyBoard.BackgroundImage = Properties.Resources.keyboard1;
        }

        private void picKeyBoard_MouseLeave(object sender, EventArgs e)
        {
            picKeyBoard.BackgroundImage = Properties.Resources.keyboard;
        }
        //点击注册以及找回密码的动态变化
        private void lblFindPassword_MouseEnter(object sender, EventArgs e)
        {
            lblFindPassword.ForeColor = Color.Black;
        }

        private void lblFindPassword_MouseLeave(object sender, EventArgs e)
        {
            lblFindPassword.ForeColor = Color.Gray;
        }

        private void lblRegisterAccount_MouseEnter(object sender, EventArgs e)
        {
            lblRegisterAccount.ForeColor = Color.Black;
        }

        private void lblRegisterAccount_MouseLeave(object sender, EventArgs e)
        {
            lblRegisterAccount.ForeColor = Color.Gray;
        }
        //窗体移动
        //点下窗体
        bool isDrag;//是否点左键
        Point clickPoint;//左上角坐标
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            clickPoint = new Point(e.X, e.Y);
        }
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                int offsetX = e.X - clickPoint.X;
                int offsetY = e.Y - clickPoint.Y;
                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
        }
        //左键放开窗体不动
        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }
       
        //小图标,添加多账号
        bool isMoveOut;
        bool isMoveBack;
        private void picQQ_MouseEnter(object sender, EventArgs e)
        {
            timerMove.Enabled = true;
            isMoveOut = true;
            isMoveBack = false;
        }

        private void picQQ_MouseLeave(object sender, EventArgs e)
        {
            isMoveOut = false;
            isMoveBack = true;
        }
       
        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (isMoveOut)
            {
                picAdderUser.Location = new Point(picAdderUser.Location.X + 10, picAdderUser.Location.Y);
                if (picAdderUser.Location.X > 260)
                {
                    isMoveOut = false;
                }
            }
            else if (isMoveBack)
            {
                picAdderUser.Location = new Point(picAdderUser.Location.X - 10, picAdderUser.Location.Y);
                if (picAdderUser.Location.X < 190)
                {
                    isMoveBack = false;
                }
            }
        }
        //点击注册跳转页面
        private void lblRegisterAccount_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ssl.zc.qq.com/v3/index-chs.html");
        }
        //找回密码
        private void lblFindPassword_Click(object sender, EventArgs e)
        {
            string account = tbAccount.Text;
            string url = "https://aq.qq.com/v2/uv_aq/html/reset_pwd/pc_reset_pwd_input_account.html?v=3.0&old_ver_account="+account;
            System.Diagnostics.Process.Start(url);
        }
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQQMain frmQQmain = new FrmQQMain();
            frmQQmain.ShowDialog();
        }
        /// <summary>
        /// 设置界面（tpSetting)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //设置界面的逻辑
        private void btCancel_Click(object sender, EventArgs e)
        {
            tabLoginAndSetting.SelectedTab = tabLoginAndSetting.TabPages[0];
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.FromArgb(80, 255, 255, 255);
        }
    }
}
