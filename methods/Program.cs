using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNumber(20);


            
        }

        public  void EvenNumber(int x)
        {
            int Num = 0;
            while (Num <= x)
            {
                Console.WriteLine(Num);
                Num += 2;
            }
            Console.ReadLine();
        }
    }
}
