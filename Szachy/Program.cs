﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachy.Figury;

namespace Szachy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p, Figura.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
        }
    }
}
