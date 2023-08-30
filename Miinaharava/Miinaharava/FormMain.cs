using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miinaharava
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public Point MouseLocation;





        //------------------------------------------VAIKEUS TASOT-----------------------------------------------------

        private void VaikeusHelppo_Click(object sender, EventArgs e)
        {
            string message = "Haluatko aloittaa pelin vaikeustaso helppo";
            string title = "Helppo peli";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                var FormHelppo = new FormHelppo();
                FormHelppo.Show();

            }
            else
            {
                return;  
            }
        }

        private void VaikeusKeski_Click(object sender, EventArgs e)
        {
            string message = "Haluatko aloittaa pelin vaikeustaso Keskivaikea";
            string title = "Keskivaikea peli";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                var FormKeski = new FormKeski();
                FormKeski.Show();
            }
            else
            {
                return;
            }
        }

        private void VaikeusVaikea_Click(object sender, EventArgs e)
        {
            string message = "Haluatko aloittaa pelin vaikeustaso vaikea";
            string title = "Vaikea peli";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                var FormVaikea = new FormVaikea();
                FormVaikea.Show();
            }
            else
            {
                return;  
            }
        }

        private void CustomVaikeus_Click(object sender, EventArgs e)
        {
            string message = "Ei Valmis";
            string title = "Custom vaikeus taso";
            MessageBox.Show(message, title);
        }


        //-----------------Vaikeustaso Info-------------------
        private void InfoHelppo_Click(object sender, EventArgs e)
        {
            string message = "9 x 9 ruudukko \r" +
                             "10 miinaa";
            string title = "Helppo vaikeus taso";
            MessageBox.Show(message, title);
        }

        private void InfoKeski_Click(object sender, EventArgs e)
        {
            string message = "16 x 16 ruudukko \r" +
                             "40 miinaa";
            string title = "keski vaikeus taso";
            MessageBox.Show(message, title);
        }

        private void InfoVaikea_Click(object sender, EventArgs e)
        {
            string message = "30 x 16 ruudukko \r" +
                             "99 miinaa";
            string title = "Vaikea vaikeus taso";
            MessageBox.Show(message, title);
        }


        private void InfoCustom_Click(object sender, EventArgs e)
        {
            string message = "Max 99 x 99 Ruudukko \r" +
                             "Max 2000 miinaa";
            string title = "Custom vaikeus taso";
            MessageBox.Show(message, title);
        }





        //-----------------saanno/tutoriaali & info-------------



        private void Saannot_info_Click(object sender, EventArgs e)
        {
            string message = "Kertoo pelistä perus tietoa";
            string title = "Säännöt";
            MessageBox.Show(message, title);
        }

        private void TutoriaaliButton_Click(object sender, EventArgs e)
        {
            string message = "Haluatko avata tutoriaalin";
            string title = "Tutorial";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var FormTutorial = new Vaikeustasot.FormTutorial();
                FormTutorial.Show();

            }
            else
            {
                return;
            }
        }

        private void SaannotButton_Click(object sender, EventArgs e)
        {

        }

        private void Tutoriaali_info_Click(object sender, EventArgs e)
        {
            string message = "antaa scenaarioita että ymmärrät pelin";
            string title = "Tutoriaali";
            MessageBox.Show(message, title);
        }

        //--------------------------------------------ASETUKSET-------------------------------------------------------


        private void tekijäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Ilari Holopainen";
            string title = "Tekijä";
            MessageBox.Show(message, title);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MiniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }        //Custom DragBar

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }

        }        //Custom DragBar


    }
}
