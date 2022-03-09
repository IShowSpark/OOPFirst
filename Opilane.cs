using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    class Opilane : inimene
    {
        string ruhm;
        int kurss;
        double hinne;
        bool toetus;

        public Opilane() { }
        public Opilane(string Eesnimi, string Ruhm, int Kurss) : base(Eesnimi)
        {
            ruhm = Ruhm;
            kurss = Kurss;
        }
        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }

        public int Kurss
        {
            set { if (value >0 && value <=5) kurss = value; }
            get { return kurss; }
        }

        public double Hinne
        {
            set
            { if (value >0 && value <=5) hinne = value; }
            get { return hinne; }
        }

        public bool Toetus
        {
            get
            {
                if (hinne > 3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }

        public void Information()
        {
            string t = "";
            Console.WriteLine($"Tere! Mini nimi on {Eesnimi}");
            if (Toetus == true)
            {
                t = "Saan toetust kätte :)";
            }
            else if (Toetus == false && hinne > 0)
            {
                t ="Ei saa toetust :(";
            }
            else
            {
                t = "Andmed hinnetest puuduvad";
            }
            Console.WriteLine($"Minu keskmine hinne on {hinne}, {t}");
        }

        public override void i_am()
        {
            Console.WriteLine("Ma olen õpilane!");
        }
    }
}

     