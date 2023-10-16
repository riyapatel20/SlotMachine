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
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbxWheel3 = new System.Windows.Forms.PictureBox();
            this.lblWheel3 = new System.Windows.Forms.Label();
            this.pbxWheel2 = new System.Windows.Forms.PictureBox();
            this.lblWheel2 = new System.Windows.Forms.Label();
            this.tmrWheel2 = new System.Windows.Forms.Timer(this.components);
            this.tmrWheel3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWheel1
            // 
            this.lblWheel1.AutoSize = true;
            this.lblWheel1.Location = new System.Drawing.Point(192, 98);
            this.lblWheel1.Name = "lblWheel1";
            this.lblWheel1.Size = new System.Drawing.Size(13, 13);
            this.lblWheel1.TabIndex = 0;
            this.lblWheel1.Text = "1";
            // 
            // btnHandle
            // 
            this.btnHandle.Location = new System.Drawing.Point(596, 68);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(75, 267);
            this.btnHandle.TabIndex = 1;
            this.btnHandle.Text = "Pull";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // tmrWheel1
            // 
            this.tmrWheel1.Tick += new System.EventHandler(this.tmrWheel1_Tick);
            // 
            // pbxWheel1
            // 
            this.pbxWheel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel1.Location = new System.Drawing.Point(147, 130);
            this.pbxWheel1.Name = "pbxWheel1";
            this.pbxWheel1.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel1.TabIndex = 2;
            this.pbxWheel1.TabStop = false;
            this.pbxWheel1.Click += new System.EventHandler(this.pbxWheel1_Click);
            // 
            // pbx4
            // 
            this.pbx4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx4.BackgroundImage")));
            this.pbx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx4.Location = new System.Drawing.Point(224, 388);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 50);
            this.pbx4.TabIndex = 3;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx5.BackgroundImage")));
            this.pbx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx5.Location = new System.Drawing.Point(330, 388);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(100, 50);
            this.pbx5.TabIndex = 4;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx6.BackgroundImage")));
            this.pbx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx6.Location = new System.Drawing.Point(436, 388);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(100, 50);
            this.pbx6.TabIndex = 5;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx7.BackgroundImage")));
            this.pbx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx7.Location = new System.Drawing.Point(542, 388);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(100, 50);
            this.pbx7.TabIndex = 6;
            this.pbx7.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx3.BackgroundImage")));
            this.pbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx3.Location = new System.Drawing.Point(118, 388);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 50);
            this.pbx3.TabIndex = 7;
            this.pbx3.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx2.BackgroundImage")));
            this.pbx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx2.Location = new System.Drawing.Point(12, 388);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 50);
            this.pbx2.TabIndex = 8;
            this.pbx2.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx1.BackgroundImage")));
            this.pbx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx1.Location = new System.Drawing.Point(648, 388);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 50);
            this.pbx1.TabIndex = 9;
            this.pbx1.TabStop = false;
            // 
            // pbxWheel3
            // 
            this.pbxWheel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel3.Location = new System.Drawing.Point(402, 130);
            this.pbxWheel3.Name = "pbxWheel3";
            this.pbxWheel3.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel3.TabIndex = 11;
            this.pbxWheel3.TabStop = false;
            // 
            // lblWheel3
            // 
            this.lblWheel3.AutoSize = true;
            this.lblWheel3.Location = new System.Drawing.Point(447, 98);
            this.lblWheel3.Name = "lblWheel3";
            this.lblWheel3.Size = new System.Drawing.Size(13, 13);
            this.lblWheel3.TabIndex = 10;
            this.lblWheel3.Text = "1";
            // 
            // pbxWheel2
            // 
            this.pbxWheel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel2.Location = new System.Drawing.Point(269, 130);
            this.pbxWheel2.Name = "pbxWheel2";
            this.pbxWheel2.Size = new System.Drawing.Size(100, 50);
            this.pbxWheel2.TabIndex = 13;
            this.pbxWheel2.TabStop = false;
            // 
            // lblWheel2
            // 
            this.lblWheel2.AutoSize = true;
            this.lblWheel2.Location = new System.Drawing.Point(314, 98);
            this.lblWheel2.Name = "lblWheel2";
            this.lblWheel2.Size = new System.Drawing.Size(13, 13);
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
            // frmSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxWheel2);
            this.Controls.Add(this.lblWheel2);
            this.Controls.Add(this.pbxWheel3);
            this.Controls.Add(this.lblWheel3);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbxWheel1);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.lblWheel1);
            this.Name = "frmSlot";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWheel1;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Timer tmrWheel1;
        private System.Windows.Forms.PictureBox pbxWheel1;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbxWheel3;
        private System.Windows.Forms.Label lblWheel3;
        private System.Windows.Forms.PictureBox pbxWheel2;
        private System.Windows.Forms.Label lblWheel2;
        private System.Windows.Forms.Timer tmrWheel2;
        private System.Windows.Forms.Timer tmrWheel3;
    }
}

