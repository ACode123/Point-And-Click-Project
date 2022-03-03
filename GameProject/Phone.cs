using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameProject
{
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }

        private void Phone_Load(object sender, EventArgs e)
        {

        }

        private void PhoneLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Jacob%27s_Ladder_(1990_film)");
        }

        private void PhoneLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Oldboy_(2003_film)");
        }
    }
}
