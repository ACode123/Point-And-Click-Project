namespace GameProject
{
    partial class Phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phone));
            this.PhoneLink1 = new System.Windows.Forms.LinkLabel();
            this.PhoneLink2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PhoneLink1
            // 
            this.PhoneLink1.AutoSize = true;
            this.PhoneLink1.Location = new System.Drawing.Point(166, 197);
            this.PhoneLink1.Name = "PhoneLink1";
            this.PhoneLink1.Size = new System.Drawing.Size(81, 20);
            this.PhoneLink1.TabIndex = 0;
            this.PhoneLink1.TabStop = true;
            this.PhoneLink1.Text = "Click Here";
            this.PhoneLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneLink1_LinkClicked);
            // 
            // PhoneLink2
            // 
            this.PhoneLink2.AutoSize = true;
            this.PhoneLink2.Location = new System.Drawing.Point(166, 266);
            this.PhoneLink2.Name = "PhoneLink2";
            this.PhoneLink2.Size = new System.Drawing.Size(75, 20);
            this.PhoneLink2.TabIndex = 1;
            this.PhoneLink2.TabStop = true;
            this.PhoneLink2.Text = "Press Me";
            this.PhoneLink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneLink2_LinkClicked);
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 516);
            this.Controls.Add(this.PhoneLink2);
            this.Controls.Add(this.PhoneLink1);
            this.DoubleBuffered = true;
            this.Name = "Phone";
            this.Text = "Phone";
            this.Load += new System.EventHandler(this.Phone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel PhoneLink1;
        private System.Windows.Forms.LinkLabel PhoneLink2;
    }
}