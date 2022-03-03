using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this form represents the exit door to escape from the room 
namespace GameProject
{
    public partial class Door : Form
    {
        int doorcounter = 0;
        bool flag = false;
        #region Door initializations
        public Door()
        {
            MessageBox.Show("A small compartment has opened up on the door to reveal a combo lock. Perhaps the code you have will finally unlock this cursed door");
            InitializeComponent();
            combotxt.Visible = true;
            submitbtn.Visible = true;

        }
        public Door(int a)
        {
            InitializeComponent();
            MRbtn2.Visible = false;
            DoorMRbtn1.Visible = true;
            combotxt.Visible = false;

        } 
        #endregion

        private void Door_Load(object sender, EventArgs e)
        {

        }

        #region Buttons to go back to main room
        private void DoorMRbtn1_Click(object sender, EventArgs e)
        {
            MainRoom MR = new MainRoom(2);
            this.Hide();
            MR.Show();
        }

        private void MRbtn2_Click(object sender, EventArgs e)
        {
            MainRoom MR = new MainRoom(4);
            this.Hide();
            MR.Show();
        } 
        #endregion

        private void combotxt_Validating(object sender, CancelEventArgs e)
        {
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(combotxt.Text=="YNSE")
            {
                MessageBox.Show("You enter the code and press the button and the lock disengages allowing you to turn the fdoor handle");
                submitbtn.Visible = false;
                combotxt.Visible=false;
                OpnDoorbtn.Visible = true;
            }
        }

        #region Opening the door 
        private void OpnDoorbtn_Click(object sender, EventArgs e)
        {
            TheEnd theEnd = new TheEnd();
            if (doorcounter == 0 && flag == false)
            {
                doorcounter += 1;
                flag = true;
                MessageBox.Show("You try pushing the door open but its rusted shut. Try again");
                return;

            }
            if (flag == true && doorcounter == 1)
            {
                doorcounter += 1;
                MessageBox.Show("you use all your weight and strength to push the door and it comes loose but still isnt open all the way");
                return;
            }
            if (doorcounter == 2)
            {
                MessageBox.Show("You give it one more big push and the door swings open, as it swings open you are enveloped in a bright white light");
                this.Hide();
                theEnd.Show();

            } 
            #endregion
        }
    }
}
