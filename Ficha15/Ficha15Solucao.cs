using System;

namespace Ficha15
{
    public class Ficha15Solucao
    {
        #region Grupo 1: Análise, planeamento e solução de problemas

        public static void Exercicio1()//Solicitar 10 valores e armazenar num array
        {
            Console.WriteLine("Introduza dez valores a serem introduzidos no array:");

            int[] values = new int[10];

            for (int j = 0; j < values.Length; j++)
            {
                values[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < values.Length; i++)
            {
                //Console.WriteLine("Na posição " + i + " está guardado o valor: " + values[i]);
                Console.WriteLine($"Na posição [{i}] está guardado o valor: {values[i]}");
            }
        }

        public static void Exercicio2()//
        {
            Console.WriteLine("Introduza dez valores a serem introduzidos no array:");

            int[] values = new int[10];

            for (int j = values.Length - 1; j >= 0; j--)
            {
                values[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < values.Length; i++)
            {
                //Console.WriteLine("Na posição " + i + " está guardado o valor: " + values[i]);
                Console.WriteLine($"Na posição [{i}] está guardado o valor: {values[i]}");
            }
        }

        public static void Exercicio3()
        {

            int[] values = new int[10];
            int soma = 0;

            Console.WriteLine("Introduza dez valores a serem introduzidos no array de forma a obter a sua soma:");

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < values.Length; j++)
            {
                soma += values[j];
            }

            Console.WriteLine($"A soma é {soma}");
        }

        public static void Exercicio4()//Contar os elementos de um array
        {
            int[] array = new int[12];

            int contadorElementos = array.Length;
            Console.WriteLine($"O número de elementos do array são: {contadorElementos}");

        }

        public static void Exercicio5()//Contar os elementos repetidos de um array
        {
            int[] array = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };
            int contador = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (j != i && array[i] == array[j])
                    {
                        contador++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Número de elementos repetidos: {contador}");
        }

        public static void Exercicio6()//Apresenta os elementos únicos de um array
        {
            int[] array = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 13 };
            int contador = 0;


            Console.WriteLine(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        break;
                    }

                    if(j == i - 1)
                    {
                        Console.WriteLine(array[i]);
                    }
                    
                }
            }
        }

        public static void Exercicio7() //Encontra o menor e maior valor num array numérico
        {
            int[] array = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };
            int iMaior = 0, iMenor = 0;

            for (int i = 0; i < array.Length; i++)
            {
                // descobre o maior índice
                if (array[i] > array[iMaior])
                {
                    iMaior = i;
                }
                // descobre o menor índice
                if (array[i] < array[iMenor])
                {
                    iMaior = i;
                }
            }

            Console.WriteLine($"Elemento maior: {array[iMaior]}");
            Console.WriteLine($"Elemento menor: {array[iMenor]}");

        }

        public static void Exercicio8() //Separa os números impares dos pares (Completo)
        {
            int[] array = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };

            int contadorImpar = 0, contadorPar = 0;

            for (int i = 0; i < array.Length; i++)
            {
                // descobre os numeros impares
                if (array[i] % 2 != 0)
                {
                    contadorImpar++;
                }
                else
                {
                    contadorPar++;
                }

            }

            int[] arrayImpar = new int[contadorImpar];
            int[] arrayPar = new int[contadorPar];

            Console.WriteLine($"Tamanho do vector: {arrayPar.Length}");
            Console.WriteLine($"Numeros Impares: {arrayImpar.Length}");

            for (int i = 0, j = 0, k = 0; i < array.Length; i++)
            {
                // descobre os numeros impares
                if (array[i] % 2 != 0)
                {
                    arrayImpar[j] = array[i];
                    j++;
                }
                else
                {
                    arrayPar[k] = array[i];
                    k++;
                }

            }

            for (int i = 0; i < arrayImpar.Length; i++)
            {
                Console.Write($"{arrayImpar[i]}, ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayPar.Length; i++)
            {
                Console.Write($"{arrayPar[i]}, ");
            }

        }

        public static void Exercicio9() //Algoritmo que verifica se um elemento se encontra num array
        {
            int[] array = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };



            while (true)
            {

            Console.WriteLine("Introduza um valor?");
            int elemento = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < array.Length; i++)
            {
                if (elemento == array[i])
                {
                    Console.WriteLine($"O valor introduzido encontra-se dentro do array.");
                    break;
                }

                if (i == array.Length-1)
                {
                    Console.WriteLine($"O valor introduzido não se encontra dentro do array.");
                }
            }

        }


    }

        #endregion

    }
}
