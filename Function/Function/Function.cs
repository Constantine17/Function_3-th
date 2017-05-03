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
    /// 

    /// COS /// {
    class cos : Function
    {
        Function x;

        /// // Constructors {
        public cos(Function fun)
        {
            x = fun;
        }
        public cos(double arg)
        {
            x = new Function(arg);
        }
        public cos(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }

        public double ToCulc()
        {
            return Math.Cos(x.Arg);
        }
        public string ToStr()
        {
            return "cos(" + x.Str + ")";
        }
        public double DiffCulc()
        {
            return -Math.Sin(x.Arg);
        }
        public string DiffStr()
        {
            return "-sin(" + x.Str + ")";
        }
    }
    /// COS /// }
    /// 


    /// TAN /// {
    class tan : Function
    {
        Function x;

        /// // Constructors {
        public tan(Function fun)
        {
            x = fun;
        }
        public tan(double arg)
        {
            x = new Function(arg);
        }
        public tan(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }

        public double ToCulc()
        {
            return Math.Tan(x.Arg);
        }
        public string ToStr()
        {
            return "tan(" + x.Str + ")";
        }
        public double DiffCulc()
        {
            return 1/(Math.Pow(Math.Cos(x.Arg),2));
        }
        public string DiffStr()
        {
            return "1/cos("+x.Str+")^2";
        }
    }
    /// TAN /// }
}
