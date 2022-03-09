using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public abstract class inimene
    {
        public abstract void i_am();


        //ПОЛЯ
        string eesnimi;
        int vanus;
        int kasv;
        string stat;
        Emakeel emakeel;
        Sugu sugu;
        int palk;







        //КОНСТРУКТОРА
        public inimene() { }
        public inimene(string Eesnimi, Emakeel emakeel)
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
        }

        public inimene(string Eesnimi)
        {
            eesnimi = Eesnimi;
        }







        // СВОЙСТВА
        public int Palk
        {
            set { palk = value; }
            get { return palk; }
        }

        public Sugu Sugu
        {
            get { return sugu; }
        }

        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
        }
        public int Vanus
        {
            set
            { vanus = value; }
            get { return vanus; }
        }

        public int Kasv
        {
            set
            {
                kasv = value;
                if (kasv < 160)
                {
                    stat = "Väike";
                }
                else if (kasv < 185)
                {
                    stat = "Keskmine";
                }
                else if (kasv < 210)
                {
                    stat = "Pikk";
                }
            }
            get { return kasv; }
        }

        public string Staatus
        {
            get
            {
                var staatus = "";
                if (vanus < 7)
                {
                    staatus = "Väike laps";
                }
                else if (vanus < 17)
                {
                    staatus = "Kooli laps";
                }
                else if (vanus < 65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "Senior";
                }
                return staatus;
            }
        }

        //МЕТОДЫ
        public void Tervitame()
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0}. Olen {1} aastat vana. Minu staatus on {2}", eesnimi, vanus, Staatus);
        }

        public void Pool()
        {
            Console.WriteLine("Tervist!");
            Console.WriteLine("Minu kasv on {0} ja minu sugu on {1}", stat, sugu);
        }

        public double Tulumaks()
        {
            double tulu = 0;
            tulu = palk * 0.2;
            return tulu;
        }
    }
}