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
    public partial class FrmFanuc : Form
    {
        public FrmFanuc()
        {
            InitializeComponent();
        }

        private void FrmFanuc_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            lblUI.Text = RobotAdapter.Information;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUI.Text = RobotAdapter.Information;
        }

    }
}
