using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miinaharava
{
    internal class MiinaNappi : Button
    {
        
        private bool miina;
        private int lukumaara;
        private bool lippu;
        private int x, y;
        bool avattu;

        public MiinaNappi(int x, int y)
        {
            miina = false;
            lukumaara = 0;
            lippu = false;
            avattu = false;
            X = x;
            Y = y;
        }

        public bool Lippu { get => lippu; set => lippu = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public int GetLukumaara()
        {
            return lukumaara;
        }

        public void SetLukumaara(int lukumaara)
        {
            this.lukumaara = lukumaara;
        }

        public bool GetMiina()
        {
            return miina;
        }

        public void SetMiina(bool miina)
        {
            this.miina = miina;
            if(miina)
            {
                SetLukumaara(0);
            }
        }



        public void NaytaMiinat()
        {
            BackgroundImage = Miinaharava.Properties.Resources.Mine;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Rajahti()
        {
            BackgroundImage = Miinaharava.Properties.Resources.Boom;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void AvaaNappi(MiinaNappi[,] engine)
        {
            avattu = true;
            switch (GetLukumaara())
            {
                case 0:
                    BackgroundImage = Miinaharava.Properties.Resources.Empty;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 1:
                    BackgroundImage = Miinaharava.Properties.Resources.One;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    BackgroundImage = Miinaharava.Properties.Resources.Two;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    BackgroundImage = Miinaharava.Properties.Resources.Three;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    BackgroundImage = Miinaharava.Properties.Resources.Four;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    BackgroundImage = Miinaharava.Properties.Resources.Five;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 6:
                    BackgroundImage = Miinaharava.Properties.Resources.Six;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 7:
                    BackgroundImage = Miinaharava.Properties.Resources.Seven;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 8:
                    BackgroundImage = Miinaharava.Properties.Resources.Eight;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    break;

            }

            if (lukumaara == 0)
            {
                AvaaViereiset(engine);
            }
        }

        private void AvaaViereiset(MiinaNappi[,] engine)
        {
            
            for (int y = (Y-1) ; y <= (Y+1); y++)
            {
                for (int x = (X-1); x <= (X+1); x++)
                {
                    if(x>=0 && y>=0 && y<=engine.GetUpperBound(0) && x <=engine.GetUpperBound(0))
                    {
                        MiinaNappi naapuri = engine[x, y];
                        if (!naapuri.avattu && !naapuri.lippu)
                        {
                            naapuri.AvaaNappi(engine);
                        }
                    }   
                }
            }
        }
    }
}
