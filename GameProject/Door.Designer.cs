namespace GameProject
{
    partial class Door
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Door));
            this.combotxt = new System.Windows.Forms.TextBox();
            this.DoorMRbtn1 = new System.Windows.Forms.Button();
            this.MRbtn2 = new System.Windows.Forms.Button();
            this.Openbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.OpnDoorbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combotxt
            // 
            this.combotxt.Location = new System.Drawing.Point(220, 265);
            this.combotxt.Name = "combotxt";
            this.combotxt.Size = new System.Drawing.Size(135, 26);
            this.combotxt.TabIndex = 0;
            this.combotxt.Visible = false;
            this.combotxt.Validating += new System.ComponentModel.CancelEventHandler(this.combotxt_Validating);
            // 
            // DoorMRbtn1
            // 
            this.DoorMRbtn1.Location = new System.Drawing.Point(673, 204);
            this.DoorMRbtn1.Name = "DoorMRbtn1";
            this.DoorMRbtn1.Size = new System.Drawing.Size(159, 58);
            this.DoorMRbtn1.TabIndex = 1;
            this.DoorMRbtn1.Text = "Back to the main room ";
            this.DoorMRbtn1.UseVisualStyleBackColor = true;
            this.DoorMRbtn1.Visible = false;
            this.DoorMRbtn1.Click += new System.EventHandler(this.DoorMRbtn1_Click);
            // 
            // MRbtn2
            // 
            this.MRbtn2.Location = new System.Drawing.Point(673, 204);
            this.MRbtn2.Name = "MRbtn2";
            this.MRbtn2.Size = new System.Drawing.Size(159, 58);
            this.MRbtn2.TabIndex = 2;
            this.MRbtn2.Text = "Back to the main room ";
            this.MRbtn2.UseVisualStyleBackColor = true;
            this.MRbtn2.Visible = false;
            this.MRbtn2.Click += new System.EventHandler(this.MRbtn2_Click);
            // 
            // Openbtn
            // 
            this.Openbtn.Location = new System.Drawing.Point(220, 349);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(149, 36);
            this.Openbtn.TabIndex = 3;
            this.Openbtn.Text = "Open the door";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Visible = false;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(220, 391);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(162, 37);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit Code";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Visible = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // OpnDoorbtn
            // 
            this.OpnDoorbtn.Location = new System.Drawing.Point(198, 184);
            this.OpnDoorbtn.Name = "OpnDoorbtn";
            this.OpnDoorbtn.Size = new System.Drawing.Size(142, 47);
            this.OpnDoorbtn.TabIndex = 5;
            this.OpnDoorbtn.Text = "Open the Door!";
            this.OpnDoorbtn.UseVisualStyleBackColor = true;
            this.OpnDoorbtn.Visible = false;
            this.OpnDoorbtn.Click += new System.EventHandler(this.OpnDoorbtn_Click);
            // 
            // Door
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 555);
            this.Controls.Add(this.OpnDoorbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.MRbtn2);
            this.Controls.Add(this.DoorMRbtn1);
            this.Controls.Add(this.combotxt);
            this.Name = "Door";
            this.Text = "Door";
            this.Load += new System.EventHandler(this.Door_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox combotxt;
        private System.Windows.Forms.Button DoorMRbtn1;
        private System.Windows.Forms.Button MRbtn2;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button OpnDoorbtn;
    }
}