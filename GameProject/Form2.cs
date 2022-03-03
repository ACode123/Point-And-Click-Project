using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this is just a short tutorial that describes how the game works to the player
namespace GameProject
{
    public partial class TutorialForm : Form
    {
        
        
        public TutorialForm()
        {
           
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
           

            
        }

        private void tutorialMMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }




        #region Buttons
        private void tutbtn1_Click(object sender, EventArgs e)
        {
            TutTxtbox1.Hide();
            tutbtn1.Hide();
            tutOpenbtn.Visible = true;
            tutlbl1.Visible = true;
        }

        private void tutOpenbtn_Click(object sender, EventArgs e)
        {
            tutOpenbtn.Hide();
            tutClosebtn.Visible = true;
            TUTGRPBOX.Visible = true;
            MessageBox.Show("Not all items in your inventory can be used whenever you want. A message will display if it's" +
                "currently unusable.");
        }

        private void tutClosebtn_Click(object sender, EventArgs e)
        {

            tutClosebtn.Hide();
            TUTGRPBOX.Visible = false;
            tutlbl1.Hide();
            tutOpenbtn.Show();
            MessageBox.Show("That concludes the tutorial. Please go back to the " +
                "main menu to play the game");
        }

        #endregion
        private void tutCellbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I can't use that right now");
        }

        private void tutLighterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You flick the lighter and flame emanates from it");
        }
    }
}
