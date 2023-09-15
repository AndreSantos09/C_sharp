using System;

namespace aula05
{
    class Principal
    {
        static void verificar(int valor1, int valor2)
        {
            bool result = valor1 < valor2;
            Console.WriteLine("A relação é: " + result);
        }
        static void Main(string[] args)
        {
            int result = (10 + 5) * 2;
            Console.WriteLine(result);

            verificar(10, 5);

        }
    }
}
