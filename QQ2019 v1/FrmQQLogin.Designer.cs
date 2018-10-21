namespace QQ2019_v1
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tabLoginAndSetting = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.picQQ = new System.Windows.Forms.PictureBox();
            this.lblRegisterAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFindPassword = new System.Windows.Forms.Label();
            this.ckRemberPwd = new System.Windows.Forms.CheckBox();
            this.ckSelfLogin = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.panPassword = new System.Windows.Forms.Panel();
            this.panAccount = new System.Windows.Forms.Panel();
            this.picOtherAccount = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.picNarrow = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picKeyBoard = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.picAdderUser = new System.Windows.Forms.PictureBox();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSure = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            btnLogin = new System.Windows.Forms.Button();
            this.tabLoginAndSetting.SuspendLayout();
            this.tpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNarrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdderUser)).BeginInit();
            this.tpSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(125, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(287, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabLoginAndSetting
            // 
            this.tabLoginAndSetting.Controls.Add(this.tpLogin);
            this.tabLoginAndSetting.Controls.Add(this.tpSetting);
            this.tabLoginAndSetting.Location = new System.Drawing.Point(-1, -25);
            this.tabLoginAndSetting.Name = "tabLoginAndSetting";
            this.tabLoginAndSetting.SelectedIndex = 0;
            this.tabLoginAndSetting.Size = new System.Drawing.Size(554, 444);
            this.tabLoginAndSetting.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpLogin.BackgroundImage")));
            this.tpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpLogin.Controls.Add(this.picQQ);
            this.tpLogin.Controls.Add(this.lblRegisterAccount);
            this.tpLogin.Controls.Add(this.label3);
            this.tpLogin.Controls.Add(this.lblFindPassword);
            this.tpLogin.Controls.Add(this.ckRemberPwd);
            this.tpLogin.Controls.Add(this.ckSelfLogin);
            this.tpLogin.Controls.Add(this.tbPassword);
            this.tpLogin.Controls.Add(this.tbAccount);
            this.tpLogin.Controls.Add(this.panPassword);
            this.tpLogin.Controls.Add(this.panAccount);
            this.tpLogin.Controls.Add(this.picOtherAccount);
            this.tpLogin.Controls.Add(this.pictureBox7);
            this.tpLogin.Controls.Add(this.picSetting);
            this.tpLogin.Controls.Add(this.picNarrow);
            this.tpLogin.Controls.Add(this.picClose);
            this.tpLogin.Controls.Add(this.pictureBox6);
            this.tpLogin.Controls.Add(this.picKeyBoard);
            this.tpLogin.Controls.Add(this.picPassword);
            this.tpLogin.Controls.Add(this.picAccount);
            this.tpLogin.Controls.Add(btnLogin);
            this.tpLogin.Controls.Add(this.picAdderUser);
            this.tpLogin.Location = new System.Drawing.Point(4, 25);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(546, 415);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "登录";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // picQQ
            // 
            this.picQQ.BackColor = System.Drawing.Color.Transparent;
            this.picQQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQQ.BackgroundImage")));
            this.picQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQQ.Location = new System.Drawing.Point(222, 92);
            this.picQQ.Name = "picQQ";
            this.picQQ.Size = new System.Drawing.Size(80, 80);
            this.picQQ.TabIndex = 8;
            this.picQQ.TabStop = false;
            this.picQQ.MouseEnter += new System.EventHandler(this.picQQ_MouseEnter);
            this.picQQ.MouseLeave += new System.EventHandler(this.picQQ_MouseLeave);
            // 
            // lblRegisterAccount
            // 
            this.lblRegisterAccount.AutoSize = true;
            this.lblRegisterAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterAccount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegisterAccount.ForeColor = System.Drawing.Color.Gray;
            this.lblRegisterAccount.Location = new System.Drawing.Point(1, 375);
            this.lblRegisterAccount.Name = "lblRegisterAccount";
            this.lblRegisterAccount.Size = new System.Drawing.Size(67, 15);
            this.lblRegisterAccount.TabIndex = 27;
            this.lblRegisterAccount.Text = "注册账号";
            this.lblRegisterAccount.Click += new System.EventHandler(this.lblRegisterAccount_Click);
            this.lblRegisterAccount.MouseEnter += new System.EventHandler(this.lblRegisterAccount_MouseEnter);
            this.lblRegisterAccount.MouseLeave += new System.EventHandler(this.lblRegisterAccount_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "QQ";
            // 
            // lblFindPassword
            // 
            this.lblFindPassword.AutoSize = true;
            this.lblFindPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblFindPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFindPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFindPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblFindPassword.Location = new System.Drawing.Point(345, 284);
            this.lblFindPassword.Name = "lblFindPassword";
            this.lblFindPassword.Size = new System.Drawing.Size(67, 15);
            this.lblFindPassword.TabIndex = 25;
            this.lblFindPassword.Text = "找回密码";
            this.lblFindPassword.Click += new System.EventHandler(this.lblFindPassword_Click);
            this.lblFindPassword.MouseEnter += new System.EventHandler(this.lblFindPassword_MouseEnter);
            this.lblFindPassword.MouseLeave += new System.EventHandler(this.lblFindPassword_MouseLeave);
            // 
            // ckRemberPwd
            // 
            this.ckRemberPwd.AutoSize = true;
            this.ckRemberPwd.BackColor = System.Drawing.Color.Transparent;
            this.ckRemberPwd.ForeColor = System.Drawing.Color.Gray;
            this.ckRemberPwd.Location = new System.Drawing.Point(236, 284);
            this.ckRemberPwd.Name = "ckRemberPwd";
            this.ckRemberPwd.Size = new System.Drawing.Size(89, 19);
            this.ckRemberPwd.TabIndex = 24;
            this.ckRemberPwd.Text = "记住密码";
            this.ckRemberPwd.UseVisualStyleBackColor = false;
            // 
            // ckSelfLogin
            // 
            this.ckSelfLogin.AutoSize = true;
            this.ckSelfLogin.BackColor = System.Drawing.Color.Transparent;
            this.ckSelfLogin.ForeColor = System.Drawing.Color.Gray;
            this.ckSelfLogin.Location = new System.Drawing.Point(125, 284);
            this.ckSelfLogin.Name = "ckSelfLogin";
            this.ckSelfLogin.Size = new System.Drawing.Size(89, 19);
            this.ckSelfLogin.TabIndex = 23;
            this.ckSelfLogin.Text = "自动登录";
            this.ckSelfLogin.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(147, 229);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(243, 24);
            this.tbPassword.TabIndex = 22;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseClick);
            // 
            // tbAccount
            // 
            this.tbAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAccount.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAccount.Location = new System.Drawing.Point(147, 182);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(243, 24);
            this.tbAccount.TabIndex = 21;
            this.tbAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAccount_MouseClick);
            // 
            // panPassword
            // 
            this.panPassword.BackColor = System.Drawing.Color.LightGray;
            this.panPassword.Location = new System.Drawing.Point(125, 259);
            this.panPassword.Name = "panPassword";
            this.panPassword.Size = new System.Drawing.Size(287, 2);
            this.panPassword.TabIndex = 20;
            // 
            // panAccount
            // 
            this.panAccount.BackColor = System.Drawing.Color.LightGray;
            this.panAccount.Location = new System.Drawing.Point(125, 214);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(287, 2);
            this.panAccount.TabIndex = 19;
            // 
            // picOtherAccount
            // 
            this.picOtherAccount.BackColor = System.Drawing.Color.Transparent;
            this.picOtherAccount.BackgroundImage = global::QQ2019_v1.Properties.Resources.down2;
            this.picOtherAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOtherAccount.Location = new System.Drawing.Point(396, 192);
            this.picOtherAccount.Name = "picOtherAccount";
            this.picOtherAccount.Size = new System.Drawing.Size(16, 16);
            this.picOtherAccount.TabIndex = 18;
            this.picOtherAccount.TabStop = false;
            this.picOtherAccount.MouseEnter += new System.EventHandler(this.picOtherAccount_MouseEnter);
            this.picOtherAccount.MouseLeave += new System.EventHandler(this.picOtherAccount_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(495, 355);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // picSetting
            // 
            this.picSetting.BackColor = System.Drawing.Color.Transparent;
            this.picSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSetting.BackgroundImage")));
            this.picSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSetting.Location = new System.Drawing.Point(428, 11);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(30, 30);
            this.picSetting.TabIndex = 16;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
            this.picSetting.MouseEnter += new System.EventHandler(this.picSetting_MouseEnter);
            this.picSetting.MouseLeave += new System.EventHandler(this.picSetting_MouseLeave);
            // 
            // picNarrow
            // 
            this.picNarrow.BackColor = System.Drawing.Color.Transparent;
            this.picNarrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNarrow.BackgroundImage")));
            this.picNarrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNarrow.Location = new System.Drawing.Point(464, 11);
            this.picNarrow.Name = "picNarrow";
            this.picNarrow.Size = new System.Drawing.Size(30, 30);
            this.picNarrow.TabIndex = 15;
            this.picNarrow.TabStop = false;
            this.picNarrow.Click += new System.EventHandler(this.picNarrow_Click);
            this.picNarrow.MouseEnter += new System.EventHandler(this.picNarrow_MouseEnter);
            this.picNarrow.MouseLeave += new System.EventHandler(this.picNarrow_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(500, 11);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.TabIndex = 14;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(4, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // picKeyBoard
            // 
            this.picKeyBoard.BackColor = System.Drawing.Color.Transparent;
            this.picKeyBoard.BackgroundImage = global::QQ2019_v1.Properties.Resources.keyboard;
            this.picKeyBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picKeyBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picKeyBoard.Location = new System.Drawing.Point(396, 237);
            this.picKeyBoard.Name = "picKeyBoard";
            this.picKeyBoard.Size = new System.Drawing.Size(16, 16);
            this.picKeyBoard.TabIndex = 12;
            this.picKeyBoard.TabStop = false;
            this.picKeyBoard.MouseEnter += new System.EventHandler(this.picKeyBoard_MouseEnter);
            this.picKeyBoard.MouseLeave += new System.EventHandler(this.picKeyBoard_MouseLeave);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.BackgroundImage = global::QQ2019_v1.Properties.Resources.lock_2;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPassword.Location = new System.Drawing.Point(125, 237);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(16, 16);
            this.picPassword.TabIndex = 11;
            this.picPassword.TabStop = false;
            // 
            // picAccount
            // 
            this.picAccount.BackColor = System.Drawing.Color.Transparent;
            this.picAccount.BackgroundImage = global::QQ2019_v1.Properties.Resources.iconqq;
            this.picAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAccount.Location = new System.Drawing.Point(125, 192);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(16, 16);
            this.picAccount.TabIndex = 10;
            this.picAccount.TabStop = false;
            // 
            // picAdderUser
            // 
            this.picAdderUser.BackColor = System.Drawing.Color.Transparent;
            this.picAdderUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAdderUser.BackgroundImage")));
            this.picAdderUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdderUser.Location = new System.Drawing.Point(230, 110);
            this.picAdderUser.Name = "picAdderUser";
            this.picAdderUser.Size = new System.Drawing.Size(66, 63);
            this.picAdderUser.TabIndex = 7;
            this.picAdderUser.TabStop = false;
            // 
            // tpSetting
            // 
            this.tpSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpSetting.BackgroundImage")));
            this.tpSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSetting.Controls.Add(this.panel1);
            this.tpSetting.Controls.Add(this.comboBox3);
            this.tpSetting.Controls.Add(this.btnTest);
            this.tpSetting.Controls.Add(this.textBox5);
            this.tpSetting.Controls.Add(this.textBox3);
            this.tpSetting.Controls.Add(this.textBox7);
            this.tpSetting.Controls.Add(this.textBox4);
            this.tpSetting.Controls.Add(this.textBox2);
            this.tpSetting.Controls.Add(this.comboBox2);
            this.tpSetting.Controls.Add(this.textBox1);
            this.tpSetting.Controls.Add(this.comboBox1);
            this.tpSetting.Controls.Add(this.label2);
            this.tpSetting.Controls.Add(this.label9);
            this.tpSetting.Controls.Add(this.label12);
            this.tpSetting.Controls.Add(this.label5);
            this.tpSetting.Controls.Add(this.label8);
            this.tpSetting.Controls.Add(this.label11);
            this.tpSetting.Controls.Add(this.label7);
            this.tpSetting.Controls.Add(this.label10);
            this.tpSetting.Controls.Add(this.label6);
            this.tpSetting.Controls.Add(this.label4);
            this.tpSetting.Controls.Add(this.label1);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(546, 415);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "设置";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btSure);
            this.panel1.Location = new System.Drawing.Point(-4, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 44);
            this.panel1.TabIndex = 5;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(421, 10);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(97, 29);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSure
            // 
            this.btSure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSure.Location = new System.Drawing.Point(296, 10);
            this.btSure.Name = "btSure";
            this.btSure.Size = new System.Drawing.Size(97, 29);
            this.btSure.TabIndex = 3;
            this.btSure.Text = "确定";
            this.btSure.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(285, 298);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 23);
            this.comboBox3.TabIndex = 4;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.MintCream;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(451, 210);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 28);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(449, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 25);
            this.textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 25);
            this.textBox3.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(439, 295);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(77, 25);
            this.textBox7.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(449, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 25);
            this.textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 25);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "不使用高级选项";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 25);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "不使用代理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(6, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录服务器";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "域：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "端口：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "用户名：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "端口：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "网络设置";
            // 
            // timerMove
            // 
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 417);
            this.Controls.Add(this.tabLoginAndSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseUp);
            this.tabLoginAndSetting.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNarrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdderUser)).EndInit();
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLoginAndSetting;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.Label lblRegisterAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFindPassword;
        private System.Windows.Forms.CheckBox ckRemberPwd;
        private System.Windows.Forms.CheckBox ckSelfLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Panel panPassword;
        private System.Windows.Forms.Panel panAccount;
        private System.Windows.Forms.PictureBox picOtherAccount;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.PictureBox picNarrow;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picKeyBoard;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.PictureBox picQQ;
        private System.Windows.Forms.PictureBox picAdderUser;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btSure;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Panel panel1;
    }
}

