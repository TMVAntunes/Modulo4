using System;

namespace Ficha6
{
    public class Ficha6Solucao
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

            //Exercicio2_1();
            //Exercicio2_2();
            //Exercicio2_3();

            //Exercicio3_1();
            //Exercicio3_2();

        }

    
        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parseNum);
            return parseNum;
            
        }

       public static int LerEConverter()
        {
            Console.WriteLine("Introduza um numero:");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }

        public static void ApresentarSoma(int numbA, int numbB)
        {
            Console.WriteLine(numbA + " + " + numbB + " = " + (numbA + numbB));
        }

        public static void ApresentarMultiplicacao(int numbA, int numbB)
        {
            Console.WriteLine(numbA + " * " + numbB + " = " + (numbA * numbB));
        }

        public static void ApresentarMedia(int numbA, int numbB)
        {
            Console.WriteLine("(" + numbA + " + " + numbB + ") / 2  = " + (numbA + numbB) / 2);
        }


        public static double Soma(double numbA, double numbB)
        {
            return numbA + numbB;
        }

        public static double Subtraccao(double numbA, double numbB)
        {
            return numbA - numbB;
        }

        public static double Multiplicacao(double numbA, double numbB)
        {
            return (numbA * numbB);   
        }

        public static double RestoDaDivisao(double numbA, double numbB)
        {
            return (numbA % numbB);
        }

        public static double Divisao(double numbA, double numbB)
        {
            return (numbA / numbB);
        }




        #region Exercicios resolvidos com recurso a funções auxiliares 

        public static void Exercicio2()
        {
            Console.WriteLine("Introduz 1º numero:");
            var num1 = Console.ReadLine();
            Console.WriteLine("Introduz 2º numero:");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

        public static void Exercicio3()
        {
            var total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            Console.WriteLine(total);
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Introduza 1º número:");
            var a = Console.ReadLine();
            ConverterStringParaNumero(a);
            Console.WriteLine("Introduza 2º número:");
            var b = Console.ReadLine();
            ConverterStringParaNumero(b);
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + "\n" + "b = " + b);
        }

        public static void Exercicio5()
        {
            Console.WriteLine("- 1 + 4 * 6 = " + Soma(-1, Multiplicacao(4, 6)));
            Console.WriteLine("(35 + 5) % 7 = " + RestoDaDivisao(Soma(35, 5), 7));
            Console.WriteLine("14 + (- 4) * 6 / 11 = " + Soma(14, Divisao(Multiplicacao(-4, 6), 11)));
            Console.WriteLine("2 + 15 / 6 - 7 % 2 = " + Subtraccao(Soma(2, Divisao(15, 6)), RestoDaDivisao(7, 2)));
        }
        
        public static void Exercicio6()
        {
            var a = LerEConverter();
            ApresentarMultiplicacao(a, 1);
            ApresentarMultiplicacao(a, 2);
            ApresentarMultiplicacao(a, 3);
            ApresentarMultiplicacao(a, 4);
            ApresentarMultiplicacao(a, 5);
            ApresentarMultiplicacao(a, 6);
            ApresentarMultiplicacao(a, 7);
            ApresentarMultiplicacao(a, 8);
            ApresentarMultiplicacao(a, 9);
            ApresentarMultiplicacao(a, 10);
        }

        public static void Exercicio7()
        {
            var num1 = LerEConverter();
            var num2 = LerEConverter();
            ApresentarMedia(num1, num2);

        }

        public static void Exercicio8()
        {
            var num1 = LerEConverter();
            var num2 = LerEConverter();
            var num3 = LerEConverter();
            var num4 = LerEConverter();
            var num5 = LerEConverter();
            var a = Soma(num1, num2);
            var b = Soma(num3, num4);
            var c = Soma(b, num5);
            a = Soma(a, c);
            Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " + " + num4 + " + " + num5 + " = " + (a / 5));
        }

        public static void Exercicio9()
        {
            int first = LerEConverter();
            int second = LerEConverter();
            int three = LerEConverter();
            int four = LerEConverter();
            int five = LerEConverter();
            int six = LerEConverter();
            int seven = LerEConverter();
            int eight = LerEConverter();
            int nine = LerEConverter();
            int ten = LerEConverter();
            int total = (first + second + three + four + five + six + seven + eight + nine + ten) / 10;
            Console.Write("A média é: " + total);
        }

        public static void Exercicio10()
        {
            Console.WriteLine("Introduzir um caracter");
            string a = Console.ReadLine();
            Console.WriteLine(a + "+" + a + "+" + a);
            Console.WriteLine(a + "+" + a + "+" + a);
            Console.WriteLine(a + "+" + a + "+" + a);
        }




        #endregion


        //------------------------------------------------------------------------------
        #region Exercicios Resolvidos

        public static void Exercicio1_1()
        {
            Console.WriteLine("Introduz nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Olá " + name + ".");
        }

        public static void Exercicio1_2()
        {
            Console.WriteLine("Introduz 1º numero:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz 2º numero:");
            int second = int.Parse(Console.ReadLine());
            int total = first + second;
            Console.Write(total);
        }

        public static void Exercicio1_3()
        {
            Console.WriteLine("Introduzir 10 numeros:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int six = int.Parse(Console.ReadLine());
            int seven = int.Parse(Console.ReadLine());
            int eight = int.Parse(Console.ReadLine());
            int nine = int.Parse(Console.ReadLine());
            int ten = int.Parse(Console.ReadLine());
            int total = first + second + three + four + five + six + seven + eight + nine + ten;
            Console.Write("A soma total é: " + total);
        }

        public static void Exercicio1_4()
        {
            Console.WriteLine("Introduz 1º numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz 2º numero:");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Exercicio1_5()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 - 4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        
        public static void Exercicio1_6()
        {
            Console.WriteLine("Introduz 1º numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " * 1 = " + a * 1);
            Console.WriteLine(a + " * 2 = " + a * 2);
            Console.WriteLine(a + " * 3 = " + a * 3);
            Console.WriteLine(a + " * 4 = " + a * 4);
            Console.WriteLine(a + " * 5 = " + a * 5);
            Console.WriteLine(a + " * 6 = " + a * 6);
            Console.WriteLine(a + " * 7 = " + a * 7);
            Console.WriteLine(a + " * 8 = " + a * 8);
            Console.WriteLine(a + " * 9 = " + a * 9);
            Console.WriteLine(a + " * 10 = " + a * 10);
        }

        public static void Exercicio1_7()
        {
            Console.WriteLine("Qual o 1º numero?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 2º numero:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a + b) / 2);
        }

        public static void Exercicio1_8()
        {
            Console.WriteLine("Qual o 1º numero?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 2º numero:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 3º numero?");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 4º numero:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 5º numero?");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine((a + b + c + d + e) / 5);

        }

        public static void Exercicio1_9()
        {
            Console.WriteLine("Introduzir 10 numeros:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int six = int.Parse(Console.ReadLine());
            int seven = int.Parse(Console.ReadLine());
            int eight = int.Parse(Console.ReadLine());
            int nine = int.Parse(Console.ReadLine());
            int ten = int.Parse(Console.ReadLine());
            int total = (first + second + three + four + five + six + seven + eight + nine + ten) / 10;
            Console.Write("A média é: " + total);
        }

        public static void Exercicio1_10()
        {
            Console.WriteLine("Introduzir um caracter");
            string a = Console.ReadLine();
            Console.WriteLine(a + "+" + a + "+" + a);
            Console.WriteLine(a + "+" + a + "+" + a);
            Console.WriteLine(a + "+" + a + "+" + a);
        }

        public static void Exercicio1_11()
        {
            Console.WriteLine("Nome do 1º produto:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Preço do 1º produto:");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do 1º produto:");
            int q1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do 2º produto:");
            string n2 = Console.ReadLine();
            Console.WriteLine("Preço do 2º produto:");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do 2º produto:");
            int q2 = int.Parse(Console.ReadLine());
            int pTotal1 = p1 * q1;
            int pTotal2 = p2 * q2;
            int compraTotal = pTotal1 + pTotal2;

            Console.WriteLine("Produto 1 Preço total = " + pTotal1);
            Console.WriteLine("Produto 2 Preço total = " + pTotal2);
            Console.WriteLine("Preço Compra total = " + compraTotal);
        }

        public static void Exercicio2_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            string text = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + text);
        }

        public static void Exercicio2_2()
        {
            Console.WriteLine("Introduz dois numeros: ");
            int fstnum = int.Parse(Console.ReadLine());
            int secnum = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro número é " + fstnum);
            Console.WriteLine("o segundo número é " + secnum);
        }

        public static void Exercicio2_3()
        {
            Console.WriteLine("Introduzir a temperatura");
            double tempC = double.Parse(Console.ReadLine());
            double tempF = tempC * 9 / 5 + 32;
            double tempK = tempC + 273.15;
            Console.WriteLine("A temperatura " + tempC + "ºC é " + tempF + "ºF e " + tempK + "ºk.");
        }

        public static void Exercicio3_1()
        {
            Console.WriteLine("Quantas horas?");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas minutos?");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas segundos?");
            int segundos = int.Parse(Console.ReadLine());
            int Total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos + " é equivalente a " + Total + " segundos");
        }

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é o raio?");
            double raio = double.Parse(Console.ReadLine());
            double perimetro = 2 * 3.14 * raio;
            double area = 3.14 * raio * raio;
            Console.WriteLine("A área do circulo é " + area + " e o perimetro é " + perimetro +".");
        }

        #endregion 

    }
}
