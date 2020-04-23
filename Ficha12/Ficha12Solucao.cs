using System;

namespace Ficha12
{
    public class Ficha12Solucao
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();


            //Exercicio16();
        }

        #region Grupo I

        //public static void Exercicio1()
        //{
        //    var total = 1.0;
        //    var output = string.Empty;
        //    for (var counter = 0; counter < 3; counter++)
        //    {
        //        var currentNumber = RequesDouble("Introduza um número");
        //        total *= currentNumber;
        //        output += $"{currentNumber}";
        //        if (counter < 2)
        //            output += $" X";
        //        output += " ";
        //    }
        //    Console.WriteLine($"{output}= {total}");
        //}

        //public static void Exercicio2()
        //{
        //    var firstNumber = RequestDouble("Introduza o 1º número");
        //    var secondNumber = RequestDouble("Introduza o 1º número");
        //    Console.WriteLine($"{firstnumber} + {secondNumber} = {firstNumber + secondNumber)}");
        //    Console.WriteLine($"{secondnumber} + {secondNumber} = {firstNumber + secondNumber)}");
        //    Console.WriteLine($"{firstnumber} + {secondNumber} = {firstNumber + secondNumber)}");
        //    Console.WriteLine($"{firstnumber} + {secondNumber} = {firstNumber + secondNumber)}");

        //}




        public static void Exercicio4()
        {
            Console.WriteLine("Introduza um número");
            var num = int.Parse(Console.ReadLine());
            for (var i = 2; i <= num; i++)
            {
                var isPrime = true;
                for (var j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.WriteLine(i + " ");

            }
        }

        public static void Exercicio16()
        {
            int min = 1;
            int max = 100;
            bool numeroCerto = false;

            while (!numeroCerto)
            {

                var avg = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOk = false;
                if (intConf == 1)
                {
                    for (int i = min; i < max + 1; i++)
                    {
                        Console.WriteLine($"É {i}?");
                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numeroCerto = true;
                            break;
                        }
                        Console.WriteLine("");
                    }
                }

                while (!keyOk)
                {
                    Console.WriteLine($"O número é inferior a {avg}?");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.S:
                            keyOk = true;
                            max = avg - 1;
                            break;
                        case ConsoleKey.N:
                            keyOk = true;
                            min = avg;
                            break;

                        default:
                            break;
                    }
                }

            }
        }






        #endregion



    }
}
