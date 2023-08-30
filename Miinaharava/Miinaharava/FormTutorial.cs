using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Miinaharava.Vaikeustasot
{
    public partial class FormTutorial : Form
    {
        

        public FormTutorial()
        {
            
            InitializeComponent();
        }

        int Kohta = 0;





        private void EteenButton_Click(object sender, EventArgs e)
        {
            Kohta++;

            ScenaarioNumText.Text = Kohta.ToString();


            if (Kohta == 1)
            {
                ScenarioPicture.Image = Miinaharava.Properties.Resources.Scenaario_1;
                TutorialText.Text = "Jokaiset napit valtaavat 3x3 napin alueen \r" +
                                    "[1][1][1]\r" +
                                    "[1][X][1]\r" +
                                    "[1][1][1]\r";

            }
            if (Kohta == 2)
            {
                ScenarioPicture.Image = Miinaharava.Properties.Resources.Scenaario_2;
                TutorialText.Text = "Numero voi olla mikä vain 1-8 välilla riippuen monta miinaa on napin vieressä";
            }
            if (Kohta == 3)
            {
                ScenarioPicture.Image = Miinaharava.Properties.Resources.Scenaario_3;
                TutorialText.Text = "Viivat merkitsevät mihin numerot ylttävät";
            }


        }

        private void TaakseButton_Click(object sender, EventArgs e)
        {
            if(Kohta < 0)
            {
                Kohta++;
                
            }

            else
            {
                Kohta--;
                
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
