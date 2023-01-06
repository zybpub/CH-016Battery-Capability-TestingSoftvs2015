namespace 锂电池充放电控制系统cs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbb_machine_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.tb_memo = new System.Windows.Forms.TextBox();
            this.btn_set_remote = new System.Windows.Forms.Button();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.btn_send_command = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_batterytype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_电池容量 = new System.Windows.Forms.TextBox();
            this.tb_充电电压 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_充电电流 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_充电关断电压 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_充电关断电流 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_充电时间 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_充电关断容量 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_放电时间 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_放电关断容量 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_放电关断电流 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_放电关断电压 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_放电电流 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_放电电压 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_setV5 = new System.Windows.Forms.Button();
            this.btn_setV126 = new System.Windows.Forms.Button();
            this.btn_setV15 = new System.Windows.Forms.Button();
            this.btn_getCurrent = new System.Windows.Forms.Button();
            this.btn_output_on = new System.Windows.Forms.Button();
            this.btn_output_off = new System.Windows.Forms.Button();
            this.btn_output_query = new System.Windows.Forms.Button();
            this.btn_batt_on = new System.Windows.Forms.Button();
            this.btn_batt_off = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_output_status = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lineEdit_realWH = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lineEdit_realAH = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lineEdit_realW = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lineEdit_realA = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lineEdit_realV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ccb_realdisplay = new System.Windows.Forms.CheckBox();
            this.pushButton_OneKeyCharge = new System.Windows.Forms.Button();
            this.pushButton_OneKeyDisCharge = new System.Windows.Forms.Button();
            this.btn_set_local = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_machine_name
            // 
            this.cbb_machine_name.FormattingEnabled = true;
            this.cbb_machine_name.Location = new System.Drawing.Point(48, 218);
            this.cbb_machine_name.Name = "cbb_machine_name";
            this.cbb_machine_name.Size = new System.Drawing.Size(121, 20);
            this.cbb_machine_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择机器名称";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_title.ForeColor = System.Drawing.Color.Blue;
            this.lb_title.Location = new System.Drawing.Point(45, 51);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(1178, 75);
            this.lb_title.TabIndex = 51;
            this.lb_title.Text = "蓄电池充放电控制系统 ";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 939);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(224, 17);
            this.toolStripStatusLabel1.Text = "四川启睿克科技有限公司　检测校准中心";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel2.Text = "软件代号：CH-016";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(194, 218);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 53;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(287, 216);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 54;
            this.btn_disconnect.Text = "断开";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // tb_memo
            // 
            this.tb_memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_memo.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.tb_memo.Location = new System.Drawing.Point(48, 608);
            this.tb_memo.Multiline = true;
            this.tb_memo.Name = "tb_memo";
            this.tb_memo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_memo.Size = new System.Drawing.Size(638, 233);
            this.tb_memo.TabIndex = 55;
            // 
            // btn_set_remote
            // 
            this.btn_set_remote.Location = new System.Drawing.Point(53, 301);
            this.btn_set_remote.Name = "btn_set_remote";
            this.btn_set_remote.Size = new System.Drawing.Size(128, 23);
            this.btn_set_remote.TabIndex = 56;
            this.btn_set_remote.Text = "启用远程修改控制";
            this.btn_set_remote.UseVisualStyleBackColor = true;
            this.btn_set_remote.Click += new System.EventHandler(this.btn_set_remote_Click);
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(53, 263);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(243, 21);
            this.tb_command.TabIndex = 57;
            this.tb_command.Text = "*idn?";
            // 
            // btn_send_command
            // 
            this.btn_send_command.Location = new System.Drawing.Point(303, 263);
            this.btn_send_command.Name = "btn_send_command";
            this.btn_send_command.Size = new System.Drawing.Size(75, 23);
            this.btn_send_command.TabIndex = 58;
            this.btn_send_command.Text = "发送指令";
            this.btn_send_command.UseVisualStyleBackColor = true;
            this.btn_send_command.Click += new System.EventHandler(this.btn_send_command_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "选择蓄电池设置名称";
            // 
            // cbb_batterytype
            // 
            this.cbb_batterytype.FormattingEnabled = true;
            this.cbb_batterytype.Location = new System.Drawing.Point(886, 208);
            this.cbb_batterytype.Name = "cbb_batterytype";
            this.cbb_batterytype.Size = new System.Drawing.Size(121, 20);
            this.cbb_batterytype.TabIndex = 59;
            this.cbb_batterytype.SelectedIndexChanged += new System.EventHandler(this.cbb_batterytype_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 61;
            this.label3.Text = "电池容量";
            // 
            // tb_电池容量
            // 
            this.tb_电池容量.Location = new System.Drawing.Point(943, 243);
            this.tb_电池容量.Name = "tb_电池容量";
            this.tb_电池容量.Size = new System.Drawing.Size(100, 21);
            this.tb_电池容量.TabIndex = 62;
            // 
            // tb_充电电压
            // 
            this.tb_充电电压.Location = new System.Drawing.Point(967, 280);
            this.tb_充电电压.Name = "tb_充电电压";
            this.tb_充电电压.Size = new System.Drawing.Size(82, 21);
            this.tb_充电电压.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 63;
            this.label4.Text = "充电电压";
            // 
            // tb_充电电流
            // 
            this.tb_充电电流.Location = new System.Drawing.Point(967, 316);
            this.tb_充电电流.Name = "tb_充电电流";
            this.tb_充电电流.Size = new System.Drawing.Size(82, 21);
            this.tb_充电电流.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 65;
            this.label5.Text = "充电电流";
            // 
            // tb_充电关断电压
            // 
            this.tb_充电关断电压.Location = new System.Drawing.Point(967, 352);
            this.tb_充电关断电压.Name = "tb_充电关断电压";
            this.tb_充电关断电压.Size = new System.Drawing.Size(82, 21);
            this.tb_充电关断电压.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(884, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "充电关断电压";
            // 
            // tb_充电关断电流
            // 
            this.tb_充电关断电流.Location = new System.Drawing.Point(967, 388);
            this.tb_充电关断电流.Name = "tb_充电关断电流";
            this.tb_充电关断电流.Size = new System.Drawing.Size(82, 21);
            this.tb_充电关断电流.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(884, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "充电关断电流";
            // 
            // tb_充电时间
            // 
            this.tb_充电时间.Location = new System.Drawing.Point(967, 460);
            this.tb_充电时间.Name = "tb_充电时间";
            this.tb_充电时间.Size = new System.Drawing.Size(82, 21);
            this.tb_充电时间.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(884, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 73;
            this.label8.Text = "充电时间";
            // 
            // tb_充电关断容量
            // 
            this.tb_充电关断容量.Location = new System.Drawing.Point(967, 424);
            this.tb_充电关断容量.Name = "tb_充电关断容量";
            this.tb_充电关断容量.Size = new System.Drawing.Size(82, 21);
            this.tb_充电关断容量.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(884, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 71;
            this.label9.Text = "充电关断容量";
            // 
            // tb_放电时间
            // 
            this.tb_放电时间.Location = new System.Drawing.Point(1148, 460);
            this.tb_放电时间.Name = "tb_放电时间";
            this.tb_放电时间.Size = new System.Drawing.Size(83, 21);
            this.tb_放电时间.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1065, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 85;
            this.label10.Text = "放电时间";
            // 
            // tb_放电关断容量
            // 
            this.tb_放电关断容量.Location = new System.Drawing.Point(1148, 424);
            this.tb_放电关断容量.Name = "tb_放电关断容量";
            this.tb_放电关断容量.Size = new System.Drawing.Size(83, 21);
            this.tb_放电关断容量.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1065, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "放电关断容量";
            // 
            // tb_放电关断电流
            // 
            this.tb_放电关断电流.Location = new System.Drawing.Point(1148, 388);
            this.tb_放电关断电流.Name = "tb_放电关断电流";
            this.tb_放电关断电流.Size = new System.Drawing.Size(83, 21);
            this.tb_放电关断电流.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1065, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 81;
            this.label12.Text = "放电关断电流";
            // 
            // tb_放电关断电压
            // 
            this.tb_放电关断电压.Location = new System.Drawing.Point(1148, 352);
            this.tb_放电关断电压.Name = "tb_放电关断电压";
            this.tb_放电关断电压.Size = new System.Drawing.Size(83, 21);
            this.tb_放电关断电压.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1065, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 79;
            this.label13.Text = "放电关断电压";
            // 
            // tb_放电电流
            // 
            this.tb_放电电流.Location = new System.Drawing.Point(1148, 316);
            this.tb_放电电流.Name = "tb_放电电流";
            this.tb_放电电流.Size = new System.Drawing.Size(83, 21);
            this.tb_放电电流.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1065, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 77;
            this.label14.Text = "放电电流";
            // 
            // tb_放电电压
            // 
            this.tb_放电电压.Location = new System.Drawing.Point(1148, 280);
            this.tb_放电电压.Name = "tb_放电电压";
            this.tb_放电电压.Size = new System.Drawing.Size(83, 21);
            this.tb_放电电压.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1065, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 75;
            this.label15.Text = "放电电压";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "查询出错信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_setV5
            // 
            this.btn_setV5.Location = new System.Drawing.Point(439, 301);
            this.btn_setV5.Name = "btn_setV5";
            this.btn_setV5.Size = new System.Drawing.Size(150, 23);
            this.btn_setV5.TabIndex = 88;
            this.btn_setV5.Text = "输出5伏（3.7伏锂电池)";
            this.btn_setV5.UseVisualStyleBackColor = true;
            this.btn_setV5.Click += new System.EventHandler(this.btn_setV5_Click);
            // 
            // btn_setV126
            // 
            this.btn_setV126.Location = new System.Drawing.Point(439, 330);
            this.btn_setV126.Name = "btn_setV126";
            this.btn_setV126.Size = new System.Drawing.Size(164, 23);
            this.btn_setV126.TabIndex = 89;
            this.btn_setV126.Text = "输出12.6伏（12伏锂电池)";
            this.btn_setV126.UseVisualStyleBackColor = true;
            this.btn_setV126.Click += new System.EventHandler(this.btn_setV126_Click);
            // 
            // btn_setV15
            // 
            this.btn_setV15.Location = new System.Drawing.Point(439, 358);
            this.btn_setV15.Name = "btn_setV15";
            this.btn_setV15.Size = new System.Drawing.Size(164, 23);
            this.btn_setV15.TabIndex = 90;
            this.btn_setV15.Text = "输出15伏（12伏铅酸电池)";
            this.btn_setV15.UseVisualStyleBackColor = true;
            this.btn_setV15.Click += new System.EventHandler(this.btn_setV15_Click);
            // 
            // btn_getCurrent
            // 
            this.btn_getCurrent.Location = new System.Drawing.Point(375, 439);
            this.btn_getCurrent.Name = "btn_getCurrent";
            this.btn_getCurrent.Size = new System.Drawing.Size(282, 24);
            this.btn_getCurrent.TabIndex = 91;
            this.btn_getCurrent.Text = "返回测量的电压,电流和功率，安时，瓦时";
            this.btn_getCurrent.UseVisualStyleBackColor = true;
            this.btn_getCurrent.Click += new System.EventHandler(this.btn_getCurrent_Click);
            // 
            // btn_output_on
            // 
            this.btn_output_on.Location = new System.Drawing.Point(666, 302);
            this.btn_output_on.Name = "btn_output_on";
            this.btn_output_on.Size = new System.Drawing.Size(75, 21);
            this.btn_output_on.TabIndex = 92;
            this.btn_output_on.Text = "打开输出";
            this.btn_output_on.UseVisualStyleBackColor = true;
            this.btn_output_on.Click += new System.EventHandler(this.btn_output_on_Click);
            // 
            // btn_output_off
            // 
            this.btn_output_off.Location = new System.Drawing.Point(666, 330);
            this.btn_output_off.Name = "btn_output_off";
            this.btn_output_off.Size = new System.Drawing.Size(75, 23);
            this.btn_output_off.TabIndex = 93;
            this.btn_output_off.Text = "关闭输出";
            this.btn_output_off.UseVisualStyleBackColor = true;
            this.btn_output_off.Click += new System.EventHandler(this.btn_output_off_Click);
            // 
            // btn_output_query
            // 
            this.btn_output_query.Location = new System.Drawing.Point(666, 361);
            this.btn_output_query.Name = "btn_output_query";
            this.btn_output_query.Size = new System.Drawing.Size(75, 23);
            this.btn_output_query.TabIndex = 94;
            this.btn_output_query.Text = "查询输出";
            this.btn_output_query.UseVisualStyleBackColor = true;
            this.btn_output_query.Click += new System.EventHandler(this.btn_output_query_Click);
            // 
            // btn_batt_on
            // 
            this.btn_batt_on.Location = new System.Drawing.Point(773, 302);
            this.btn_batt_on.Name = "btn_batt_on";
            this.btn_batt_on.Size = new System.Drawing.Size(92, 23);
            this.btn_batt_on.TabIndex = 95;
            this.btn_batt_on.Text = "开启充电模式";
            this.btn_batt_on.UseVisualStyleBackColor = true;
            this.btn_batt_on.Click += new System.EventHandler(this.btn_batt_on_Click);
            // 
            // btn_batt_off
            // 
            this.btn_batt_off.Location = new System.Drawing.Point(773, 331);
            this.btn_batt_off.Name = "btn_batt_off";
            this.btn_batt_off.Size = new System.Drawing.Size(92, 23);
            this.btn_batt_off.TabIndex = 96;
            this.btn_batt_off.Text = "关闭充电模式";
            this.btn_batt_off.UseVisualStyleBackColor = true;
            this.btn_batt_off.Click += new System.EventHandler(this.btn_batt_off_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_output_status);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lineEdit_realWH);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lineEdit_realAH);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lineEdit_realW);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lineEdit_realA);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lineEdit_realV);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.ccb_realdisplay);
            this.groupBox1.Location = new System.Drawing.Point(449, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 112);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实时显示";
            // 
            // lb_output_status
            // 
            this.lb_output_status.AutoSize = true;
            this.lb_output_status.Location = new System.Drawing.Point(343, 84);
            this.lb_output_status.Name = "lb_output_status";
            this.lb_output_status.Size = new System.Drawing.Size(17, 12);
            this.lb_output_status.TabIndex = 12;
            this.lb_output_status.Text = "--";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(295, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 11;
            this.label21.Text = "输出：";
            // 
            // lineEdit_realWH
            // 
            this.lineEdit_realWH.Location = new System.Drawing.Point(169, 48);
            this.lineEdit_realWH.Name = "lineEdit_realWH";
            this.lineEdit_realWH.Size = new System.Drawing.Size(68, 21);
            this.lineEdit_realWH.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(133, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "瓦时";
            // 
            // lineEdit_realAH
            // 
            this.lineEdit_realAH.Location = new System.Drawing.Point(169, 21);
            this.lineEdit_realAH.Name = "lineEdit_realAH";
            this.lineEdit_realAH.Size = new System.Drawing.Size(68, 21);
            this.lineEdit_realAH.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "电量";
            // 
            // lineEdit_realW
            // 
            this.lineEdit_realW.Location = new System.Drawing.Point(43, 80);
            this.lineEdit_realW.Name = "lineEdit_realW";
            this.lineEdit_realW.Size = new System.Drawing.Size(68, 21);
            this.lineEdit_realW.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "功率";
            // 
            // lineEdit_realA
            // 
            this.lineEdit_realA.Location = new System.Drawing.Point(43, 46);
            this.lineEdit_realA.Name = "lineEdit_realA";
            this.lineEdit_realA.Size = new System.Drawing.Size(68, 21);
            this.lineEdit_realA.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "电流";
            // 
            // lineEdit_realV
            // 
            this.lineEdit_realV.Location = new System.Drawing.Point(43, 19);
            this.lineEdit_realV.Name = "lineEdit_realV";
            this.lineEdit_realV.Size = new System.Drawing.Size(68, 21);
            this.lineEdit_realV.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "电压";
            // 
            // ccb_realdisplay
            // 
            this.ccb_realdisplay.AutoSize = true;
            this.ccb_realdisplay.Location = new System.Drawing.Point(324, 10);
            this.ccb_realdisplay.Name = "ccb_realdisplay";
            this.ccb_realdisplay.Size = new System.Drawing.Size(72, 16);
            this.ccb_realdisplay.TabIndex = 0;
            this.ccb_realdisplay.Text = "实时显示";
            this.ccb_realdisplay.UseVisualStyleBackColor = true;
            this.ccb_realdisplay.CheckedChanged += new System.EventHandler(this.ccb_realdisplay_CheckedChanged);
            // 
            // pushButton_OneKeyCharge
            // 
            this.pushButton_OneKeyCharge.Location = new System.Drawing.Point(886, 497);
            this.pushButton_OneKeyCharge.Name = "pushButton_OneKeyCharge";
            this.pushButton_OneKeyCharge.Size = new System.Drawing.Size(75, 23);
            this.pushButton_OneKeyCharge.TabIndex = 98;
            this.pushButton_OneKeyCharge.Text = "一键充电";
            this.pushButton_OneKeyCharge.UseVisualStyleBackColor = true;
            this.pushButton_OneKeyCharge.Click += new System.EventHandler(this.pushButton_OneKeyCharge_Click);
            // 
            // pushButton_OneKeyDisCharge
            // 
            this.pushButton_OneKeyDisCharge.Location = new System.Drawing.Point(1001, 497);
            this.pushButton_OneKeyDisCharge.Name = "pushButton_OneKeyDisCharge";
            this.pushButton_OneKeyDisCharge.Size = new System.Drawing.Size(75, 23);
            this.pushButton_OneKeyDisCharge.TabIndex = 99;
            this.pushButton_OneKeyDisCharge.Text = "一键放电";
            this.pushButton_OneKeyDisCharge.UseVisualStyleBackColor = true;
            this.pushButton_OneKeyDisCharge.Click += new System.EventHandler(this.pushButton_OneKeyDisCharge_Click);
            // 
            // btn_set_local
            // 
            this.btn_set_local.Location = new System.Drawing.Point(194, 302);
            this.btn_set_local.Name = "btn_set_local";
            this.btn_set_local.Size = new System.Drawing.Size(128, 23);
            this.btn_set_local.TabIndex = 100;
            this.btn_set_local.Text = "关闭远程修改控制";
            this.btn_set_local.UseVisualStyleBackColor = true;
            this.btn_set_local.Click += new System.EventHandler(this.btn_set_local_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.textBox1.Location = new System.Drawing.Point(704, 608);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 190);
            this.textBox1.TabIndex = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_set_local);
            this.Controls.Add(this.pushButton_OneKeyDisCharge);
            this.Controls.Add(this.pushButton_OneKeyCharge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_batt_off);
            this.Controls.Add(this.btn_batt_on);
            this.Controls.Add(this.btn_output_query);
            this.Controls.Add(this.btn_output_off);
            this.Controls.Add(this.btn_output_on);
            this.Controls.Add(this.btn_getCurrent);
            this.Controls.Add(this.btn_setV15);
            this.Controls.Add(this.btn_setV126);
            this.Controls.Add(this.btn_setV5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_放电时间);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_放电关断容量);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_放电关断电流);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_放电关断电压);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_放电电流);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_放电电压);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_充电时间);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_充电关断容量);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_充电关断电流);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_充电关断电压);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_充电电流);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_充电电压);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_电池容量);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_batterytype);
            this.Controls.Add(this.btn_send_command);
            this.Controls.Add(this.tb_command);
            this.Controls.Add(this.btn_set_remote);
            this.Controls.Add(this.tb_memo);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_machine_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锂电池充放电控制系统 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_machine_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox tb_memo;
        private System.Windows.Forms.Button btn_set_remote;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Button btn_send_command;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_batterytype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_电池容量;
        private System.Windows.Forms.TextBox tb_充电电压;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_充电电流;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_充电关断电压;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_充电关断电流;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_充电时间;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_充电关断容量;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_放电时间;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_放电关断容量;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_放电关断电流;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_放电关断电压;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_放电电流;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_放电电压;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_setV5;
        private System.Windows.Forms.Button btn_setV126;
        private System.Windows.Forms.Button btn_setV15;
        private System.Windows.Forms.Button btn_getCurrent;
        private System.Windows.Forms.Button btn_output_on;
        private System.Windows.Forms.Button btn_output_off;
        private System.Windows.Forms.Button btn_output_query;
        private System.Windows.Forms.Button btn_batt_on;
        private System.Windows.Forms.Button btn_batt_off;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ccb_realdisplay;
        private System.Windows.Forms.TextBox lineEdit_realWH;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox lineEdit_realAH;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox lineEdit_realW;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox lineEdit_realA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox lineEdit_realV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button pushButton_OneKeyCharge;
        private System.Windows.Forms.Button pushButton_OneKeyDisCharge;
        private System.Windows.Forms.Button btn_set_local;
        private System.Windows.Forms.Label lb_output_status;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
    }
}

