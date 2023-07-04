namespace Android_Keyboard
{
    partial class ArrowKeys
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
            this.GBox = new System.Windows.Forms.GroupBox();
            this.Blank = new System.Windows.Forms.GroupBox();
            this.leftBtn = new System.Windows.Forms.Button();
            this.rtBtn = new System.Windows.Forms.Button();
            this.dnBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.GBox.SuspendLayout();
            this.Blank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBox
            // 
            this.GBox.Controls.Add(this.Blank);
            this.GBox.Controls.Add(this.leftBtn);
            this.GBox.Controls.Add(this.rtBtn);
            this.GBox.Controls.Add(this.dnBtn);
            this.GBox.Controls.Add(this.upBtn);
            this.GBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBox.Location = new System.Drawing.Point(0, 65);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(510, 445);
            this.GBox.TabIndex = 0;
            this.GBox.TabStop = false;
            this.GBox.Text = "Directional Pad";
            // 
            // Blank
            // 
            this.Blank.Controls.Add(this.trackBar1);
            this.Blank.Location = new System.Drawing.Point(7, 370);
            this.Blank.Name = "Blank";
            this.Blank.Size = new System.Drawing.Size(497, 63);
            this.Blank.TabIndex = 4;
            this.Blank.TabStop = false;
            this.Blank.Text = "Opacity";
            // 
            // leftBtn
            // 
            this.leftBtn.BackgroundImage = global::Android_Keyboard.Properties.Resources.arrow_back_FILL0_wght400_GRAD200_opsz40;
            this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftBtn.Location = new System.Drawing.Point(10, 211);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(148, 152);
            this.leftBtn.TabIndex = 3;
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rtBtn
            // 
            this.rtBtn.BackgroundImage = global::Android_Keyboard.Properties.Resources.arrow_forward_FILL0_wght400_GRAD200_opsz40;
            this.rtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rtBtn.Location = new System.Drawing.Point(357, 211);
            this.rtBtn.Name = "rtBtn";
            this.rtBtn.Size = new System.Drawing.Size(148, 152);
            this.rtBtn.TabIndex = 3;
            this.rtBtn.UseVisualStyleBackColor = true;
            this.rtBtn.Click += new System.EventHandler(this.rtBtn_Click);
            // 
            // dnBtn
            // 
            this.dnBtn.BackgroundImage = global::Android_Keyboard.Properties.Resources.arrow_downward_FILL0_wght400_GRAD200_opsz40;
            this.dnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dnBtn.Location = new System.Drawing.Point(184, 211);
            this.dnBtn.Name = "dnBtn";
            this.dnBtn.Size = new System.Drawing.Size(148, 152);
            this.dnBtn.TabIndex = 3;
            this.dnBtn.UseVisualStyleBackColor = true;
            this.dnBtn.Click += new System.EventHandler(this.dnBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.BackgroundImage = global::Android_Keyboard.Properties.Resources.arrow_upward_FILL0_wght400_GRAD200_opsz40;
            this.upBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.upBtn.Location = new System.Drawing.Point(184, 20);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(148, 152);
            this.upBtn.TabIndex = 3;
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(491, 44);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ArrowKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 510);
            this.Controls.Add(this.GBox);
            this.MaximizeBox = false;
            this.Name = "ArrowKeys";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrow Keys";
            this.GBox.ResumeLayout(false);
            this.Blank.ResumeLayout(false);
            this.Blank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rtBtn;
        private System.Windows.Forms.Button dnBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.GroupBox Blank;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}