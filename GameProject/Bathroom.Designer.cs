namespace GameProject
{
    partial class Bathroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bathroom));
            this.MRbtn1 = new System.Windows.Forms.Button();
            this.MRbtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tankcvrlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MRbtn1
            // 
            this.MRbtn1.BackColor = System.Drawing.Color.Transparent;
            this.MRbtn1.Location = new System.Drawing.Point(623, 264);
            this.MRbtn1.Name = "MRbtn1";
            this.MRbtn1.Size = new System.Drawing.Size(150, 112);
            this.MRbtn1.TabIndex = 0;
            this.MRbtn1.Text = "Back to main room";
            this.MRbtn1.UseVisualStyleBackColor = false;
            this.MRbtn1.Click += new System.EventHandler(this.MRbtn1_Click);
            // 
            // MRbtn2
            // 
            this.MRbtn2.BackColor = System.Drawing.Color.Transparent;
            this.MRbtn2.Location = new System.Drawing.Point(623, 264);
            this.MRbtn2.Name = "MRbtn2";
            this.MRbtn2.Size = new System.Drawing.Size(150, 112);
            this.MRbtn2.TabIndex = 1;
            this.MRbtn2.Text = "Back to main room";
            this.MRbtn2.UseVisualStyleBackColor = false;
            this.MRbtn2.Visible = false;
            this.MRbtn2.Click += new System.EventHandler(this.MRbtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toilet tank cover";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // tankcvrlbl
            // 
            this.tankcvrlbl.AutoSize = true;
            this.tankcvrlbl.BackColor = System.Drawing.Color.Transparent;
            this.tankcvrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tankcvrlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tankcvrlbl.Location = new System.Drawing.Point(424, 92);
            this.tankcvrlbl.Name = "tankcvrlbl";
            this.tankcvrlbl.Size = new System.Drawing.Size(33, 36);
            this.tankcvrlbl.TabIndex = 3;
            this.tankcvrlbl.Text = "?";
            this.tankcvrlbl.Visible = false;
            // 
            // Bathroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tankcvrlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MRbtn2);
            this.Controls.Add(this.MRbtn1);
            this.Name = "Bathroom";
            this.Text = "Bathroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MRbtn1;
        private System.Windows.Forms.Button MRbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tankcvrlbl;
    }
}