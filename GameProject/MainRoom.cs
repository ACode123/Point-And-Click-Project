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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
using HintsDLLproj;


namespace GameProject
{
    //this is the main room the player enters when they first start the game

    public partial class MainRoom : Form
    {
        #region Form Initialization
        public MainRoom(int s)
        {
            InitializeComponent();
            if (s == 4)
            {
                MRcipherbtn.Visible = true;
                MRdoorbtn1.Visible = false;
                MRdoorbtn2.Visible = true;

            }



        }
        public MainRoom()
        {
            InitializeComponent();
            MRdoorbtn1.Visible = true;
            MRdoorbtn2.Visible = false;
            MessageBox.Show("You wake up from your nap and realize that there is now an old computer on the desk in the room and a phone in your pocket...strange");

        } 
        #endregion

        private void MainRoom_Load(object sender, EventArgs e)
        {
            
            

        }
       

        #region open and close inventory button logic
        private void MRbtnOpnInv_Click(object sender, EventArgs e)
        {
            MRbtnOpnInv.Visible = false;
            GrpInvMR.Visible = true;
            MRClsInvbtn.Visible = true;
        }

        private void MRClsInvbtn_Click(object sender, EventArgs e)
        {
            GrpInvMR.Visible = false;
            MRClsInvbtn.Visible = false;
            MRbtnOpnInv.Visible = true;
        } 
        #endregion

        private void MRCPbtn_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            phone.Show();
            MessageBox.Show("You pull the phone out of your pocket and power it on" +
                " of course theres no service all that shows up when you unlock it is a plain white screen" +
                " with two links.");
        }

        #region Computer interaction
        private void MRcompBtn_MouseEnter(object sender, EventArgs e)
        {
            MRcptrlbl.Show();
        }

        private void MRcompBtn_MouseLeave(object sender, EventArgs e)
        {
            MRcptrlbl.Hide();
        }

        private void MRcompBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Assignments\MSSA\Point-And-Click-Project\ComputerScreen\bin\Debug\ComputerScreen.exe");
        }

        #endregion



        private void MRcipherbtn_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Files\binaryProjectt.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Hints h = (Hints)bf.Deserialize(stream);
            MessageBox.Show($"{h.hint}");
            stream.Close();
            


        }

        #region Bathroom button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MRbthrmlbl.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MRbthrmlbl.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bathroom br = new Bathroom();
            this.Hide();
            br.Show();
        }
        #endregion

        #region door button
        private void MRdoorbtn1_Click(object sender, EventArgs e)
        {
            Door door = new Door(3);
            this.Hide();
            door.Show();
        }

        private void MRdoorbtn2_Click(object sender, EventArgs e)
        {
            Door door = new Door();
            this.Hide();
            door.Show();
        } 
        #endregion
    }
}
 