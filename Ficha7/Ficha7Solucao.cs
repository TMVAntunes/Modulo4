using System;


namespace Ficha7
{
    public class Ficha7Solucao
    {
        static void Main(string[] args)
        {
            //Exercicio1_1();
            //Exercicio1_2();
            //Exercicio1_3();
            //Exercicio1_4();
            //Exercicio1_5();
            //Exercicio1_6();
            //Exercicio1_7();
            //Exercicio1_8();
            //Exercicio1_9();
            //Exercicio1_10();
            //Exercicio1_11();
            //Exercicio1_12();
            //Exercicio1_13();

            //Exercicio2_1();
            //Exercicio2_2();
            //Exercicio2_3();

            //Exercicio3_1();
            //Exercicio3_2();

        }

        //Arredondamento para duas casas decimais
        //double i = 2.00000003;
        //i = Math.Round(i,2);

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


        #endregion

        #region Exercicio 1
        public static void Exercicio1_1()
        {
            double num1 = LerEConverter();
            if (num1 > 9.44)
            {
                Console.WriteLine("Passou");
            } else
            {
                Console.WriteLine("Chumbou");
            }

        }

        public static void Exercicio1_2()
        {
            Console.WriteLine("Introduza a altura:");
            double altura = LerEConverter();
            Console.WriteLine("Introduza o peso:");
            double peso = LerEConverter();

            double BMI = peso / (altura * altura);
            Console.WriteLine("O BMI é: " + BMI);

            if (peso <= 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (peso > 18.5 && peso <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (peso > 25 && peso <= 29.9)
            {
                Console.WriteLine("Acima do Peso");
            }
            else if (peso > 30)
            {
                Console.WriteLine("Obeso");
            }
        }

        public static void Exercicio1_3()
        {
            var a = LerEConverter();
            if ((a % 3 == 0) && (a % 7 == 0))
            {
                Console.WriteLine("Divisivel por 3 e 7");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Divisivel por 3 mas não por 7");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("Divisivel por 7 mas não por 3");
            }
            else
            {
                Console.WriteLine("Não é divisivel por 3 nem por 7");
            }
        }

        public static void Exercicio1_4()
        {
            var a = LerEConverter();
            if ((a >= 30) && (a <= 50))
            {
                Console.WriteLine("O número encontra-se entre 30 e 50.");
            }
            else
            {
                Console.WriteLine("O número não se encontra entre 30 e 50.");
            }

        }

        public static void Exercicio1_5()
        {
            var a = LerEConverter();
            if ((a > 10) && (a < 20))
            {
                Console.WriteLine("O número encontra-se entre 10 e 20, exclusive.");
            }
            else
            {
                Console.WriteLine("O número não se encontra entre 10 e 20, exclusive.");
            }

        }

        public static void Exercicio1_6()
        {
            Console.WriteLine("Qual o seu piso de destino?");
            var p = LerEConverterSemNumero();
            if ((p < -2) || (p > 6) || (p == 3) || (p == 5))
            {
                Console.WriteLine("Piso indisponível.");
            }
            else
            {
                Console.WriteLine("O seu piso de destino.");
            }

        }

        public static void Exercicio1_7()
        {
            var num1 = LerEConverter();
            var num2 = LerEConverter();
            var num3 = LerEConverter();
            var num4 = LerEConverter();
            var num5 = LerEConverter();
            var num6 = LerEConverter();
            var num7 = LerEConverter();
            var num8 = LerEConverter();
            var num9 = LerEConverter();
            var num10 = LerEConverter();
            var soma = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            Console.WriteLine("Soma = " + soma);
        }

        public static void Exercicio1_8()
        {
            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome do produto " + (i + 1));
                string n1 = Console.ReadLine();
                Console.WriteLine("Preço do produto " + (i + 1));
                double p1 = LerEConverterSemNumero();
                Console.WriteLine("Quantidade do produto " + (i + 1));
                double q1 = LerEConverterSemNumero();
                double subTotal = p1 * q1;
                Console.WriteLine("subTotal = " + subTotal);
                total += subTotal;
            }

            Console.WriteLine("Total = " + total);
        }

        public static void Exercicio1_9()
        {
            double counter = 0;
            double total = 0;
            double a = 0;

            do
            {
                a = LerEConverter();
                total += a;
                counter++;
            }

            while (a != 0);
            Console.WriteLine("Média = " + (total / counter));

        }

        public static void Exercicio1_10()
        {
            double a = LerEConverter();
            double b = LerEConverter();
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

        public static void Exercicio1_11()
        {
            Console.WriteLine("Introduza um caracter:");
            var a = Console.ReadLine();
            Console.WriteLine(a + " " + a + " " + a);
            Console.WriteLine(a + " " + a + " " + a);
            Console.WriteLine(a + " " + a + " " + a);
        }

        public static void Exercicio1_12()
        {
            var num1 = LerEConverter();
            Console.WriteLine("Introduza 1º caracter:");
            var car1 = Console.ReadLine();
            for (int countL = 0; countL < num1; countL++)
            {
                for (int countC = 0; countC < num1; countC++)
                {
                    Console.Write(car1 + " ");
                }
                Console.Write("\n");
            }
        }

        public static void Exercicio1_13()
        {
            var num1 = LerEConverter();
            var num2 = LerEConverter();
            Console.WriteLine("Introduza 1º caracter:");
            var car1 = Console.ReadLine();
            Console.WriteLine("Introduza 2º caracter:");
            var car2 = Console.ReadLine();
            int pos = 0;
            for (int countL = 0; countL < num1; countL++)
            {
                for (int countC = 0; countC < num2; countC++)
                {
                    if (pos % 2 == 0)
                    {
                        Console.Write(car1 + " ");
                        pos++;
                    }
                    else
                    {
                        Console.Write(car2 + " ");
                        pos++;
                    }

                }
                Console.Write("\n");
            }
        }

        #endregion

        #region Exercicio 2 

        public static void Exercicio2_1()
        {
            Console.WriteLine("Introduza a temperatura:");
            var temp = LerEConverterSemNumero();
            string escala = "";
            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? (escalas C K F)");
                escala = Console.ReadLine();

                if (escala == "C")
                {
                    Console.WriteLine(temp + "ºC é equivalente a " + (temp + 273.15) + "ºK e " + (temp * 9 / 5 + 32) + "ºF.");
                }
                else if (escala == "K")
                {
                    Console.WriteLine(temp + "ºk é equivalente a " + (temp - 273.15) + "ºC e " + (temp * 9 / 5 - 459.67) + "ºF.");
                }
                else if (escala == "F")
                {
                    Console.WriteLine(temp + "ºF é equivalente a " + ((temp - 32) * (5 / 9)) + "ºC e " + ((temp + 459.67) * (5 / 9)) + "ºK.");
                }

            }
        }

        public static void Exercicio2_2()
        {
            Console.WriteLine("Qual é o número limite?");
            var num = LerEConverterSemNumero();
            for (int cont = 0; cont < num; cont++)
            {
                if (cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
        }

        public static void Exercicio2_3()
        {
            string caracteres = "";
            string caracter = "";
            do
            {
                Console.WriteLine("Introduz um caracter");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres;

            } while (caracter != "");

            Console.WriteLine(caracteres);
        }

        #endregion

        #region Exercicio 3

        public static void Exercicio3_1()
        {
            var n = LerEConverter();
            if (n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
                Console.WriteLine(n * 2);
        }


        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual a dimensão do triângulo?");
            double n = LerEConverterSemNumero();
            var i = 1;
            while (n > 0)
            {
                var a = 0;
                n--;
                while(a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                
                var b = 0;
                while(b != i)
                {
                    Console.Write("*");
                    b++;
                }

                i += 2;
                Console.WriteLine(" ");       
            }
        }

        #endregion




    }
}
