namespace GameProject
{
    partial class TutorialForm
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
            this.tutorialMMbtn = new System.Windows.Forms.Button();
            this.TutTxtbox1 = new System.Windows.Forms.RichTextBox();
            this.tutbtn1 = new System.Windows.Forms.Button();
            this.tutlbl1 = new System.Windows.Forms.Label();
            this.TUTGRPBOX = new System.Windows.Forms.GroupBox();
            this.tutLighterBtn = new System.Windows.Forms.Button();
            this.tutCellbtn = new System.Windows.Forms.Button();
            this.tutOpenbtn = new System.Windows.Forms.Button();
            this.tutClosebtn = new System.Windows.Forms.Button();
            this.TUTGRPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutorialMMbtn
            // 
            this.tutorialMMbtn.Location = new System.Drawing.Point(8, 8);
            this.tutorialMMbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutorialMMbtn.Name = "tutorialMMbtn";
            this.tutorialMMbtn.Size = new System.Drawing.Size(78, 29);
            this.tutorialMMbtn.TabIndex = 0;
            this.tutorialMMbtn.Text = "Main Menu";
            this.tutorialMMbtn.UseVisualStyleBackColor = true;
            this.tutorialMMbtn.Click += new System.EventHandler(this.tutorialMMbtn_Click);
            // 
            // TutTxtbox1
            // 
            this.TutTxtbox1.Location = new System.Drawing.Point(154, 64);
            this.TutTxtbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TutTxtbox1.Name = "TutTxtbox1";
            this.TutTxtbox1.ReadOnly = true;
            this.TutTxtbox1.Size = new System.Drawing.Size(262, 31);
            this.TutTxtbox1.TabIndex = 2;
            this.TutTxtbox1.Text = "This is a brief tutorial to demonstrate how to play my game. Press on the continu" +
    "e button to proceed.";
            // 
            // tutbtn1
            // 
            this.tutbtn1.Location = new System.Drawing.Point(224, 98);
            this.tutbtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutbtn1.Name = "tutbtn1";
            this.tutbtn1.Size = new System.Drawing.Size(85, 34);
            this.tutbtn1.TabIndex = 3;
            this.tutbtn1.Text = "CONTINUE";
            this.tutbtn1.UseVisualStyleBackColor = true;
            this.tutbtn1.Click += new System.EventHandler(this.tutbtn1_Click);
            // 
            // tutlbl1
            // 
            this.tutlbl1.AutoSize = true;
            this.tutlbl1.Location = new System.Drawing.Point(86, 141);
            this.tutlbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tutlbl1.Name = "tutlbl1";
            this.tutlbl1.Size = new System.Drawing.Size(430, 26);
            this.tutlbl1.TabIndex = 4;
            this.tutlbl1.Text = "This is a text and click based game. Most actions will be performed with button p" +
    "resses. \r\nIn this game you will have an inventory which can be open and closed w" +
    "ith a button press";
            this.tutlbl1.Visible = false;
            // 
            // TUTGRPBOX
            // 
            this.TUTGRPBOX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TUTGRPBOX.Controls.Add(this.tutLighterBtn);
            this.TUTGRPBOX.Controls.Add(this.tutCellbtn);
            this.TUTGRPBOX.Location = new System.Drawing.Point(17, 214);
            this.TUTGRPBOX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TUTGRPBOX.Name = "TUTGRPBOX";
            this.TUTGRPBOX.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TUTGRPBOX.Size = new System.Drawing.Size(195, 105);
            this.TUTGRPBOX.TabIndex = 5;
            this.TUTGRPBOX.TabStop = false;
            this.TUTGRPBOX.Text = "INVENTORY";
            this.TUTGRPBOX.Visible = false;
            // 
            // tutLighterBtn
            // 
            this.tutLighterBtn.Location = new System.Drawing.Point(107, 50);
            this.tutLighterBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutLighterBtn.Name = "tutLighterBtn";
            this.tutLighterBtn.Size = new System.Drawing.Size(50, 21);
            this.tutLighterBtn.TabIndex = 8;
            this.tutLighterBtn.Text = "Lighter";
            this.tutLighterBtn.UseVisualStyleBackColor = true;
            this.tutLighterBtn.Click += new System.EventHandler(this.tutLighterBtn_Click);
            // 
            // tutCellbtn
            // 
            this.tutCellbtn.Location = new System.Drawing.Point(4, 47);
            this.tutCellbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutCellbtn.Name = "tutCellbtn";
            this.tutCellbtn.Size = new System.Drawing.Size(69, 25);
            this.tutCellbtn.TabIndex = 7;
            this.tutCellbtn.Text = "Cell Phone";
            this.tutCellbtn.UseVisualStyleBackColor = true;
            this.tutCellbtn.Click += new System.EventHandler(this.tutCellbtn_Click);
            // 
            // tutOpenbtn
            // 
            this.tutOpenbtn.Location = new System.Drawing.Point(433, 198);
            this.tutOpenbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutOpenbtn.Name = "tutOpenbtn";
            this.tutOpenbtn.Size = new System.Drawing.Size(99, 25);
            this.tutOpenbtn.TabIndex = 0;
            this.tutOpenbtn.Text = "Open Inventory";
            this.tutOpenbtn.UseVisualStyleBackColor = true;
            this.tutOpenbtn.Visible = false;
            this.tutOpenbtn.Click += new System.EventHandler(this.tutOpenbtn_Click);
            // 
            // tutClosebtn
            // 
            this.tutClosebtn.Location = new System.Drawing.Point(433, 227);
            this.tutClosebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutClosebtn.Name = "tutClosebtn";
            this.tutClosebtn.Size = new System.Drawing.Size(99, 25);
            this.tutClosebtn.TabIndex = 6;
            this.tutClosebtn.Text = "Close Inventory";
            this.tutClosebtn.UseVisualStyleBackColor = true;
            this.tutClosebtn.Visible = false;
            this.tutClosebtn.Click += new System.EventHandler(this.tutClosebtn_Click);
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 348);
            this.Controls.Add(this.tutClosebtn);
            this.Controls.Add(this.tutOpenbtn);
            this.Controls.Add(this.TUTGRPBOX);
            this.Controls.Add(this.tutlbl1);
            this.Controls.Add(this.tutbtn1);
            this.Controls.Add(this.TutTxtbox1);
            this.Controls.Add(this.tutorialMMbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TutorialForm";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TUTGRPBOX.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tutorialMMbtn;
        private System.Windows.Forms.RichTextBox TutTxtbox1;
        private System.Windows.Forms.Button tutbtn1;
        private System.Windows.Forms.Label tutlbl1;
        private System.Windows.Forms.GroupBox TUTGRPBOX;
        private System.Windows.Forms.Button tutOpenbtn;
        private System.Windows.Forms.Button tutClosebtn;
        private System.Windows.Forms.Button tutLighterBtn;
        private System.Windows.Forms.Button tutCellbtn;
    }
}