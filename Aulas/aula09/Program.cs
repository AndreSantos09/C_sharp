using System;

namespace aula09
{
    class Principal
    {
        static void Main(string[] args)
        {
            // Bitwise operator
            //  << DOBRA O VALOR
            //  >> METADE DO VALOR

            // EXEMPLOS 

            // 00001010 << 10
            // 00010100 É EQUIVALENTE A 20

            // 00011010 >> 26
            // 00001101 É EQUIVALENTE A 13

            int num = 10;
            num = num << 1;
            Console.WriteLine("Bitwise << 1 de 10 é: " + num);
            int num2 = 10;
            num2 = num2 >> 1;
            Console.WriteLine("Bitwise >> 1 de 10 é: " + num2);

        }
    }
}
