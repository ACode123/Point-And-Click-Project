using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
        }

        private void MRbtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainRoom mr = new MainRoom(1);
            mr.Show();
        }

        private void MRbtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainRoom mainRoom  = new MainRoom(4);
            mainRoom.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MRbtn1.Visible = false;
            MRbtn2.Visible = true;
            MessageBox.Show("The toilet tank cover looked off center so you lifted it up and taped on the bottom is a piece of paper with a written out key" +
                " you should be able to decipher the code now");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            tankcvrlbl.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            tankcvrlbl.Visible = false;
        }
    }
}
