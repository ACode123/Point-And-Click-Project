namespace GameProject
{
    partial class TheEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheEnd));
            this.Endtextbox1 = new System.Windows.Forms.RichTextBox();
            this.Contbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Endtextbox1
            // 
            this.Endtextbox1.Location = new System.Drawing.Point(44, 12);
            this.Endtextbox1.Name = "Endtextbox1";
            this.Endtextbox1.Size = new System.Drawing.Size(693, 191);
            this.Endtextbox1.TabIndex = 0;
            this.Endtextbox1.Text = resources.GetString("Endtextbox1.Text");
            // 
            // Contbtn
            // 
            this.Contbtn.Location = new System.Drawing.Point(535, 238);
            this.Contbtn.Name = "Contbtn";
            this.Contbtn.Size = new System.Drawing.Size(154, 47);
            this.Contbtn.TabIndex = 1;
            this.Contbtn.Text = "Continue";
            this.Contbtn.UseVisualStyleBackColor = true;
            this.Contbtn.Click += new System.EventHandler(this.Contbtn_Click);
            // 
            // TheEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contbtn);
            this.Controls.Add(this.Endtextbox1);
            this.Name = "TheEnd";
            this.Text = "TheEnd";
            this.Load += new System.EventHandler(this.TheEnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Endtextbox1;
        private System.Windows.Forms.Button Contbtn;
    }
}