namespace GameProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tutorialBtn = new System.Windows.Forms.Button();
            this.EntGmbtn = new System.Windows.Forms.Button();
            this.MMlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tutorialBtn
            // 
            this.tutorialBtn.Location = new System.Drawing.Point(344, 292);
            this.tutorialBtn.Name = "tutorialBtn";
            this.tutorialBtn.Size = new System.Drawing.Size(81, 35);
            this.tutorialBtn.TabIndex = 0;
            this.tutorialBtn.Text = "Tutorial";
            this.tutorialBtn.UseVisualStyleBackColor = true;
            this.tutorialBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntGmbtn
            // 
            this.EntGmbtn.Location = new System.Drawing.Point(328, 234);
            this.EntGmbtn.Name = "EntGmbtn";
            this.EntGmbtn.Size = new System.Drawing.Size(113, 37);
            this.EntGmbtn.TabIndex = 3;
            this.EntGmbtn.Text = "Enter Game";
            this.EntGmbtn.UseVisualStyleBackColor = true;
            this.EntGmbtn.Click += new System.EventHandler(this.EntGmbtn_Click);
            // 
            // MMlbl
            // 
            this.MMlbl.AutoSize = true;
            this.MMlbl.BackColor = System.Drawing.Color.Transparent;
            this.MMlbl.Font = new System.Drawing.Font("Onyx", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMlbl.Location = new System.Drawing.Point(318, 29);
            this.MMlbl.Name = "MMlbl";
            this.MMlbl.Size = new System.Drawing.Size(136, 55);
            this.MMlbl.TabIndex = 4;
            this.MMlbl.Text = "120 DAYS";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.MMlbl);
            this.Controls.Add(this.EntGmbtn);
            this.Controls.Add(this.tutorialBtn);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tutorialBtn;
        private System.Windows.Forms.Button EntGmbtn;
        private System.Windows.Forms.Label MMlbl;
    }
}

