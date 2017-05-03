using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // test symbols

namespace Function
{
    /// parent class /// {
    class Function
    {
        public double Arg { get; set; }
        public string Str { get; set; }

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
            if (Regex.IsMatch(str, @"\D") == false || Regex.IsMatch(str, @"[,]")) Arg = Convert.ToDouble(str);
            else Arg = 0; ;
        }
        /// // Constructors }

    }
    /// parent class /// }

    /// SIN /// {
    class sin : Function
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
            return Math.Sin(x.Arg);
        }
        public string ToStr()
        {
            return "sin("+ x.Str + ")";
        }
        public double DiffCulc()
        {
            return Math.Cos(x.Arg);
        }
        public string DiffStr()
        {
            return "cos(" + x.Str + ")";
        }
    }
    /// SIN /// }
}
