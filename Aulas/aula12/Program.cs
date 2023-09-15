using System;

namespace aula12
{
    class Principal
    {
        static void Main(string[] args)
        {
            char var = 'S';
            string var2;
            int nota2;
            string result = "Reprovado";

            while (var == 'S')
            {
                Console.Write("Insira sua nota final: ");
                string nota = Console.ReadLine();

                if (nota == "")
                {
                    Console.Write("Não deixe a caixa de resposta em branco!, Tentar novamente?[S/N]");
                    var2 = (Console.ReadLine());
                    if (var2 != "S")
                    {
                        Console.Write("Programa fechando!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    nota2 = Convert.ToInt32(nota);
                    if (nota2 >= 70)
                    {
                        result = "Aprovado";
                    }
                    Console.WriteLine("O Resultado: {0}", result);
                    break;
                }
            }
        }
    }
}
