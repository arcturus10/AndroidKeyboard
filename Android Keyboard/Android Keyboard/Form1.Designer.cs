namespace Android_Keyboard
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check for Devices";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Wingdings 3", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(193, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(10, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 360);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Wingdings", 13F);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(280, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 64);
            this.button4.TabIndex = 2;
            this.button4.Text = "v";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ArrowDlg_Open);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Image = global::Android_Keyboard.Properties.Resources.sync_alt_FILL0_wght400_GRAD0_opsz48;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 404);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(170, 63);
            this.button8.TabIndex = 5;
            this.button8.Text = "Tab";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.TabKeyClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.BackgroundImage = global::Android_Keyboard.Properties.Resources.backspace_FILL0_wght400_GRAD0_opsz48;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Font = new System.Drawing.Font("Wingdings 3", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(370, 404);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 63);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(543, 479);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Keyboard";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
    }
}

