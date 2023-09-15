using System;

namespace aula13
{
    class Principal
    {
        static void Main(string[] args)
        {
            string var = "S";
            while (var == "S" || var == "s")
            {
                int time = 0;
                char escolha;

                Console.WriteLine("\t[Fortaleza/CE - Teresina/PI]\n");
                Console.WriteLine("\t....Escolha o transporte....\n\n\t\t[a]= avião...\n \t\t[o]= onibûs..\n \t\t[c]= carro...");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 'a':
                        time = 28;
                        break;
                    case 'o':
                        time = 60 * 8;
                        break;
                    case 'c':
                        time = 60 * 5;
                        break;
                    default:
                        time = -1;
                        break;
                }
                if (time < 0)
                {
                    Console.WriteLine("\t....Transporte não disponível!....\n ");
                    Console.WriteLine("\t....Deseja tentar novamente? [S/N]");
                    var = Console.ReadLine();
                    if (var == "S")
                    {
                        continue;
                    }
                    else if (var == "s")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    float horas = 0f;
                    horas = (float)time / 60;
                    Console.WriteLine("Tempo de viagem é: {0} horas", horas);
                    break;
                }
            }
        }
    }
}
