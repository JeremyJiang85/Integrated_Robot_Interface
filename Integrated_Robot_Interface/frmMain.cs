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
        
        

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_Fanuc.Checked)
            {
                mycontroller.Robot = (int)Controller.Robotnum.Fanuc;
                mycontroller.IP = textBox1.Text;
            }
            else
            {
                mycontroller.Robot = (int)Controller.Robotnum.Null;
            }

            MessageBox.Show(mycontroller.Robot.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            mycontroller.Connect();
        }

        private void rb_Fanuc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
