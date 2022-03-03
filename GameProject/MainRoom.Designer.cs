namespace GameProject
{
    partial class MainRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRoom));
            this.GrpInvMR = new System.Windows.Forms.GroupBox();
            this.MRcipherbtn = new System.Windows.Forms.Button();
            this.MRCPbtn = new System.Windows.Forms.Button();
            this.MRbtnOpnInv = new System.Windows.Forms.Button();
            this.MRClsInvbtn = new System.Windows.Forms.Button();
            this.MRcompBtn = new System.Windows.Forms.Button();
            this.MRcptrlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MRbthrmlbl = new System.Windows.Forms.Label();
            this.MRdoorbtn2 = new System.Windows.Forms.Button();
            this.MRdoorbtn1 = new System.Windows.Forms.Button();
            this.GrpInvMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpInvMR
            // 
            this.GrpInvMR.Controls.Add(this.MRcipherbtn);
            this.GrpInvMR.Controls.Add(this.MRCPbtn);
            this.GrpInvMR.Location = new System.Drawing.Point(23, 315);
            this.GrpInvMR.Name = "GrpInvMR";
            this.GrpInvMR.Size = new System.Drawing.Size(267, 147);
            this.GrpInvMR.TabIndex = 0;
            this.GrpInvMR.TabStop = false;
            this.GrpInvMR.Text = "INVENTORY";
            this.GrpInvMR.Visible = false;
            // 
            // MRcipherbtn
            // 
            this.MRcipherbtn.Location = new System.Drawing.Point(15, 43);
            this.MRcipherbtn.Name = "MRcipherbtn";
            this.MRcipherbtn.Size = new System.Drawing.Size(108, 54);
            this.MRcipherbtn.TabIndex = 4;
            this.MRcipherbtn.Text = "Cipher Decoder ";
            this.MRcipherbtn.UseVisualStyleBackColor = true;
            this.MRcipherbtn.Visible = false;
            this.MRcipherbtn.Click += new System.EventHandler(this.MRcipherbtn_Click);
            // 
            // MRCPbtn
            // 
            this.MRCPbtn.Location = new System.Drawing.Point(168, 25);
            this.MRCPbtn.Name = "MRCPbtn";
            this.MRCPbtn.Size = new System.Drawing.Size(75, 58);
            this.MRCPbtn.TabIndex = 2;
            this.MRCPbtn.Text = "Cell Phone";
            this.MRCPbtn.UseVisualStyleBackColor = true;
            this.MRCPbtn.Click += new System.EventHandler(this.MRCPbtn_Click);
            // 
            // MRbtnOpnInv
            // 
            this.MRbtnOpnInv.Location = new System.Drawing.Point(925, 198);
            this.MRbtnOpnInv.Name = "MRbtnOpnInv";
            this.MRbtnOpnInv.Size = new System.Drawing.Size(91, 69);
            this.MRbtnOpnInv.TabIndex = 0;
            this.MRbtnOpnInv.Text = "Open Inventory";
            this.MRbtnOpnInv.UseVisualStyleBackColor = true;
            this.MRbtnOpnInv.Click += new System.EventHandler(this.MRbtnOpnInv_Click);
            // 
            // MRClsInvbtn
            // 
            this.MRClsInvbtn.Location = new System.Drawing.Point(925, 273);
            this.MRClsInvbtn.Name = "MRClsInvbtn";
            this.MRClsInvbtn.Size = new System.Drawing.Size(91, 62);
            this.MRClsInvbtn.TabIndex = 1;
            this.MRClsInvbtn.Text = "Close Inventory";
            this.MRClsInvbtn.UseVisualStyleBackColor = true;
            this.MRClsInvbtn.Visible = false;
            this.MRClsInvbtn.Click += new System.EventHandler(this.MRClsInvbtn_Click);
            // 
            // MRcompBtn
            // 
            this.MRcompBtn.BackColor = System.Drawing.Color.Transparent;
            this.MRcompBtn.Location = new System.Drawing.Point(433, 255);
            this.MRcompBtn.Name = "MRcompBtn";
            this.MRcompBtn.Size = new System.Drawing.Size(189, 89);
            this.MRcompBtn.TabIndex = 2;
            this.MRcompBtn.UseVisualStyleBackColor = false;
            this.MRcompBtn.Click += new System.EventHandler(this.MRcompBtn_Click);
            this.MRcompBtn.MouseEnter += new System.EventHandler(this.MRcompBtn_MouseEnter);
            this.MRcompBtn.MouseLeave += new System.EventHandler(this.MRcompBtn_MouseLeave);
            // 
            // MRcptrlbl
            // 
            this.MRcptrlbl.AutoSize = true;
            this.MRcptrlbl.BackColor = System.Drawing.Color.Transparent;
            this.MRcptrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRcptrlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MRcptrlbl.Location = new System.Drawing.Point(493, 222);
            this.MRcptrlbl.Name = "MRcptrlbl";
            this.MRcptrlbl.Size = new System.Drawing.Size(134, 20);
            this.MRcptrlbl.TabIndex = 3;
            this.MRcptrlbl.Text = "Use Computer?";
            this.MRcptrlbl.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(886, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 104);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // MRbthrmlbl
            // 
            this.MRbthrmlbl.AutoSize = true;
            this.MRbthrmlbl.BackColor = System.Drawing.Color.Transparent;
            this.MRbthrmlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRbthrmlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MRbthrmlbl.Location = new System.Drawing.Point(882, 358);
            this.MRbthrmlbl.Name = "MRbthrmlbl";
            this.MRbthrmlbl.Size = new System.Drawing.Size(147, 20);
            this.MRbthrmlbl.TabIndex = 6;
            this.MRbthrmlbl.Text = "Go to Bathroom?";
            this.MRbthrmlbl.Visible = false;
            // 
            // MRdoorbtn2
            // 
            this.MRdoorbtn2.Location = new System.Drawing.Point(46, 177);
            this.MRdoorbtn2.Name = "MRdoorbtn2";
            this.MRdoorbtn2.Size = new System.Drawing.Size(155, 49);
            this.MRdoorbtn2.TabIndex = 7;
            this.MRdoorbtn2.Text = "Go to the Door";
            this.MRdoorbtn2.UseVisualStyleBackColor = true;
            this.MRdoorbtn2.Visible = false;
            this.MRdoorbtn2.Click += new System.EventHandler(this.MRdoorbtn2_Click);
            // 
            // MRdoorbtn1
            // 
            this.MRdoorbtn1.Location = new System.Drawing.Point(46, 101);
            this.MRdoorbtn1.Name = "MRdoorbtn1";
            this.MRdoorbtn1.Size = new System.Drawing.Size(155, 49);
            this.MRdoorbtn1.TabIndex = 8;
            this.MRdoorbtn1.Text = "Go to the Door";
            this.MRdoorbtn1.UseVisualStyleBackColor = true;
            this.MRdoorbtn1.Click += new System.EventHandler(this.MRdoorbtn1_Click);
            // 
            // MainRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 501);
            this.Controls.Add(this.MRdoorbtn1);
            this.Controls.Add(this.MRdoorbtn2);
            this.Controls.Add(this.MRbthrmlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MRcptrlbl);
            this.Controls.Add(this.MRcompBtn);
            this.Controls.Add(this.MRClsInvbtn);
            this.Controls.Add(this.MRbtnOpnInv);
            this.Controls.Add(this.GrpInvMR);
            this.Name = "MainRoom";
            this.Text = "MainRoom";
            this.Load += new System.EventHandler(this.MainRoom_Load);
            this.GrpInvMR.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpInvMR;
        private System.Windows.Forms.Button MRbtnOpnInv;
        private System.Windows.Forms.Button MRClsInvbtn;
        private System.Windows.Forms.Button MRCPbtn;
        private System.Windows.Forms.Button MRcompBtn;
        private System.Windows.Forms.Label MRcptrlbl;
        private System.Windows.Forms.Button MRcipherbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MRbthrmlbl;
        private System.Windows.Forms.Button MRdoorbtn2;
        private System.Windows.Forms.Button MRdoorbtn1;
    }
}