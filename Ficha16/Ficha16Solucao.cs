using System;
using System.Collections.Generic;

namespace Ficha16
{
    public class Ficha16Solucao
    {
        #region Exercicio 1
        public static void Exercicio1()//Solicitar 10 valores e armazena-los numa lista
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduza um valor:");
                int valor = int.Parse(Console.ReadLine());
                list.Add(valor);
            }

            Console.WriteLine("Elementos na lista:");

            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j]);
            }
        }
        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduza um valor:");
                int valor = int.Parse(Console.ReadLine());
                lista.Add(valor);
            }

            Console.WriteLine("Elementos listados por ordem inversa:");

            for (int j = lista.Count - 1; j >= 0; j--)
            {
                Console.WriteLine(lista[j]);
            }
        }
        #endregion

        #region Exercicio 3

        public static void Exercicio3()
        {
            List<int> lista = new List<int>();
            int soma = 0;

            Console.WriteLine("Introduza um valor:");

            for (int i = 0; i < 10; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                lista.Add(valor);
            }

            for (int j = 0; j < 10; j++)
            {
                soma += lista[j];
            }

            Console.WriteLine($"A soma de todos os elementos é: {soma}");

        }

        #endregion

        #region Exercicio 4
        public static void Exercicio4(List<int> lista)//Contar os elementos repetidos de um array
        {
            List<int> countLista = new List<int>();
            int count = 1;
            int duplicate = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j < lista.Count; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        countLista.Add(count);
                        count++;
                    }
                }
            }

            for (int k = 0; k < countLista.Count; k++)
            {
                if (countLista[k] == 2)
                {
                    duplicate++;
                }
            }


            Console.WriteLine($"Número de elementos repetidos: {duplicate}");
            #endregion

        }

    }

}
