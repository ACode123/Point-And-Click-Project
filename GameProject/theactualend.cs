using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameProject
{
    //last form of the game...its a surprise 
    public partial class theactualend : Form
    {
        public theactualend()
        {
            InitializeComponent();
        }

        private void theactualend_Load(object sender, EventArgs e)
        {
            //plays music once the form is loaded 
            SoundPlayer sndplayer = new SoundPlayer(Properties.Resources.Rick_Astley___Never_Gonna_Give_You_Up__Official_Music_Video___320_kbps_);
            sndplayer.Play();
        }
    }
}
