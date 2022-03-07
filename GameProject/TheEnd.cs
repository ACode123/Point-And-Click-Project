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
    public partial class TheEnd : Form
    {
        //this form is the end of the game 
        public TheEnd()
        {
            
            InitializeComponent();
        }

        private void Contbtn_Click(object sender, EventArgs e)
        {
            
            theactualend end= new theactualend();
            this.Hide();
            end.Show();
            
           
            
        }

        private void TheEnd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
