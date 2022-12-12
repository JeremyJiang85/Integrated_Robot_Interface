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
            gbCurrentPosition.Enabled = false;
            lblXyzwpr.Text = "卡式座標\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            lblJoint.Text = "軸座標\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
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
                        richTextBox1.Text += "請選擇手臂型號\r\n";
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
                    richTextBox1.Clear();
                    richTextBox1.Text += "手臂連線成功\r\n";
                    MessageBox.Show("手臂連線成功");
                }
                else
                {
                    richTextBox1.Text += "手臂連線失敗\r\n";
                    MessageBox.Show("手臂連線失敗");
                }
            }
            else
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    richTextBox1.Text += "手臂離線成功\r\n";
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    richTextBox1.Text += "手臂離線失敗\r\n";
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
            if (!myController.Refresh())
            {
                ShowMessage("刷新失敗", "取得刷新狀態");
            }

            if (!myController.Alarm())
            {
                ShowMessage("取得警示失敗", "取得警示狀態");
            }
            else
            {
                if (RobotAdapter.AlarmText != "")
                {
                    ShowMessage($"{RobotAdapter.AlarmText}", "取得警示狀態");
                }
            }

            if (!myController.CPosition())
            {
                ShowMessage("取得卡氏座標失敗", "取得卡氏座標狀態");
            }
            else
            {
                lblXyzwpr.Text = "卡式座標\r\n";
                lblXyzwpr.Text += $"X : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Y : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Z : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"W: {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"P : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"R : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(5)).ToString("###0.000"))}\r\n";
            }

            if (!myController.JPosition())
            {
                ShowMessage("取得軸座標失敗", "取得軸座標狀態");
            }
            else
            {
                lblJoint.Text = "卡式座標\r\n";
                lblJoint.Text += $"J1 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J2 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J3 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J4 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J5 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J6 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(5)).ToString("###0.000"))}\r\n";
            }
        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            timer1.Enabled = false;
            richTextBox1.Text += $"{content}\r\n";
            result = MessageBox.Show($"{content}", $"{title}", MessageBoxButtons.AbortRetryIgnore);
            if (result == DialogResult.Abort)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    richTextBox1.Text += "手臂離線成功\r\n";
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    timer1.Enabled = true;
                    richTextBox1.Text += "手臂離線失敗\r\n";
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
