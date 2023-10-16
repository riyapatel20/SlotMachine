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
        Random myrndStop = new Random();

        public frmSlot()
        {
            InitializeComponent();
        }

        private void tmrWheel1_Tick(object sender, EventArgs e)
        {
            PictureWheel(lblWheel1, pbxWheel1);
                tmrWheel1.Enabled = !StopWheel();
        }
        void PictureWheel(Label lbl, PictureBox PicBox)
        {
            int intCounter = int.Parse(lbl.Text);
            intCounter++;
            if (intCounter == 8)
            {
                intCounter = 1;
            }
            lbl.Text = intCounter.ToString();
            PictureBox pbx = (PictureBox)this.Controls["pbx" + intCounter.ToString()];
            PicBox.BackgroundImage = pbx.BackgroundImage;

        }
        bool StopWheel()
        {
            int intMyStopNumber = myrndStop.Next(10);
            if (intMyStopNumber == 6)
            {
                return true;
            }
            return false;
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            tmrWheel1.Enabled = true;
            tmrWheel2.Enabled = true;
            tmrWheel3.Enabled = true;
        }

        private void frmSlot_Load(object sender, EventArgs e)
        {

        }

        private void pbxWheel1_Click(object sender, EventArgs e)
        {

        }

        private void tmrWheel2_Tick(object sender, EventArgs e)
        {
            PictureWheel(lblWheel2, pbxWheel2);
            if (!tmrWheel1.Enabled)
            {
                tmrWheel2.Enabled = !StopWheel();
            }
            
        }

        private void tmrWheel3_Tick(object sender, EventArgs e)
        {
            PictureWheel(lblWheel3, pbxWheel3);
            if (!tmrWheel2.Enabled)
            {
                tmrWheel3.Enabled = !StopWheel();
            }
           
        }
    } 
    
}
