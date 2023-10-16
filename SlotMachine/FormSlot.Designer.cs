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
            this.lblWheel1 = new System.Windows.Forms.Label();
            this.BTN = new System.Windows.Forms.Button();
            this.tmrWheel1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWheel1
            // 
            this.lblWheel1.AutoSize = true;
            this.lblWheel1.Location = new System.Drawing.Point(270, 105);
            this.lblWheel1.Name = "lblWheel1";
            this.lblWheel1.Size = new System.Drawing.Size(13, 13);
            this.lblWheel1.TabIndex = 0;
            this.lblWheel1.Text = "1";
            this.lblWheel1.Click += new System.EventHandler(this.lblWheel1_Click);
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(536, 50);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(112, 280);
            this.BTN.TabIndex = 1;
            this.BTN.Text = "Pull";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrWheel1
            // 
            this.tmrWheel1.Tick += new System.EventHandler(this.tmrWheel1_Tick);
            // 
            // frmSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.lblWheel1);
            this.Name = "frmSlot";
            this.Text = "frmSlot1";
            this.Load += new System.EventHandler(this.FormSlot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWheel1;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Timer tmrWheel1;
    }
}

