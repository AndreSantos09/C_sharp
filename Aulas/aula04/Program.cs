using System;

namespace aula04
{
    class Principal
    {
        static void dobro(int num)
        {
            Console.WriteLine("O dobro do número é: " + (num * 2));
        }
        static void Main(string[] args)
        {
            int var = 5;
            dobro(var);
            Console.WriteLine("Esté funcioando o console!");
        }
    }
}
