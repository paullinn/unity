using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy.Figury
{
    class Szachownica
    {
        private static Szachownica szachow = new Szachownica();
        private string[,] plansza;

        private Szachownica()
        {
            plansza = new string[8, 8];
        }
        public static Szachownica Instancja
        {
            get
            {
                return szachow;
            }
        }

        public string this[char x, int y]
        {
            get
            {
                return plansza[x - 65, y];
            }
            set
            {
                plansza[x - 65, y] = value;
            }
        }
       public int ileFigur()
        {
            return Figury.Count;
        }
    }
}
