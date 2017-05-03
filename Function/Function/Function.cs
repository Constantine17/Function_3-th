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

        /// // empty virtual functions {
        public virtual double ToCulc()
        {
            return 0;
        }
        public virtual string ToStr()
        {
            return "";
        }
        public virtual double DiffCulc()
        {
            return 0;
        }
        public virtual string DiffStr()
        {
            return "";
        }
        /// // empty virtual functions }
    }
    /// parent class /// }

    /// constant /// {
    class constant : Function
    {
        Function x;

        /// // Constructors {
        public constant(Function fun)
        {
            x = fun;
        }
        public constant(double arg)
        {
            x = new Function(arg);
        }
        public constant(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return x.Arg;
        }
        public override string ToStr()
        {
            return x.Str;
        }
        public override double DiffCulc()
        {
            return 0;
        }
        public override string DiffStr()
        {
            return "";
        }
    }
    /// const /// }

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
        
        public override double ToCulc()
        {
            return Math.Sin(x.Arg);
        }
        public override string ToStr()
        {
            return "sin("+ x.Str + ")";
        }
        public override double DiffCulc()
        {
            return Math.Cos(x.Arg);
        }
        public override string DiffStr()
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

        public override double ToCulc()
        {
            return Math.Cos(x.Arg);
        }
        public override string ToStr()
        {
            return "cos(" + x.Str + ")";
        }
        public override double DiffCulc()
        {
            return -Math.Sin(x.Arg);
        }
        public override string DiffStr()
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

        public override double ToCulc()
        {
            return Math.Tan(x.Arg);
        }
        public override string ToStr()
        {
            return "tan(" + x.Str + ")";
        }
        public override double DiffCulc()
        {
            return 1/(Math.Pow(Math.Cos(x.Arg),2));
        }
        public override string DiffStr()
        {
            return "1/cos("+x.Str+")^2";
        }
    }
    /// TAN /// }
    /// 

    /// CTAN /// {
    class ctan : Function
    {
        Function x;

        /// // Constructors {
        public ctan(Function fun)
        {
            x = fun;
        }
        public ctan(double arg)
        {
            x = new Function(arg);
        }
        public ctan(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return 1/Math.Tan(x.Arg);
        }
        public override string ToStr()
        {
            return "ctan(" + x.Str + ")";
        }
        public override double DiffCulc()
        {
            return -1 / (Math.Pow(Math.Sin(x.Arg), 2));
        }
        public override string DiffStr()
        {
            return "-1/cos(" + x.Str + ")^2";
        }
    }
    /// CTAN /// }
    /// 
    /// EXP /// {
    class exp : Function
    {
        Function x;

        /// // Constructors {
        public exp(Function fun)
        {
            x = fun;
        }
        public exp(double arg)
        {
            x = new Function(arg);
        }
        public exp(string str)
        {
            x = new Function(str);
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return 1 / Math.Exp(x.Arg);
        }
        public override string ToStr()
        {
            return "exp(" + x.Str + ")";
        }
        public override double DiffCulc()
        {
            return 1 / Math.Exp(x.Arg); 
        }
        public override string DiffStr()
        {
            return "exp(" + x.Str + ")";
        }
    }
    /// EXP /// }
    /// 

    /// ADD /// {
    class add : Function
    {
        Function LArg;
        Function RArg;
        /// // Constructors {
        public add(Function Left, Function Right)
        {
            LArg = Left;
            RArg = Right;
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return LArg.ToCulc() + RArg.ToCulc();
        }
        public override string ToStr()
        {
            if (Regex.IsMatch(RArg.ToStr(), @"^-")) return LArg.ToStr() + RArg.ToStr(); // check of a sign sub
            return LArg.ToStr() + "+" + RArg.ToStr();
        }
        
        public override double DiffCulc()
        {
            return LArg.DiffCulc() + RArg.DiffCulc();
        }
        public override string DiffStr()
        {
            if (Regex.IsMatch(RArg.DiffStr(), @"^-")) return LArg.DiffStr() + RArg.DiffStr(); // check of a sign sub
            return LArg.DiffStr() + "+" + RArg.DiffStr();
        }
    }
    /// ADD /// }
    /// 

    /// SUB /// {
    class sub : Function
    {
        Function LArg;
        Function RArg;
        /// // Constructors {
        public sub(Function Left, Function Right)
        {
            LArg = Left;
            RArg = Right;
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return LArg.ToCulc() - RArg.ToCulc();
        }
        public override string ToStr()
        {
            if (Regex.IsMatch(RArg.ToStr(), @"^-"))
            {   string substr = RArg.ToStr();
                substr = substr.Substring(1);
                return LArg.ToStr() +"+"+ substr; } // check of a sign sub
            return LArg.ToStr() + "-" + RArg.ToStr();
        }

        public override double DiffCulc()
        {
            return LArg.DiffCulc() - RArg.DiffCulc();
        }
        public override string DiffStr()
        {
            if (Regex.IsMatch(RArg.DiffStr(), @"^-"))
            {   string substr = RArg.DiffStr();
                substr = substr.Substring(1);
                return LArg.DiffStr() + "+" + substr;} // check of a sign sub
            return LArg.DiffStr() + "-" + RArg.DiffStr();
        }
    }
    /// SUB /// }
    /// 
    /// MUL /// {
    class mul : Function
    {
        Function LArg;
        Function RArg;
        /// // Constructors {
        public mul(Function Left, Function Right)
        {
            LArg = Left;
            RArg = Right;
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return LArg.ToCulc() * RArg.ToCulc();
        }
        public override string ToStr()
        {
            if (Regex.IsMatch(RArg.ToStr(), @"^-"))
            {
                string substr = RArg.ToStr();
                substr = substr.Substring(1);
                return LArg.ToStr() + "*(" + substr+")";
            } // check of a sign sub
            return LArg.ToStr() + "*" + RArg.ToStr();
        }

        public override double DiffCulc()
        {
            return LArg.DiffCulc() * RArg.ToCulc() + RArg.DiffCulc() * LArg.ToCulc();
        }
        public override string DiffStr()
        {
            return "(" + LArg.DiffStr() + ") " + "* (" + RArg.ToStr() + ") " + "+ (" + LArg.ToStr() + ") " + "* (" + RArg.DiffStr() + ")";
        }
    }
    /// MUL /// }
    /// 

    /// DIV /// {
    class div : Function
    {
        Function LArg;
        Function RArg;
        /// // Constructors {
        public div(Function Left, Function Right)
        {
            LArg = Left;
            RArg = Right;
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return LArg.ToCulc() / RArg.ToCulc();
        }
        public override string ToStr()
        {
            if (Regex.IsMatch(RArg.ToStr(), @"^-"))
            {
                string substr = RArg.ToStr();
                substr = substr.Substring(1);
                return LArg.ToStr() + "/(" + substr + ")";
            } // check of a sign sub
            return LArg.ToStr() + "/" + RArg.ToStr();
        }

        public override double DiffCulc()
        {
            return (LArg.DiffCulc() * RArg.ToCulc() - RArg.DiffCulc() * LArg.ToCulc())/Math.Pow(RArg.DiffCulc(),2);
        }
        public override string DiffStr()
        {
            return "((" + LArg.DiffStr() + ") " + "* (" + RArg.ToStr() + ") " + "- (" + LArg.ToStr() + ") " + "* (" + RArg.DiffStr() + ")) / "+ RArg.ToStr() + "^2";
        }
    }
    /// DIV /// }
    /// 

    class pow : Function
    {
        Function LArg;
        Function RArg;
        /// // Constructors {
        public pow(Function Left, Function Right)
        {
            LArg = Left;
            RArg = Right;
        }
        /// // Constructors }

        public override double ToCulc()
        {
            return Math.Pow(LArg.ToCulc(), RArg.ToCulc());
        }
        public override string ToStr()
        {
            return LArg.ToStr() + "^" + RArg.ToStr();
        }

        public override double DiffCulc()
        {
            return RArg.ToCulc() * Math.Pow(LArg.ToCulc(),RArg.ToCulc());
        }
        public override string DiffStr()
        {
            double power = RArg.ToCulc() - 1;
            return RArg.ToStr() + " * " + LArg.ToStr() + "^" + power;
        }
    }
    /// DIV /// }
}
