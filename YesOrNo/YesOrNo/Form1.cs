using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesOrNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            picYes.Visible = true;
            picNo.Visible = false;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            picNo.Visible = true;
            picYes.Visible = false;
        }

        private void notSureBtn_Click(object sender, EventArgs e)
        {
            picYes.Visible = false;
            picNo.Visible = false;
        }
    }
}
