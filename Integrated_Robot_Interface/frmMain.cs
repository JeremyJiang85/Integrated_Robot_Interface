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
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString()};
            cboRobot.Items.AddRange(Robot);
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
        }

        #region <gbConnection>

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!fgConnectionStatus)
            {
                switch (myController.Robot)
                {
                    case (int)Controller.Robotnum.Fanuc:
                        myController.IP = txtIP.Text;
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
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    MessageBox.Show("手臂離線失敗");
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
