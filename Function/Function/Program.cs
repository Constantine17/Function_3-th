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
            //Function y = new Function("6");
            sin sinx = new sin(x);
            cos cosx = new cos(x);
            tan tanx = new tan(x);
            ctan ctanx = new ctan(x);
            exp expx = new exp(x);
            add addxy = new add(sinx, tanx);

            Console.WriteLine(sinx.ToStr());
            Console.WriteLine(sinx.ToCulc());
            Console.WriteLine(sinx.DiffStr());
            Console.WriteLine(sinx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(cosx.ToStr());
            Console.WriteLine(cosx.ToCulc());
            Console.WriteLine(cosx.DiffStr());
            Console.WriteLine(cosx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(tanx.ToStr());
            Console.WriteLine(tanx.ToCulc());
            Console.WriteLine(tanx.DiffStr());
            Console.WriteLine(tanx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(ctanx.ToStr());
            Console.WriteLine(ctanx.ToCulc());
            Console.WriteLine(ctanx.DiffStr());
            Console.WriteLine(ctanx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(ctanx.ToStr());
            Console.WriteLine(ctanx.ToCulc());
            Console.WriteLine(ctanx.DiffStr());
            Console.WriteLine(ctanx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(expx.ToStr());
            Console.WriteLine(expx.ToCulc());
            Console.WriteLine(expx.DiffStr());
            Console.WriteLine(expx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(addxy.ToStr());
            Console.WriteLine(addxy.ToCulc());
            Console.WriteLine(addxy.DiffStr());
            Console.WriteLine(addxy.DiffCulc());

            Console.ReadKey();

        }
    }
}
