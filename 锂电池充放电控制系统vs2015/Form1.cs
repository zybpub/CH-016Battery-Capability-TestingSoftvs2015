using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace 锂电池充放电控制系统cs
{
    public partial class Form1 : Form
    {
        public static MySql.Data.MySqlClient.MySqlConnection conn;
        private Socket socketSend,socketRealDisplay;
        private bool IsStart;
        private Action<string> ShowMsgAction;
        private string machine_ip,sql,command,real_command;
        System.Timers.Timer Timer_RealDisplay,Timer_output_status;
        public Form1()
        {
            InitializeComponent();
            ShowMsgAction += new Action<string>(ShowMsg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_title.BackColor = Color.Transparent;  //设备标题文字背景透明
            lb_title.Parent = pictureBox1;//将pictureBox1设为标签的父控件
            //pictureBox1.Controls.Add(label1);
            //lb_title.Location = new Point(200, 15);//重新设定标签的位置，这个位置时相对于父控件的左上角

            TextBox.CheckForIllegalCrossThreadCalls = false;


            Timer_RealDisplay = new System.Timers.Timer(1000);  //测试时间显示 
            Timer_RealDisplay.Elapsed += new System.Timers.ElapsedEventHandler(Timer_RealDisplay_Tick);//到时间的时候执行事件；
            Timer_RealDisplay.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            Timer_RealDisplay.Enabled = false;//是否执行System.Timers.Timer.Elapsed事件；

            Timer_output_status = new System.Timers.Timer(1000);  //实时更新输出状态 
            Timer_output_status.Elapsed += new System.Timers.ElapsedEventHandler(Timer_output_status_Tick);//到时间的时候执行事件；
            Timer_output_status.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            Timer_output_status.Enabled = false;//是否执行System.Timers.Timer.Elapsed事件；


            conn = new MySql.Data.MySqlClient.MySqlConnection(
                 "Database=battery_test_database;Data Source=localhost;User Id=root;Password=jczx;charset=utf8;");
            conn.Open();
            {
                sql = "select 仪表名称 from  仪表配置";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySql.Data.MySqlClient.MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_machine_name.Items.Add(dr["仪表名称"]);
                }
                dr.Close();
                cbb_machine_name.SelectedIndex = 0;
            }
            {
                sql = "select 名称 from  充放电参数";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySql.Data.MySqlClient.MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_batterytype.Items.Add(dr["名称"]);
                }
                dr.Close();
                cbb_batterytype.SelectedIndex = 0;
            }


            conn.Close();
        }

        private void Timer_output_status_Tick(object sender, ElapsedEventArgs e)
        {
            command = "OUTP?";
            send_cmd(command);
        }

        private void Timer_RealDisplay_Tick(object sender, ElapsedEventArgs e)
        {
            real_command = "MEAS?";
            byte[] buffer = new byte[1024];
            buffer = Encoding.UTF8.GetBytes(real_command + "\n");
            socketRealDisplay.Send(buffer);
            textBox1.Text += real_command+"\r\n";
            Thread.Sleep(500);
            real_command = "OUTP?";
            buffer = Encoding.UTF8.GetBytes(real_command + "\n");
            socketRealDisplay.Send(buffer);
            textBox1.Text += real_command + "\r\n";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "select ip from  仪表配置 where 仪表名称='"+cbb_machine_name.Text+"'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                MySql.Data.MySqlClient.MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    machine_ip = dr["ip"].ToString();
                }
                dr.Close();
                conn.Close();

                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipAddress = IPAddress.Parse(machine_ip);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 30000);
                socketSend.Connect(ipEndPoint);//此处区别于服务器，没有返回值
                ShowMsg("连接成功!");
                //开启新的线程，不停的接收服务器发来的消息
                Thread c_thread = new Thread(Received);
                c_thread.IsBackground = true;
                c_thread.Start();
                IsStart = true;
                ShowBtnState();

                send_cmd("SYST:REM");
                ccb_realdisplay.Checked = true;
                command = "OUTP?";
                send_cmd(command);

                //Timer_output_status.Enabled = true;
            }
            catch (Exception ex)
            {
                ShowMsg("连接失败:" + ex.Message);
            }
           
        }
        /// <summary>
        /// 接收线程
        /// </summary>
        private void Received()
        {
            while (IsStart)
            {
                try
                {
                    if (!socketSend.Connected) return;
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    //实际接收到的有效字节数
                    int len = socketSend.Receive(buffer);
                    if (len == 0) break;
                    string str = Encoding.UTF8.GetString(buffer, 0, len);
                    //this.BeginInvoke(ShowMsgAction, socketSend.RemoteEndPoint + ":" + str);
                    this.BeginInvoke(ShowMsgAction,  str);
                   
                }
                catch (Exception ex)
                {
                    this.BeginInvoke(ShowMsgAction, ex.Message);
                }
            }
        }

        private void send_cmd(string msg)
        {
            try
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(msg+"\n");
                socketSend.Send(buffer);
                ShowMsg(msg);
            }
            catch (Exception ex)
            {
                this.BeginInvoke(ShowMsgAction, ex.Message);
            }
        }
        private void ShowMsg(string msg)
        {
            string info = string.Format("{0}:{1}\r\n", DateTime.Now.ToString("G"), msg);
            tb_memo.AppendText(info);
        }
        private void ShowBtnState()
        {
            btn_connect.Enabled = !IsStart;
            btn_disconnect.Enabled = IsStart;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            Timer_output_status.Enabled = true;
            if (socketSend.Connected)
            {
                socketSend.Close();
            }

            if (socketRealDisplay.Connected)
            {
                socketRealDisplay.Close();
            }
            ccb_realdisplay.Checked = false;
            IsStart = false;
            ShowBtnState();
            ShowMsg("信息:断开连接!");

        }

       
        private void cbb_batterytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch { }
            sql = "select * from  充放电参数 where 名称='" + cbb_batterytype.Text + "'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySql.Data.MySqlClient.MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_电池容量.Text = dr["电池容量"].ToString();
                tb_充电电压.Text = dr["充电电压"].ToString();
                tb_充电电流.Text = dr["充电电流"].ToString();
                tb_充电关断电压.Text = dr["充电关断电压"].ToString();
                tb_充电关断电流.Text = dr["充电关断电流"].ToString();
                tb_充电关断容量.Text = dr["充电关断容量"].ToString();
                tb_充电时间.Text = dr["充电时间"].ToString();

                tb_放电电压.Text = dr["放电电压"].ToString();
                tb_放电电流.Text = dr["充电电流"].ToString();
                tb_放电关断电压.Text = dr["放电关断电压"].ToString();
                tb_放电关断电流.Text = dr["放电关断电流"].ToString();
                tb_放电关断容量.Text = dr["放电关断容量"].ToString();
                tb_放电时间.Text = dr["放电时间"].ToString();

            }
                dr.Close();
                conn.Close();
           
        }
        private void btn_set_remote_Click(object sender, EventArgs e)
        {
            send_cmd("SYST:REM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            send_cmd("syst:err?");
        }

        private void btn_setV126_Click(object sender, EventArgs e)
        {
            command = "volt 12.6";
            send_cmd(command);
        }

        private void btn_setV15_Click(object sender, EventArgs e)
        {
            command = "volt 15";
            send_cmd(command);
        }

        private void btn_getCurrent_Click(object sender, EventArgs e)
        {
            command = "MEAS?";
            send_cmd(command);
        }

        private void btn_output_on_Click(object sender, EventArgs e)
        {
            command = "OUTP ON";
            send_cmd(command);
            command = "OUTP?";
            send_cmd(command);
        }

        private void btn_output_off_Click(object sender, EventArgs e)
        {
            command = "OUTP OFF";
            send_cmd(command);
            command = "OUTP?";
            send_cmd(command);
        }

        private void btn_output_query_Click(object sender, EventArgs e)
        {
            command = "OUTP?";
            send_cmd(command);
        }

        private void btn_batt_on_Click(object sender, EventArgs e)
        {
            command = "BATT:MODE CHAR";
            send_cmd(command);
            command = "BATT ON";
            send_cmd(command);
        }

        private void btn_batt_off_Click(object sender, EventArgs e)
        {
            command = "BATT OFF";
            send_cmd(command);
        }

        private void ccb_realdisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (ccb_realdisplay.Checked)
            {
                socketRealDisplay = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipAddress = IPAddress.Parse(machine_ip);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 30000);
                socketRealDisplay.Connect(ipEndPoint);//此处区别于服务器，没有返回值
                                                      // ShowMsg("连接成功!");
                                                      //开启新的线程，不停的接收服务器发来的消息
                Thread c_thread = new Thread(RealDisplay);
                c_thread.IsBackground = true;
                c_thread.Start();
                Timer_RealDisplay.Enabled = true;
            }
            else {
                Timer_RealDisplay.Enabled = false;
                lineEdit_realA.Text = "-.---";
                lineEdit_realAH.Text = "-.---";
                lineEdit_realV.Text = "-.---";
                lineEdit_realW.Text = "-.---";
                lineEdit_realWH.Text = "-.---";
                lb_title.Text = "--";
            }
        }

        private void pushButton_OneKeyCharge_Click(object sender, EventArgs e)
        {
            ShowMsg("一键充电");
            command = "OUTP OFF\n";
            send_cmd(command);

            command = "BATT OFF\n";
            send_cmd(command);

            command = "BATT:CHAR:VOLT " + tb_充电电压.Text + "\n";
            send_cmd(command);

            command = "BATT:CHAR:CURR " + tb_充电电流.Text + "\n";
            send_cmd(command);

            command = "BATT:SHUT:TIME " + tb_充电时间.Text + "\n";
            send_cmd(command);

            command = "BATT:SHUT:VOLT " + tb_充电关断电压.Text + "\n";
            send_cmd(command);

            command = "BATT:SHUT:CURR " + tb_充电关断电流.Text + "\n";
            send_cmd(command);

            command = "BATT:SHUT:CAP " + tb_充电关断容量.Text + "\n";
            send_cmd(command);

            command = "BATT:MODE CHAR\n";
            send_cmd(command);
            command = "BATT ON\n";
            send_cmd(command);

            command = "OUTP ON\n";
            send_cmd(command);
        }

        private void pushButton_OneKeyDisCharge_Click(object sender, EventArgs e)
        {
            ShowMsg("一键放电");
            command = "OUTP OFF";
            send_cmd(command);

            command = "BATT OFF";
            send_cmd(command);

            command = "BATT:DISC:VOLT " +tb_放电电压.Text;
            send_cmd(command);

            command = "BATT:DISC:CURR " + tb_放电电流.Text;
            send_cmd(command);

            command = "BATT:SHUT:TIME " + tb_放电时间.Text;
            send_cmd(command);

            command = "BATT:SHUT:VOLT " + tb_放电关断电压.Text;
            send_cmd(command);

            command = "BATT:SHUT:CURR " + tb_放电关断电流.Text;
            send_cmd(command);

            command = "BATT:SHUT:CAP " + tb_放电关断容量.Text;
            send_cmd(command);

            command = "BATT:MODE DISC";  //放电模式
            send_cmd(command);
            command = "BATT ON";
            send_cmd(command);

            command = "OUTP ON";
            send_cmd(command);
        }

        private void btn_set_local_Click(object sender, EventArgs e)
        {
            command = "SYST:LOC";
            send_cmd(command);
        }

        private void RealDisplay()
        {
            while (IsStart)
            {
                try
                {
                    if (!socketRealDisplay.Connected) return;
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    //实际接收到的有效字节数
                    int len = socketRealDisplay.Receive(buffer);
                    if (len == 0) break;
                    string str = Encoding.UTF8.GetString(buffer, 0, len);
                    textBox1.Text += str + "\r\n";
                    if (real_command.Contains("OUTP?"))
                    {
                        if (str.Contains("1")) lb_output_status.Text = "ON";
                        else lb_output_status.Text = "OFF";
                    }
                    else
                    {
                        //5.00014,0,0,2.27581e-06,2.24033e-06
                        string[] values = str.Split(',');
                        if (values.Length == 5)
                        {
                        lineEdit_realV.Text = Convert.ToDouble(values[0]).ToString("0.000");
                        lineEdit_realA.Text = Convert.ToDouble(values[1]).ToString("0.000");
                        lineEdit_realW.Text = Convert.ToDouble(values[2]).ToString("0.000");
                        lineEdit_realAH.Text = Convert.ToDouble(values[3]).ToString("0.000");
                        lineEdit_realWH.Text = Convert.ToDouble(values[4]).ToString("0.000");
                        }

                        
                    }


                }
                catch
                {
                    //textBox1.Text += ex.Message + "\r\n";
                }
            }
        }

        private void btn_setV5_Click(object sender, EventArgs e)
        {
            command = "volt 5.00";
            send_cmd(command);
        }

        private void btn_send_command_Click(object sender, EventArgs e)
        {
            if (!IsStart) return;
            string info = tb_command.Text;
            if (info == "") return;
            send_cmd(info);
        }
    }
}
