using System;

namespace Ficha14
{
    public class Ficha14Solucao
    {
        public static void NPrimeirosNumerosNaturais(int num)
        {
            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(num);
            }

            NPrimeirosNumerosNaturais(num);

        }

    }
}
