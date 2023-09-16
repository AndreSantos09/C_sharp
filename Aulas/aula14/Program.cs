using System;

namespace aula14
{
    class Principal
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("insira um valor: ");
                
                vetor[i] = int.Parse(Console.ReadLine());
                
            }
            for (int j = 0; j < vetor.Length; j++)
            {
                Console.Write("["+vetor[j]+"]"+" ");
            }
        }
    }
}