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
    public partial class Slide1 : Form
    {
        public Slide1()
        {
            InitializeComponent();
        }

        private void Slide1Ctnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainRoom mainRoom = new MainRoom();
            mainRoom.Show();
            
        }
    }
}
