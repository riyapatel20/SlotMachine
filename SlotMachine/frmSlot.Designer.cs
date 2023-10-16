namespace SlotMachine
{
    partial class frmSlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlot));
            this.lblWheel1 = new System.Windows.Forms.Label();
            this.btnHandle = new System.Windows.Forms.Button();
            this.tmrWheel1 = new System.Windows.Forms.Timer(this.components);
            this.pbxWheel1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbxWheel3 = new System.Windows.Forms.PictureBox();
            this.lblWheel3 = new System.Windows.Forms.Label();
            this.pbxWheel2 = new System.Windows.Forms.PictureBox();
            this.lblWheel2 = new System.Windows.Forms.Label();
            this.tmrWheel2 = new System.Windows.Forms.Timer(this.components);
            this.tmrWheel3 = new System.Windows.Forms.Timer(this.components);
            this.pbxWinWheel1 = new System.Windows.Forms.PictureBox();
            this.pbxWinWheel2 = new System.Windows.Forms.PictureBox();
            this.pbxWinWheel3 = new System.Windows.Forms.PictureBox();
            this.tmrWinWheel = new System.Windows.Forms.Timer(this.components);
            this.lblBalanceLabel = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblBetLabel = new System.Windows.Forms.Label();
            this.lblWinningsLabel = new System.Windows.Forms.Label();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet20 = new System.Windows.Forms.Button();
            this.btnBetDouble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWheel1
            // 
            this.lblWheel1.AutoSize = true;
            this.lblWheel1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheel1.Location = new System.Drawing.Point(196, 151);
            this.lblWheel1.Name = "lblWheel1";
            this.lblWheel1.Size = new System.Drawing.Size(15, 16);
            this.lblWheel1.TabIndex = 0;
            this.lblWheel1.Text = "1";
            // 
            // btnHandle
            // 
            this.btnHandle.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHandle.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandle.Location = new System.Drawing.Point(608, 80);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(75, 277);
            this.btnHandle.TabIndex = 1;
            this.btnHandle.Text = "Pull";
            this.btnHandle.UseVisualStyleBackColor = false;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // tmrWheel1
            // 
            this.tmrWheel1.Tick += new System.EventHandler(this.tmrWheel1_Tick);
            // 
            // pbxWheel1
            // 
            this.pbxWheel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel1.Location = new System.Drawing.Point(152, 183);
            this.pbxWheel1.Name = "pbxWheel1";
            this.pbxWheel1.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel1.TabIndex = 2;
            this.pbxWheel1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx2.BackgroundImage")));
            this.pbx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx2.Location = new System.Drawing.Point(132, 389);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 50);
            this.pbx2.TabIndex = 3;
            this.pbx2.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx1.BackgroundImage")));
            this.pbx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx1.Location = new System.Drawing.Point(26, 389);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 50);
            this.pbx1.TabIndex = 4;
            this.pbx1.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx3.BackgroundImage")));
            this.pbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx3.Location = new System.Drawing.Point(238, 389);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 50);
            this.pbx3.TabIndex = 5;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx4.BackgroundImage")));
            this.pbx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx4.Location = new System.Drawing.Point(344, 389);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 50);
            this.pbx4.TabIndex = 6;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx5.BackgroundImage")));
            this.pbx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx5.Location = new System.Drawing.Point(450, 389);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(100, 50);
            this.pbx5.TabIndex = 7;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx6.BackgroundImage")));
            this.pbx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx6.Location = new System.Drawing.Point(556, 389);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(100, 50);
            this.pbx6.TabIndex = 8;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx7.BackgroundImage")));
            this.pbx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx7.Location = new System.Drawing.Point(662, 389);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(100, 50);
            this.pbx7.TabIndex = 9;
            this.pbx7.TabStop = false;
            // 
            // pbxWheel3
            // 
            this.pbxWheel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel3.Location = new System.Drawing.Point(439, 183);
            this.pbxWheel3.Name = "pbxWheel3";
            this.pbxWheel3.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel3.TabIndex = 11;
            this.pbxWheel3.TabStop = false;
            // 
            // lblWheel3
            // 
            this.lblWheel3.AutoSize = true;
            this.lblWheel3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheel3.Location = new System.Drawing.Point(479, 152);
            this.lblWheel3.Name = "lblWheel3";
            this.lblWheel3.Size = new System.Drawing.Size(15, 16);
            this.lblWheel3.TabIndex = 10;
            this.lblWheel3.Text = "1";
            // 
            // pbxWheel2
            // 
            this.pbxWheel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel2.Location = new System.Drawing.Point(299, 183);
            this.pbxWheel2.Name = "pbxWheel2";
            this.pbxWheel2.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel2.TabIndex = 13;
            this.pbxWheel2.TabStop = false;
            // 
            // lblWheel2
            // 
            this.lblWheel2.AutoSize = true;
            this.lblWheel2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheel2.Location = new System.Drawing.Point(343, 151);
            this.lblWheel2.Name = "lblWheel2";
            this.lblWheel2.Size = new System.Drawing.Size(15, 16);
            this.lblWheel2.TabIndex = 12;
            this.lblWheel2.Text = "1";
            // 
            // tmrWheel2
            // 
            this.tmrWheel2.Tick += new System.EventHandler(this.tmrWheel2_Tick);
            // 
            // tmrWheel3
            // 
            this.tmrWheel3.Tick += new System.EventHandler(this.tmrWheel3_Tick);
            // 
            // pbxWinWheel1
            // 
            this.pbxWinWheel1.Location = new System.Drawing.Point(135, 173);
            this.pbxWinWheel1.Name = "pbxWinWheel1";
            this.pbxWinWheel1.Size = new System.Drawing.Size(131, 70);
            this.pbxWinWheel1.TabIndex = 14;
            this.pbxWinWheel1.TabStop = false;
            // 
            // pbxWinWheel2
            // 
            this.pbxWinWheel2.Location = new System.Drawing.Point(282, 173);
            this.pbxWinWheel2.Name = "pbxWinWheel2";
            this.pbxWinWheel2.Size = new System.Drawing.Size(131, 70);
            this.pbxWinWheel2.TabIndex = 15;
            this.pbxWinWheel2.TabStop = false;
            // 
            // pbxWinWheel3
            // 
            this.pbxWinWheel3.Location = new System.Drawing.Point(424, 173);
            this.pbxWinWheel3.Name = "pbxWinWheel3";
            this.pbxWinWheel3.Size = new System.Drawing.Size(131, 70);
            this.pbxWinWheel3.TabIndex = 16;
            this.pbxWinWheel3.TabStop = false;
            // 
            // tmrWinWheel
            // 
            this.tmrWinWheel.Tick += new System.EventHandler(this.tmrWinWheel_Tick);
            // 
            // lblBalanceLabel
            // 
            this.lblBalanceLabel.AutoSize = true;
            this.lblBalanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBalanceLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBalanceLabel.Location = new System.Drawing.Point(122, 74);
            this.lblBalanceLabel.Name = "lblBalanceLabel";
            this.lblBalanceLabel.Size = new System.Drawing.Size(64, 16);
            this.lblBalanceLabel.TabIndex = 17;
            this.lblBalanceLabel.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Goldenrod;
            this.lblBalance.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBalance.Location = new System.Drawing.Point(200, 72);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(53, 16);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "label2";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Goldenrod;
            this.lblBet.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBet.Location = new System.Drawing.Point(200, 86);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(53, 16);
            this.lblBet.TabIndex = 19;
            this.lblBet.Text = "label1";
            // 
            // lblBetLabel
            // 
            this.lblBetLabel.AutoSize = true;
            this.lblBetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBetLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBetLabel.Location = new System.Drawing.Point(132, 87);
            this.lblBetLabel.Name = "lblBetLabel";
            this.lblBetLabel.Size = new System.Drawing.Size(32, 16);
            this.lblBetLabel.TabIndex = 20;
            this.lblBetLabel.Text = "Bet";
            // 
            // lblWinningsLabel
            // 
            this.lblWinningsLabel.AutoSize = true;
            this.lblWinningsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWinningsLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWinningsLabel.Location = new System.Drawing.Point(117, 100);
            this.lblWinningsLabel.Name = "lblWinningsLabel";
            this.lblWinningsLabel.Size = new System.Drawing.Size(70, 16);
            this.lblWinningsLabel.TabIndex = 21;
            this.lblWinningsLabel.Text = "Winnings";
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.BackColor = System.Drawing.Color.Goldenrod;
            this.lblWinnings.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWinnings.Location = new System.Drawing.Point(200, 100);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(53, 16);
            this.lblWinnings.TabIndex = 22;
            this.lblWinnings.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(608, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.Indigo;
            this.btnBet50.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet50.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBet50.Location = new System.Drawing.Point(279, 81);
            this.btnBet50.Margin = new System.Windows.Forms.Padding(2);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(76, 28);
            this.btnBet50.TabIndex = 24;
            this.btnBet50.Text = "Bet $50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click);
            // 
            // btnBet20
            // 
            this.btnBet20.BackColor = System.Drawing.Color.Indigo;
            this.btnBet20.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBet20.Location = new System.Drawing.Point(366, 80);
            this.btnBet20.Margin = new System.Windows.Forms.Padding(2);
            this.btnBet20.Name = "btnBet20";
            this.btnBet20.Size = new System.Drawing.Size(77, 29);
            this.btnBet20.TabIndex = 25;
            this.btnBet20.Text = "Bet $20";
            this.btnBet20.UseVisualStyleBackColor = false;
            this.btnBet20.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBetDouble
            // 
            this.btnBetDouble.BackColor = System.Drawing.Color.Indigo;
            this.btnBetDouble.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetDouble.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBetDouble.Location = new System.Drawing.Point(457, 80);
            this.btnBetDouble.Margin = new System.Windows.Forms.Padding(2);
            this.btnBetDouble.Name = "btnBetDouble";
            this.btnBetDouble.Size = new System.Drawing.Size(70, 29);
            this.btnBetDouble.TabIndex = 26;
            this.btnBetDouble.Text = "Bet X 2";
            this.btnBetDouble.UseVisualStyleBackColor = false;
            this.btnBetDouble.Click += new System.EventHandler(this.btnBetDouble_Click);
            // 
            // frmSlot
            // 
            this.AcceptButton = this.btnHandle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(794, 470);
            this.Controls.Add(this.btnBetDouble);
            this.Controls.Add(this.btnBet20);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.lblWinningsLabel);
            this.Controls.Add(this.lblBetLabel);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceLabel);
            this.Controls.Add(this.pbxWheel2);
            this.Controls.Add(this.lblWheel2);
            this.Controls.Add(this.pbxWheel3);
            this.Controls.Add(this.lblWheel3);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbxWheel1);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.lblWheel1);
            this.Controls.Add(this.pbxWinWheel1);
            this.Controls.Add(this.pbxWinWheel2);
            this.Controls.Add(this.pbxWinWheel3);
            this.Name = "frmSlot";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWheel1;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Timer tmrWheel1;
        private System.Windows.Forms.PictureBox pbxWheel1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbxWheel3;
        private System.Windows.Forms.Label lblWheel3;
        private System.Windows.Forms.PictureBox pbxWheel2;
        private System.Windows.Forms.Label lblWheel2;
        private System.Windows.Forms.Timer tmrWheel2;
        private System.Windows.Forms.Timer tmrWheel3;
        private System.Windows.Forms.PictureBox pbxWinWheel1;
        private System.Windows.Forms.PictureBox pbxWinWheel2;
        private System.Windows.Forms.PictureBox pbxWinWheel3;
        private System.Windows.Forms.Timer tmrWinWheel;
        private System.Windows.Forms.Label lblBalanceLabel;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblBetLabel;
        private System.Windows.Forms.Label lblWinningsLabel;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Button btnBet20;
        private System.Windows.Forms.Button btnBetDouble;
    }
}

