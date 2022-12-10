using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public partial class FrmMain : Form
    {
        //變數宣告
        Controller myController = new Controller();
        
        public bool fgConnectionStatus { get; set; } = false;
        


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 500;
            txtIP.Enabled = false;
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString()};
            cboRobot.Items.AddRange(Robot);
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
            richTextBox1.Enabled = false;
        }

        private void Initialize()
        {
            timer1.Enabled = false;
            txtIP.Enabled = false;
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
            fgConnectionStatus = false;
            lblConnectionStatus.Text = "Connection Status : Disconnected";
            btnConnection.Text = "Connect";
            cboRobot.Enabled = true;
            richTextBox1.Enabled = false;
        }


        #region <gbConnection>
        private void cboRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboRobot.SelectedIndex)
            {
                case (int)Controller.Robotnum.Fanuc:
                    myController.Robot = (int)Controller.Robotnum.Fanuc;
                    txtIP.Enabled = true;
                    break;
                case (int)Controller.Robotnum.Nexcom:
                    myController.Robot = (int)Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    break;
                case (int)Controller.Robotnum.Ourarm:
                    myController.Robot = (int)Controller.Robotnum.Ourarm;
                    txtIP.Enabled = false;
                    break;
                default:
                    myController.Robot = (int)Controller.Robotnum.None;
                    txtIP.Enabled = false;
                    break;
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!fgConnectionStatus)
            {
                switch (myController.Robot)
                {
                    case (int)Controller.Robotnum.Fanuc:
                        RobotAdapter.IP = txtIP.Text;
                        break;
                    case (int)Controller.Robotnum.Nexcom:
                        break;
                    case (int)Controller.Robotnum.Ourarm:
                        break;
                    default:
                        MessageBox.Show("請選擇手臂型號");
                        return;
                }
                if (myController.Connect())
                {
                    fgConnectionStatus = true;
                    lblConnectionStatus.Text = "Connection Status : Connected";
                    btnConnection.Text = "Disconnect";
                    cboRobot.Enabled = false;
                    timer1.Enabled = true;
                    txtIP.Enabled = false;
                    richTextBox1.Enabled = true;
                    MessageBox.Show("手臂連線成功");
                }
                else
                {
                    MessageBox.Show("手臂連線失敗");
                }
            }
            else
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    MessageBox.Show("手臂離線失敗");
                }
            }
        }
        #endregion

        #region <NOgb>

        #endregion
        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult result;
            if (!myController.Refresh())
            {
                timer1.Enabled = false;
                result = MessageBox.Show("Refresh失敗", "Refresh狀態", MessageBoxButtons.AbortRetryIgnore);
                if (result == DialogResult.Abort)
                {
                    if (myController.Disconnect())
                    {
                        Initialize();
                        MessageBox.Show("手臂離線成功");
                    }
                    else
                    {
                        timer1.Enabled = true;
                        MessageBox.Show("手臂離線失敗");
                    }
                }
                else 
                {
                    timer1.Enabled = true;
                }
            }

            if (!myController.Alarm())
            {
                timer1.Enabled = false;
                result = MessageBox.Show("取得警示失敗", "取得警示狀態", MessageBoxButtons.AbortRetryIgnore);
                if (result == DialogResult.Abort)
                {
                    if (myController.Disconnect())
                    {
                        Initialize();
                        MessageBox.Show("手臂離線成功");
                    }
                    else
                    {
                        timer1.Enabled = true;
                        MessageBox.Show("手臂離線失敗");
                    }
                }
                else
                {
                    timer1.Enabled = true;
                }
            }
            else
            {
                if (RobotAdapter.AlarmText != "")
                {
                    timer1.Enabled = false;
                    richTextBox1.Text += RobotAdapter.AlarmText;
                    result = MessageBox.Show($"{RobotAdapter.AlarmText}", "取得警示狀態", MessageBoxButtons.AbortRetryIgnore);
                    if (result == DialogResult.Abort)
                    {
                        if (myController.Disconnect())
                        {
                            Initialize();
                            MessageBox.Show("手臂離線成功");
                        }
                        else
                        {
                            timer1.Enabled = true;
                            MessageBox.Show("手臂離線失敗");
                        }
                    }
                    else
                    {
                        timer1.Enabled = true;
                    }
                }
                
            }
        }
    }
}
