namespace GameProject
{
    partial class Slide1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slide1));
            this.introTxt = new System.Windows.Forms.RichTextBox();
            this.Slide1Ctnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introTxt
            // 
            this.introTxt.Font = new System.Drawing.Font("MS Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introTxt.Location = new System.Drawing.Point(0, 0);
            this.introTxt.Name = "introTxt";
            this.introTxt.Size = new System.Drawing.Size(1039, 178);
            this.introTxt.TabIndex = 0;
            this.introTxt.Text = resources.GetString("introTxt.Text");
            // 
            // Slide1Ctnbtn
            // 
            this.Slide1Ctnbtn.Location = new System.Drawing.Point(860, 353);
            this.Slide1Ctnbtn.Name = "Slide1Ctnbtn";
            this.Slide1Ctnbtn.Size = new System.Drawing.Size(112, 36);
            this.Slide1Ctnbtn.TabIndex = 1;
            this.Slide1Ctnbtn.Text = "Continue";
            this.Slide1Ctnbtn.UseVisualStyleBackColor = true;
            this.Slide1Ctnbtn.Click += new System.EventHandler(this.Slide1Ctnbtn_Click);
            // 
            // Slide1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.Slide1Ctnbtn);
            this.Controls.Add(this.introTxt);
            this.Name = "Slide1";
            this.Text = "Slide1";
            this.Load += new System.EventHandler(this.Slide1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox introTxt;
        private System.Windows.Forms.Button Slide1Ctnbtn;
    }
}