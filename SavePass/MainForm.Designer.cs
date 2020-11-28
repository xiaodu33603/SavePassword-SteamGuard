namespace SavePass
{
    partial class MainForm
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
            this.qq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLoginToken = new System.Windows.Forms.TextBox();
            this.timerSteamGuard = new System.Windows.Forms.Timer(this.components);
            this.pbTimeout = new System.Windows.Forms.ProgressBar();
            this.iiiii = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.wifi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dsteam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.zsteam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ubisoft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.bilibili = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.ps4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.zpyemal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.ljhemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.dadyqq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.mysql = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.admintor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.zpyspass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.zpysteam = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // qq
            // 
            this.qq.Location = new System.Drawing.Point(151, 11);
            this.qq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qq.Name = "qq";
            this.qq.PasswordChar = '*';
            this.qq.ReadOnly = true;
            this.qq.Size = new System.Drawing.Size(136, 23);
            this.qq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "QQ --------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLoginToken
            // 
            this.txtLoginToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginToken.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginToken.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginToken.Location = new System.Drawing.Point(375, 181);
            this.txtLoginToken.Name = "txtLoginToken";
            this.txtLoginToken.ReadOnly = true;
            this.txtLoginToken.Size = new System.Drawing.Size(273, 35);
            this.txtLoginToken.TabIndex = 3;
            this.txtLoginToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerSteamGuard
            // 
            this.timerSteamGuard.Enabled = true;
            this.timerSteamGuard.Interval = 1000;
            this.timerSteamGuard.Tick += new System.EventHandler(this.timerSteamGuard_Tick);
            // 
            // pbTimeout
            // 
            this.pbTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTimeout.Location = new System.Drawing.Point(375, 222);
            this.pbTimeout.Maximum = 30;
            this.pbTimeout.Name = "pbTimeout";
            this.pbTimeout.Size = new System.Drawing.Size(273, 19);
            this.pbTimeout.TabIndex = 4;
            this.pbTimeout.Value = 30;
            // 
            // iiiii
            // 
            this.iiiii.AutoSize = true;
            this.iiiii.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iiiii.Location = new System.Drawing.Point(10, 85);
            this.iiiii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iiiii.Name = "iiiii";
            this.iiiii.Size = new System.Drawing.Size(130, 19);
            this.iiiii.TabIndex = 5;
            this.iiiii.Text = "WIFI ------";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wifi
            // 
            this.wifi.Location = new System.Drawing.Point(151, 81);
            this.wifi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wifi.Name = "wifi";
            this.wifi.PasswordChar = '*';
            this.wifi.ReadOnly = true;
            this.wifi.Size = new System.Drawing.Size(136, 23);
            this.wifi.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dsteam
            // 
            this.dsteam.Location = new System.Drawing.Point(151, 151);
            this.dsteam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dsteam.Name = "dsteam";
            this.dsteam.PasswordChar = '*';
            this.dsteam.ReadOnly = true;
            this.dsteam.Size = new System.Drawing.Size(136, 23);
            this.dsteam.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "DSteam ----";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 183);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // zsteam
            // 
            this.zsteam.Location = new System.Drawing.Point(151, 186);
            this.zsteam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zsteam.Name = "zsteam";
            this.zsteam.PasswordChar = '*';
            this.zsteam.ReadOnly = true;
            this.zsteam.Size = new System.Drawing.Size(136, 23);
            this.zsteam.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "ZSteam ----";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 253);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "Copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ubisoft
            // 
            this.ubisoft.Location = new System.Drawing.Point(151, 256);
            this.ubisoft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ubisoft.Name = "ubisoft";
            this.ubisoft.PasswordChar = '*';
            this.ubisoft.ReadOnly = true;
            this.ubisoft.Size = new System.Drawing.Size(136, 23);
            this.ubisoft.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ubisoft ---";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 288);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 29);
            this.button6.TabIndex = 19;
            this.button6.Text = "Copy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bilibili
            // 
            this.bilibili.Location = new System.Drawing.Point(151, 291);
            this.bilibili.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bilibili.Name = "bilibili";
            this.bilibili.PasswordChar = '*';
            this.bilibili.ReadOnly = true;
            this.bilibili.Size = new System.Drawing.Size(136, 23);
            this.bilibili.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "bilibili --";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(297, 43);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 29);
            this.button7.TabIndex = 22;
            this.button7.Text = "Copy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ps4
            // 
            this.ps4.Location = new System.Drawing.Point(151, 46);
            this.ps4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ps4.Name = "ps4";
            this.ps4.PasswordChar = '*';
            this.ps4.ReadOnly = true;
            this.ps4.Size = new System.Drawing.Size(136, 23);
            this.ps4.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "PS4 -------";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(297, 323);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 29);
            this.button8.TabIndex = 25;
            this.button8.Text = "Copy";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // zpyemal
            // 
            this.zpyemal.Location = new System.Drawing.Point(151, 326);
            this.zpyemal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zpyemal.Name = "zpyemal";
            this.zpyemal.PasswordChar = '*';
            this.zpyemal.ReadOnly = true;
            this.zpyemal.Size = new System.Drawing.Size(136, 23);
            this.zpyemal.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "ZPYEmail --";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(297, 358);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 29);
            this.button9.TabIndex = 28;
            this.button9.Text = "Copy";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ljhemail
            // 
            this.ljhemail.Location = new System.Drawing.Point(151, 361);
            this.ljhemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ljhemail.Name = "ljhemail";
            this.ljhemail.PasswordChar = '*';
            this.ljhemail.ReadOnly = true;
            this.ljhemail.Size = new System.Drawing.Size(136, 23);
            this.ljhemail.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(10, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "LJHEmail --";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(297, 113);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 29);
            this.button10.TabIndex = 31;
            this.button10.Text = "Copy";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(151, 116);
            this.email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email.Name = "email";
            this.email.PasswordChar = '*';
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(136, 23);
            this.email.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(10, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Email -----";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(297, 218);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 29);
            this.button11.TabIndex = 34;
            this.button11.Text = "Copy";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dadyqq
            // 
            this.dadyqq.Location = new System.Drawing.Point(151, 221);
            this.dadyqq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dadyqq.Name = "dadyqq";
            this.dadyqq.PasswordChar = '*';
            this.dadyqq.ReadOnly = true;
            this.dadyqq.Size = new System.Drawing.Size(136, 23);
            this.dadyqq.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(10, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "DadyQQ ----";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(658, 6);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 29);
            this.button12.TabIndex = 37;
            this.button12.Text = "Copy";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(512, 9);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.admin.Name = "admin";
            this.admin.PasswordChar = '*';
            this.admin.ReadOnly = true;
            this.admin.Size = new System.Drawing.Size(136, 23);
            this.admin.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(371, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Admin -----";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(658, 41);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 29);
            this.button13.TabIndex = 40;
            this.button13.Text = "Copy";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // mysql
            // 
            this.mysql.Location = new System.Drawing.Point(512, 44);
            this.mysql.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mysql.Name = "mysql";
            this.mysql.PasswordChar = '*';
            this.mysql.ReadOnly = true;
            this.mysql.Size = new System.Drawing.Size(136, 23);
            this.mysql.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(371, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "MySQL -----";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(658, 76);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 29);
            this.button14.TabIndex = 43;
            this.button14.Text = "Copy";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // admintor
            // 
            this.admintor.Location = new System.Drawing.Point(512, 79);
            this.admintor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.admintor.Name = "admintor";
            this.admintor.PasswordChar = '*';
            this.admintor.ReadOnly = true;
            this.admintor.Size = new System.Drawing.Size(136, 23);
            this.admintor.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(371, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "Admintor --";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(658, 146);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 29);
            this.button15.TabIndex = 46;
            this.button15.Text = "Copy";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // zpyspass
            // 
            this.zpyspass.Location = new System.Drawing.Point(512, 149);
            this.zpyspass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zpyspass.Name = "zpyspass";
            this.zpyspass.PasswordChar = '*';
            this.zpyspass.ReadOnly = true;
            this.zpyspass.Size = new System.Drawing.Size(136, 23);
            this.zpyspass.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(371, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 44;
            this.label14.Text = "ZPYSPass --";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(658, 111);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 29);
            this.button16.TabIndex = 49;
            this.button16.Text = "Copy";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // zpysteam
            // 
            this.zpysteam.Location = new System.Drawing.Point(512, 114);
            this.zpysteam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zpysteam.Name = "zpysteam";
            this.zpysteam.PasswordChar = '*';
            this.zpysteam.ReadOnly = true;
            this.zpysteam.Size = new System.Drawing.Size(136, 23);
            this.zpysteam.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(371, 118);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 19);
            this.label15.TabIndex = 47;
            this.label15.Text = "ZPYSteam --";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(615, 347);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(97, 40);
            this.button17.TabIndex = 50;
            this.button17.Text = "Steam备用码";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(658, 181);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 60);
            this.button18.TabIndex = 51;
            this.button18.Text = "Copy";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(375, 247);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 18);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DSteam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(448, 247);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 18);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.Text = "ZSteam";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 399);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.zpysteam);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.zpyspass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.admintor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.mysql);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dadyqq);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.ljhemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.zpyemal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ps4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bilibili);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ubisoft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.zsteam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dsteam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wifi);
            this.Controls.Add(this.iiiii);
            this.Controls.Add(this.pbTimeout);
            this.Controls.Add(this.txtLoginToken);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qq);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "SavePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLoginToken;
        private System.Windows.Forms.Timer timerSteamGuard;
        private System.Windows.Forms.ProgressBar pbTimeout;
        private System.Windows.Forms.Label iiiii;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox wifi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox dsteam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox zsteam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ubisoft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox bilibili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox ps4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox zpyemal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox ljhemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox dadyqq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox admin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox mysql;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox admintor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox zpyspass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox zpysteam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

