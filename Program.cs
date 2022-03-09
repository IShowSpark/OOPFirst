
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            inimene[] inim = new inimene[4];

            inim[0] = new opetaja();
            inim[0].i_am();
            inim[1]= new opetaja();
            inim[1].i_am();
            inim[2]= new opetaja();
            inim[2].i_am();
            inim[3]= new opetaja();
            inim[3].i_am();





            Opilane o = new Opilane("Kati", "TARpv21",2);
            o.Hinne = 5;
            o.Information();

            Console.ReadLine();
        }
    }
}