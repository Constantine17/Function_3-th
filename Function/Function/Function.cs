using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Function
    {
        public double Arg { get; set; }
        public string Str { get; set; }
        /*
        public double diffArg;
        public string diffStr;
        */

        /// // Constructors {
        public Function()
        {
            Arg = 0;
            Str = "";
        }
        public Function(double arg)
        {
            Arg = arg;
            Str = Convert.ToString(arg);
        }
        public Function(string str)
        {
            Str = str;
            Arg = 0;
        }
        /// // Constructors }

    }

    class sin: Function
    {
        Function x;

        /// // Constructors {
        public sin(Function fun)
        {
            x = fun;
        }
        public sin(double arg)
        {
           x = new Function(arg);
        }
        public sin(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }
        
        public double ToCulc()
        {
            Arg = x.Arg;
            return Math.Sin(Arg);
        }
        public string ToStr()
        {
            Str = x.Str;
            return "sin("+Str+")";
        }
    }
}
