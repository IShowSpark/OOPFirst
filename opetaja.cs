using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class opetaja : inimene
    {
        string aine;
        public opetaja() { }
        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }
        public override void i_am()
        {
            Console.WriteLine("Ma olen õpetaja!");
        }
    }
}
