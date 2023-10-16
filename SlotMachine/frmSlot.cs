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
        //This form level variable allows for randomization of stops
        Random myrndStop = new Random();
        //This is where money is stored
        decimal mydecMoney = 100;
        decimal mydecWinnings = 0;
        decimal mydecBet = 20;

        public frmSlot()
        {
            InitializeComponent();
        }
        void Money()
        {
            if (mydecMoney <=0)
            {
                //This message will pop up when the player loses the game. The message will go away and the game will reset when the player closes the message.  
                MessageBox.Show("Gambling is bad, but come back and try again later.", "Loser!");
                ResetTheGame();
            }
            if (mydecBet > mydecMoney)
            {
                mydecBet = mydecMoney;
            }
            //this enables the bet buttons
            btnBet50.Enabled = mydecMoney >= 50;
            btnBet20.Enabled = mydecMoney >= 20;
            
            lblBalance.Text = mydecMoney.ToString("C");
            lblBet.Text = mydecBet.ToString("C");
            lblWinnings.Text = mydecWinnings.ToString("C");
        }
        private void tmrWheel1_Tick(object sender, EventArgs e)
        {
            //This will change the picture on the first wheel
            //it will then randomly stop the timer on a picture
            PictureWheel(lblWheel1, pbxWheel1);
                tmrWheel1.Enabled = !StopWheel();
        }
       
        void PictureWheel(Label lbl, PictureBox PicBox)
        {
            //This will set the next picture for a given wheel 
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
        //this stops the pictures in the slot machine
        bool StopWheel()
        {
            int intStopNumber = myrndStop.Next(10);
            if (intStopNumber == 6)
            {
                return true;
            }
            return false;
        }

        private async void btnHandle_Click(object sender, EventArgs e)
        {
            //this disables the button after you click it once
            btnHandle.Enabled = false;


            //this is the same as mydecMoney = mydecMoney - mydecBet;
            mydecMoney -= mydecBet;    
                        
            //This will stop any winning lights
            tmrWinWheel.Enabled = false;
            pbxWinWheel1.Visible = false;
            pbxWinWheel2.Visible = false;
            pbxWinWheel3.Visible = false;

            tmrWheel1.Enabled= true;
            tmrWheel2.Enabled= true;
            tmrWheel3.Enabled= true;

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
                //Everything is done ...so we can check if they won
                if (!tmrWheel3.Enabled)
                {
                    WinLose();
                }
            }
           
            void WinLose()
            {
                mydecWinnings = 0;
                //This will check if the game is won and set up the
                //winning Lights
                pbxWinWheel1.Visible = false;
                pbxWinWheel2.Visible = false;
                pbxWinWheel3.Visible = false;

                if (lblWheel1.Text == lblWheel2.Text && lblWheel2.Text == lblWheel3.Text)
                {
                    //The background will light up when they win 
                    pbxWinWheel1.Visible = true;
                    pbxWinWheel2.Visible = true;
                    pbxWinWheel3.Visible = true;
                    //this is how much money you win if you get all three slots 
                    mydecWinnings = mydecBet * 10;

                }
                else if (lblWheel1.Text == lblWheel2.Text)
                {
                    //kinda a winner
                    pbxWinWheel1.Visible = true;
                    pbxWinWheel2.Visible = true;
                    //this is how much money you win if you're kind of a winner
                    mydecWinnings = mydecBet * 2;
                }
                else if (lblWheel1.Text == lblWheel3.Text)
                {
                    pbxWinWheel1.Visible = true;
                    pbxWinWheel3.Visible = true;
                    mydecWinnings = mydecBet * 2;
                }
                else if (lblWheel2.Text == lblWheel3.Text)
                {
                    pbxWinWheel2.Visible = true;
                    pbxWinWheel3.Visible = true;
                    mydecWinnings = mydecBet * 2;
                }
                else
                {
                    //LOSER!
                }
                tmrWinWheel.Enabled = true;
                //this adds your money back if you win 
                mydecMoney += mydecWinnings;
                Money();
            }
        }
        //if they win, the background will light up those colors 
        private void tmrWinWheel_Tick(object sender, EventArgs e)
        {
            if (pbxWinWheel1.BackColor == Color.YellowGreen)
            {
                pbxWinWheel1.BackColor = Color.Salmon;
            }else if (pbxWinWheel1.BackColor == Color.Salmon)
                {
                    pbxWinWheel1.BackColor = Color.Orchid;
                }
            else 
            {
                pbxWinWheel1.BackColor = Color.YellowGreen;
            }
            pbxWinWheel2.BackColor = pbxWinWheel1.BackColor;
            pbxWinWheel3.BackColor = pbxWinWheel1.BackColor;
            //this if statement below was moved to the pull button up top 
            //if (StopWheel())
            //{
            //    tmrWinWheel.Enabled = false;
            //    pbxWinWheel1.Visible = false;
            //    pbxWinWheel2.Visible = false;
            //    pbxWinWheel3.Visible = false;
            //}

            //this allows the player to pull the handle again after the wheels stop spinning 
            btnHandle.Enabled = true;
        }

        private void frmSlot_Load(object sender, EventArgs e)
        {
            //This will display the money on the screen
            ResetTheGame();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTheGame();
        }
        void ResetTheGame()
        {
            mydecMoney = 100;
            mydecBet = 20;
            mydecWinnings = 0;
            Money();
        }
        //these turn the bet button into money and lets the player click and bet whatever the amount listed
        private void btnBet50_Click(object sender, EventArgs e)
        {
            mydecBet = 50;
            btnBet50.Enabled = false;
            Money();
        }
        //this lets the player bet $20
        private void button1_Click(object sender, EventArgs e)
        {
            mydecBet = 20;
            btnBet20.Enabled = false;
            Money();
        }
        //this lets the player bet *2 of mydecBet
        private void btnBetDouble_Click(object sender, EventArgs e)
        {
            mydecBet = mydecBet * 2;
            btnBetDouble.Enabled = true;
            Money();
        }

    }
}
