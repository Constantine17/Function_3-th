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
            constant constan = new constant(x);
            sin sinx = new sin(x);
            cos cosx = new cos(x);
            tan tanx = new tan(x);
            ctan ctanx = new ctan(x);
            exp expx = new exp(x);
            add addx = new add(sinx, tanx);
            sub subx = new sub(sinx, cosx);
            mul mulx = new mul(tanx, ctanx);
            div divx = new div(ctanx, tanx);
            pow powx = new pow(ctanx, constan);


          //  Console.WriteLine();
            Console.WriteLine(constan.ToStr());
            Console.WriteLine(constan.ToCulc());
            Console.WriteLine(constan.DiffStr());
            Console.WriteLine(constan.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(sinx.ToStr());
            Console.WriteLine(sinx.ToCulc());
            Console.WriteLine(sinx.DiffStr());
            Console.WriteLine(sinx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(powx.ToStr());
            Console.WriteLine(powx.ToCulc());
            Console.WriteLine(powx.DiffStr());
            Console.WriteLine(powx.DiffCulc());

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
            Console.WriteLine(expx.ToStr());
            Console.WriteLine(expx.ToCulc());
            Console.WriteLine(expx.DiffStr());
            Console.WriteLine(expx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(addx.ToStr());
            Console.WriteLine(addx.ToCulc());
            Console.WriteLine(addx.DiffStr());
            Console.WriteLine(addx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(subx.ToStr());
            Console.WriteLine(subx.ToCulc());
            Console.WriteLine(subx.DiffStr());
            Console.WriteLine(subx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(mulx.ToStr());
            Console.WriteLine(mulx.ToCulc());
            Console.WriteLine(mulx.DiffStr());
            Console.WriteLine(mulx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(divx.ToStr());
            Console.WriteLine(divx.ToCulc());
            Console.WriteLine(divx.DiffStr());
            Console.WriteLine(divx.DiffCulc());

            Console.WriteLine();
            Console.WriteLine(powx.ToStr());
            Console.WriteLine(powx.ToCulc());
            Console.WriteLine(powx.DiffStr());
            Console.WriteLine(powx.DiffCulc());

            Console.ReadKey();

        }
    }
}
