using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Me
{
    public class Calculator
    {
        private float a, b, c, d;
        private string Operator0, Operator, Operator2, Operator3,radical;
        private float rezultat;
        private double rez2;

         public Calculator(string _radical,float _a)
         {
            this.a = _a;
            this.radical = _radical;
         }
        public Calculator(float _a, string _Operator, float _b)
        {
            this.a = _a;
            this.b = _b;
            this.Operator = _Operator;
        }
        public Calculator(float _a, string _Operator, float _b, string _Operator2, float _c)
        {
            this.a = _a;
            this.b = _b;
            this.Operator = _Operator;
            this.Operator2 = _Operator2;
            this.c = _c;
        }
        public Calculator(float _a, string _Operator, float _b, string _Operator2, float _c,string _Operator3, float _d)
        {
            this.a = _a;
            this.b = _b;
            this.Operator = _Operator;
            this.Operator2 = _Operator2;
            this.Operator3 = _Operator3;
            this.c = _c;
            this.d = _d;
        }

        public float Operatie3()
        {
            switch (Operator3)
            {
                case "+":
                    switch (Operator2)
                    {
                        case "+":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b+c+d;
                                    break;
                                case "-":
                                    rezultat = a - b + c + d;
                                    break;
                                case "*":
                                    rezultat = a * b + c + d;
                                    break;
                                case "/":
                                    rezultat = a / b + c + d;
                                    break;
                            }
                            break;

                        case "-":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a + b - c + d;
                                    break;
                                case "-":
                                    rezultat = a - b - c + d;
                                    break;
                                case "*":
                                    rezultat = a * b - c + d;
                                    break;
                                case "/":
                                    rezultat = a / b - c + d;
                                    break;
                            }
                            break;

                        case "*":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b * c+d;
                                    break;
                                case "-":
                                    rezultat = a - b * c + d;
                                    break;
                                case "*":
                                    rezultat = a * b * c + d;
                                    break;
                                case "/":
                                    rezultat = a / b * c + d;
                                    break;
                            }
                            break;
                        case "/":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b /c+d;
                                    break;
                                case "-":
                                    rezultat = a-b / c+d;
                                    break;
                                case "*":
                                    rezultat = a*b / c+d;
                                    break;
                                case "/":
                                    rezultat = a/b / c+d;
                                    break;
                            }
                            break;
                    }
                    break;

                case "-":
                    switch (Operator2)
                    {
                        case "+":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b + c-d;
                                    break;
                                case "-":
                                    rezultat =a-b + c-d;
                                    break;
                                case "*":
                                    rezultat = a*b + c-d;
                                    break;
                                case "/":
                                    rezultat = a / b + c - d;
                                    break;
                            }
                            break;

                        case "-":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b - c-d;
                                    break;
                                case "-":
                                    rezultat =a-b - c-d;
                                    break;
                                case "*":
                                    rezultat = a * b - c - d;
                                    break;
                                case "/":
                                    rezultat = a / b - c - d;
                                    break;
                            }
                            break;

                        case "*":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b * c-d;
                                    break;
                                case "-":
                                    rezultat = a-b * c-d;
                                    break;
                                case "*":
                                    rezultat = a * b * c - d;
                                    break;
                                case "/":
                                    rezultat = a / b * c - d;
                                    break;
                            }
                            break;
                        case "/":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b / c-d;
                                    break;
                                case "-":
                                    rezultat = a-b / c-d;
                                    break;
                                case "*":
                                    rezultat = a * b / c - d; 
                                    break;
                                case "/":
                                    rezultat = a / b / c - d;
                                    break;
                            }
                            break;
                           
                    }
            break;
                case "*":
                    switch (Operator2)
                    {
                        case "+":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b + c*d;
                                    break;
                                case "-":
                                    rezultat = a - b + c * d;
                                    break;
                                case "*":
                                    rezultat = a * b + c * d; ;
                                    break;
                                case "/":
                                    rezultat = a/b + c*d;
                                    break;
                            }
                            break;

                        case "-":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b - c*d;
                                    break;
                                case "-":
                                    rezultat = a-b - c*d;
                                    break;
                                case "*":
                                    rezultat = a * b - c * d;
                                    break;
                                case "/":
                                    rezultat = a / b - c * d;
                                    break;
                            }
                            break;

                        case "*":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b * c*d;
                                    break;
                                case "-":
                                    rezultat = a - b * c * d;
                                    break;
                                case "*":
                                    rezultat =a * b * c * d;

                                    break;
                                case "/":
                                    rezultat =  a / b * c * d;

                                    break;
                            }
                            break;
                        case "/":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b / c*d;
                                    break;
                                case "-":
                                    rezultat = a - b / c * d;
                                    break;
                                case "*":
                                    rezultat = a * b / c * d;
                                    break;
                                case "/":
                                    rezultat = a / b / c * d;
                                    break;
                            }
                            break;

                    }
                    break;
                case "/":
                    switch (Operator2)
                    {
                        case "+":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b + c/d;
                                    break;
                                case "-":
                                    rezultat = a - b + c / d;
                                    break;
                                case "*":
                                    rezultat = a * b + c / d;
                                    break;
                                case "/":
                                    rezultat = a / b + c / d;
                                    break;
                            }
                            break;

                        case "-":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b - c/d;
                                    break;
                                case "-":
                                    rezultat = a - b - c / d;
                                    break;
                                case "*":
                                    rezultat = a * b - c / d;
                                    break;
                                case "/":
                                    rezultat = a / b - c / d; 
                                    break;
                            }
                            break;

                        case "*":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a + b * c / d;
                                    break;
                                case "-":
                                    rezultat = a - b * c / d;
                                    break;
                                case "*":
                                    rezultat = a * b * c / d;
                                    break;
                                case "/":
                                    rezultat = a / b * c / d;
                                    break;
                            }
                            break;
                        case "/":
                            switch (Operator)
                            {
                                case "+":
                                    rezultat = a+b / c/d;
                                    break;
                                case "-":
                                    rezultat = a - b / c / d;
                                    break;
                                case "*":
                                    rezultat = a * b / c / d;
                                    break;
                                case "/":
                                    rezultat = a / b / c / d; 
                                    break;
                            }
                            break;

                    }
                    break;
            }
            return rezultat;
        }
        public float Operatie2()
        {
            switch (Operator2)
            {
                case "+":
                    switch (Operator)
                    {
                        case "+":
                            rezultat = a+b + c;
                            break;
                        case "-":
                            rezultat = a-b + c;
                            break;
                        case "*":
                            rezultat = a*b + c;
                            break;
                        case "/":
                            rezultat = a/b + c;
                            break;
                    }
                    break;
                case "-":
                    switch (Operator)
                    {
                        case "+":
                            rezultat = a+b- c;
                            break;
                        case "-":
                            rezultat = a-b - c;
                            break;
                        case "*":
                            rezultat =a*b - c;
                            break;
                        case "/":
                            rezultat = a/b- c;
                            break;
                    }
                    break;
                case "*":
                    switch (Operator)
                    {
                        case "+":
                            rezultat = a+b * c;
                            break;
                        case "-":
                            rezultat = a-b * c;
                            break;
                        case "*":
                            rezultat = a*b * c;
                            break;
                        case "/":
                            rezultat = a/b * c;
                            break;
                    }
                    break;
                case "/":
                    switch (Operator)
                    {
                        case "+":
                            rezultat = a+b/ c;
                            break;
                        case "-":
                            rezultat = a-b / c;
                            break;
                        case "*":
                            rezultat = a*b/ c;
                            break;
                        case "/":
                            rezultat = a/b/ c;
                            break;
                    }
                    break;
            }
            return rezultat;
        }
        public float Operatie()
        {
            switch (Operator)
            {
                case "+":
                    rezultat = suma();
                    break;
                case "-":
                    rezultat = diferenta();
                    break;
                case "*":
                    rezultat = inmultirea();
                    break;
                case "/":
                    rezultat = raportul();
                    break;
            }
            return rezultat;

        }
        public double OperatieCuRadical()
        {
            if (radical == "√")
               rez2= numar();
            return rez2;
        }
        public double numar()
        {
            return Math.Sqrt(a);
        }
        public float suma()
        {
            return a + b;
        }
        public float diferenta()
        {
            return a - b;
        }
        public float inmultirea()
        {
            return a * b;
        }
        public float raportul()
        {
            return a / b;
        }




        public float suma2()

        {
            return c + d;
        }
        public float diferenta2()
        {
            return c - d;
        }
        public float inmultirea2()
        {
            return c * d;
        }
        public float raportul2()
        {
            return c / d;
        }
    }
}
