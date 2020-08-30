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

            EvenNumber(10);

            Program p = new Program();
            int result = p.Add(20,30);
            Console.WriteLine("Result is = {0}",result);
            Console.ReadLine();


        }

        public static void EvenNumber(int x)
        {
            int Num = 0;
            while (Num <= x)
            {
                Console.WriteLine(Num);
                Num += 2;
            }
            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            return a + b;

        }
        
    }
}
