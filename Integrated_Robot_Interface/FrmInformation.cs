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
    public partial class FrmInformation : Form
    {
        public FrmInformation()
        {
            InitializeComponent();
        }

        private void FrmFanuc_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            gbInformation1.Text = RobotAdapter.Information1name;
            gbInformation2.Text = RobotAdapter.Information2name;
            gbInformation3.Text = RobotAdapter.Information3name;
            gbInformation4.Text = RobotAdapter.Information4name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInformation1.Text = RobotAdapter.Information1text;
            lblInformation2.Text = RobotAdapter.Information2text;
            lblInformation3.Text = RobotAdapter.Information3text;
            lblInformation4.Text = RobotAdapter.Information4text;
        }

    }
}
