using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    internal class Program
    {
        class money
        {
             public int  ru;
            public double  rucent;

            public money (  int r, double ruc)
            {
                
                this.ru = r;
             
                this.rucent = ruc;
            }
            public int rub
            {
                get => rub; set
                {
                   _= value;
                }
            }
            public int kopeechka { get=>kopeechka ; set => _ = value; }

        }
        class  Product : money
        {
            public int cash;
             
            public Product(int cash) : base(0,0)
            {
                this.cash = cash;
            }

            public override string ToString()
            => $"{ru},{rucent:00}";


        }

        static void Main(string[] args)
        {
        }
    }
}
