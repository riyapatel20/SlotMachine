using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class frmSlot : Form
    {
        public frmSlot()
        {
            InitializeComponent();
        }

        private void FormSlot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrWheel1.Enabled= true;
        }

        private void tmrWheel1_Tick(object sender, EventArgs e)
        {
            int intCounter = int.Parse(lblWheel1.Text);
            intCounter++;
            if (intCounter==8)
            {
                intCounter = 1;
            }
            lblWheel1.Text = intCounter.ToString();
        }

        private void lblWheel1_Click(object sender, EventArgs e)
        {

        }
    }
}
