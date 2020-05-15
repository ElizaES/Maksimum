using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Maximum
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
           
            Console.WriteLine("Podaj pierwszą wartość");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą wartość");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią wartość");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj czwartą wartość");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wartosc maksymalna wynosi " + max_number(max_number(a,b),max_number(c,d)));
            Console.ReadKey();
        }

       
        public static int max_number(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}
