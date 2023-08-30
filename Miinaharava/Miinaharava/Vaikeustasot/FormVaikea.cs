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
    public partial class FormVaikea : Form
    {
        int kokoX = 30;
        int kokoY = 16;

        int korkeinX = 30;
        int korkeinY = 16;


        int aika = 0;


        int MINES = 99;
        int lippumaara = 99;        
        int oikeatliput = 99;       

        public Point MouseLocation;

        MiinaNappi[,] engine;

        Random rnd = new Random();


        private void button_Clicked(object sender, EventArgs e)
        {

            MiinaNappi m = (MiinaNappi)sender;
            if (m.GetMiina())
            {

                m.Rajahti();

                RajaytaLoputMiinat(m);           //etsii kaikki miinat ja laittaa niiden kuvaksi Mine

                timer1.Stop();
                string message = "Hävisit";
                string title = "BOOOOOOOM!!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    FormVaikea FormVaikea = new FormVaikea();
                    FormVaikea.Show();
                    FormVaikea.StartPosition = FormStartPosition.CenterScreen;
                    this.Dispose(false);

                }       //Aloittaa pelin uudestaan

            }

            if (!m.GetMiina())
            {

                m.AvaaNappi(engine);

            }

        }

        private void RajaytaLoputMiinat(MiinaNappi m)
        {
            for (int y = 0; y < kokoY; y++)
            {
                for (int x = 0; x < kokoX; x++)
                {
                    MiinaNappi nappi = engine[x, y];
                    if (nappi.GetMiina() && nappi != m)
                    {
                        nappi.NaytaMiinat();
                    }

                }
            }
        }                            //-------nayttaa muut miina napit kun yhtä miinaa painaa

        private void Mine_MouseDown(object sender, MouseEventArgs e)
        {
            MiinaNappi klikattu = (MiinaNappi)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (!klikattu.Lippu)
                {
                    klikattu.BackgroundImage = Miinaharava.Properties.Resources.Flag;
                    klikattu.BackgroundImageLayout = ImageLayout.Stretch;
                    lippumaara--;
                    klikattu.Lippu = true;
                    if (klikattu.Lippu == klikattu.GetMiina())
                    {
                        oikeatliput--;
                        PeliVoittoHelppo();
                    }

                }
            }       //---Laittaa lipun kuvan

            if (e.Button == MouseButtons.Left)
            {
                if (klikattu.Lippu)
                {
                    lippumaara++;
                    klikattu.Lippu = false;
                    PeliVoittoHelppo();
                }
            }       //---Poistaa lipun kuvan

            Liput.Text = lippumaara.ToString();

        }             //-------liput pois/takas

        private void PeliVoittoHelppo()
        {
            if (oikeatliput == 0 && !(oikeatliput < 0) && lippumaara == 0)
            {
                string message = "Voitit pelin! Haluatko pelata uudestaan";
                string title = "Voitit";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    FormVaikea FormVaikea = new FormVaikea();
                    FormVaikea.Show();
                    FormVaikea.StartPosition = FormStartPosition.CenterScreen;
                    this.Dispose(false);

                }

                else
                {
                    this.Close();
                    FormMain FormMain = new FormMain();
                    FormMain.Show();
                }
            }
        }                                          //-------Jos painat Yes pelaat uudestaan jos painat No menet takaisin päävalikkoon

        void LuoNapit(int maara)
        {
            for (int y = 0; y < kokoY; y++)
            {
                for (int x = 0; x < kokoX; x++)
                {
                    MiinaNappi m = new MiinaNappi(x, y);
                    m.Click += new System.EventHandler(this.button_Clicked);
                    m.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mine_MouseDown);
                    m.Text = "";
                    m.Name = "miina x:" + x + ",y:" + y;
                    m.Size = new Size(50, 50);
                    m.Location = new Point();
                    m.BackgroundImage = Miinaharava.Properties.Resources.Cover;
                    m.BackgroundImageLayout = ImageLayout.Stretch;
                    m.FlatStyle = FlatStyle.Popup;
                    engine[x, y] = m;
                    tableLayoutPanel1.Controls.Add(m);

                }

            }


        }                                                 //-------kertoo mitä napeissa on

        private void KirjoitaCheatBoxiin()
        {
            for (int y = 0; y < kokoY; y++)
            {
                for (int x = 0; x < kokoX; x++)
                {
                    MiinaNappi m = engine[x, y];

                    if (m.GetMiina())
                    {
                        richTextBox1.Text += "\r" + "button x:" + x + " y:" + y + "\r" + " pommi: " + m.GetMiina() + "\r" + " lkm: " + m.GetLukumaara() + "\r";
                    }

                }

            }
        }                                       //-------kertoo mitä tíedot kirjoitetaan cheat boxiin

        private void AsetaMiinat()
        {
            for (int i = 0; i < MINES; i++)
            {

                bool add = false;
                while (add == false)
                {
                    int randomx = rnd.Next(korkeinX);
                    int randomy = rnd.Next(korkeinY);
                    MiinaNappi m = engine[randomx, randomy];

                    if (!m.GetMiina())
                    {
                        m.SetMiina(true);
                        add = true;

                        int startx = randomx - 1;
                        int starty = randomy - 1;
                        int endx = randomx + 1;
                        int endy = randomy + 1;
                        if (startx < 0)
                        {
                            startx = 0;
                        }
                        if (starty < 0)
                        {
                            starty = 0;
                        }
                        if (endx > kokoX - 1)
                        {
                            endx = kokoX - 1;
                        }
                        if (endy > kokoY - 1)
                        {
                            endy = kokoY - 1;
                        }

                        for (int y = starty; y <= endy; y++)
                        {
                            for (int x = startx; x <= endx; x++)
                            {
                                MiinaNappi nappi = engine[x, y];
                                if (!nappi.GetMiina())
                                {
                                    int lkm = nappi.GetLukumaara();
                                    nappi.SetLukumaara((lkm + 1));
                                }
                            }
                        }
                    }       //------kun miina on lähellä miina plussaa viereisiin ruutuihin 1

                }

            }
        }



        public FormVaikea()
        {
            InitializeComponent();

            engine = new MiinaNappi[kokoX, kokoY];

            LuoNapit(kokoX * kokoY);


            AsetaMiinat();



            richTextBox1.Text += "Miinojen kohdat" + "\r";

            KirjoitaCheatBoxiin();




        }

        







        //-----------------------PANEELI & PÄÄVALIKON ASETUKSET----------------

        private void MiniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormVaikea FormVaikea = new FormVaikea();
            FormVaikea.Show();
            FormVaikea.StartPosition = FormStartPosition.CenterScreen;
            this.Dispose(false);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            string message = "Haluatko Lopettaa pelin vaikeustaso Vaikea";
            string title = "Vaikea peli";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                var FormMain = new FormMain();
                FormMain.Show();
            }
            else
            {
                return;
            }
        }

        private void IconPictureBox_Click(object sender, EventArgs e)
        {
            string message = "Haluatko Vastaukset?";
            string title = "CheatMenu";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Size = new Size(1471, 561);
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RatkaisunAika.Text = aika.ToString();
            aika++;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);

        }
    }
}
