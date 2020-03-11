using System;

namespace Ficha9
{
    class Ficha9Solucao
    {
        static void Main(string[] args)
        {
            Exercicio1_1();
        }


        #region Funções Auxiliares

        public static double ConverterStringParaNumero(string num)
        {
            var parseOk = double.TryParse(num, out double parseNum);
            return parseNum;

        }

        public static double LerEConverter()
        {
            Console.WriteLine("Introduza um numero:");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }

        public static double LerEConverterSemNumero()
        {
            //Console.WriteLine("Introduza um numero:");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }

        public static double ApresentaSoma(double numbA, double numbB)
        {
            return numbA + numbB;
        }

        public static double ApresentaSubtraccao(double numbA, double numbB)
        {
            return numbA - numbB;
        }

        public static double ApresentaMultiplicacao(double numbA, double numbB)
        {
            return (numbA * numbB);
        }

        public static double ApresentaRestoDaDivisao(double numbA, double numbB)
        {
            return (numbA % numbB);
        }

        public static double ApresentaDivisao(double numbA, double numbB)
        {
            return (numbA / numbB);
        }

        #endregion

        #region Exercicios

        public static void Exercicio1_1()
        {
            var num1 = LerEConverter();
            var num2 = LerEConverter();
            var num3 = LerEConverter();
            Console.WriteLine("O seu produto é: " + num1 * num2 * num3);
        }

        public static void Exercicio1_2()
        {
            var a = LerEConverter();
            var b = LerEConverter();
            Console.WriteLine("Introduza uma destas operações ( + - * / % ) ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("Operação: " + a + " + " + b + " = " + (a + b));
            }
            else if (c == "-")
            {
                Console.WriteLine("Operação: " + a + " - " + b + " = " + (a - b));
            }
            else if (c == "*")
            {
                Console.WriteLine("Operação: " + a + " * " + b + " = " + (a * b));
            }
            else if (c == "/")
            {
                Console.WriteLine("Operação: " + a + " / " + b + " = " + (a / b));
            }
            else if (c == "%")
            {
                Console.WriteLine("Operação: " + a + " % " + b + " = " + (a % b));
            }

        }

    }


        #endregion





    }
}
