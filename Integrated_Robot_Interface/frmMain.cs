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
        Controller mycontroller = new Controller();
        public static bool fgConnectionStatus = false;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mycontroller = new Controller();
        }
        
        //gbConnection
        private void rdbFanuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFanuc.Checked)
            {
                mycontroller.Robot = (int)Controller.Robotnum.Fanuc;
                lblSelect.Text = "Select Robot : Fanuc";
            }
        }
        private void rdbNexcom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNexcom.Checked)
            {
                mycontroller.Robot = (int)Controller.Robotnum.Nexcom;
                lblSelect.Text = "Select Robot : Nexcom";
            }
        }
        private void rdbOurarm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOurarm.Checked)
            {
                mycontroller.Robot = (int)Controller.Robotnum.Ourarm;
                lblSelect.Text = "Select Robot : Ourarm";
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!fgConnectionStatus)
            {
                switch (mycontroller.Robot)
                {
                    case (int)Controller.Robotnum.Fanuc:
                        mycontroller.IP = txtConnection.Text;
                        break;
                    case (int)Controller.Robotnum.Nexcom:
                        break;
                    case (int)Controller.Robotnum.Ourarm:
                        break;
                    default:
                        MessageBox.Show("請選擇手臂型號");
                        return;
                }
                if (mycontroller.Connect())
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
                if (mycontroller.Disconnect())
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

        
    }
}
