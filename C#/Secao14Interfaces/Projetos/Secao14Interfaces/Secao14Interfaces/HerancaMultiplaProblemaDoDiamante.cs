﻿using Secao14Interfaces.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14Interfaces
{
    class HerancaMultiplaProblemaDoDiamante
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My e-mail");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };

            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());


        }
    }
}

