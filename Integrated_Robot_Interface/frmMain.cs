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
            FormInitialize();
        }

        private void FormInitialize()
        {
            txtIP.Enabled = false;
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString()};
            cboRobot.Items.AddRange(Robot);
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
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
                    break;
                case (int)Controller.Robotnum.Ourarm:
                    myController.Robot = (int)Controller.Robotnum.Ourarm;
                    break;
                default:
                    myController.Robot = (int)Controller.Robotnum.None;
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
                        FanucAdapter.IP = txtIP.Text;
                        txtIP.Enabled = false;
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
                    fgConnectionStatus = false;
                    lblConnectionStatus.Text = "Connection Status : Disconnected";
                    btnConnection.Text = "Connect";
                    cboRobot.Enabled = true;
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    MessageBox.Show("手臂離線失敗");
                }
                switch (myController.Robot)
                {
                    case (int)Controller.Robotnum.Fanuc:
                        txtIP.Enabled = true;
                        break;
                    case (int)Controller.Robotnum.Nexcom:
                        break;
                    case (int)Controller.Robotnum.Ourarm:
                        break;
                    default:
                        MessageBox.Show("請選擇手臂型號");
                        return;
                }
            }
        }
        #endregion

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
