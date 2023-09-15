using System;

namespace aula10
{
    class Principal
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main(string[] args)
        {
            DiasSemana ds = (DiasSemana)3;

            int dias = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
            Console.WriteLine(dias);
        }
    }
}
