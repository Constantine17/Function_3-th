using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            double arg = 0;

            //Function fun;
            Function x = new Function("5");
            sin sinx = new sin(x);

            Console.WriteLine(sinx.ToStr());
            Console.WriteLine(sinx.ToCulc());
            Console.WriteLine(sinx.DiffStr());
            Console.WriteLine(sinx.DiffCulc());
            Console.ReadKey();

        }
    }
}
