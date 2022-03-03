using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this is the main menu of the game where the player can enter the tutorial or start the game
namespace GameProject
{
    public partial class MainMenu : Form
    {
           
        public MainMenu()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorialForm tutorial = new TutorialForm();
           
            tutorial.Show();
            
        }




      

        private void EntGmbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Slide1 slide1 = new Slide1();
            slide1.Show();
        }
    }
}
