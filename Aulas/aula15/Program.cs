using System;

namespace aula15
{
    class Principal
    {
        static void Main(string[] args)
        {
            int[,] vetor = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vetor[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write("[" + vetor[i, j] + "]" + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}