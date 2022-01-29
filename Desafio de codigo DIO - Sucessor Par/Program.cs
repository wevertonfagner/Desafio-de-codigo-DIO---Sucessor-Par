using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo_DIO___Sucessor_Par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int SucessorPar;
            if (x % 2 == 0)
            {
                SucessorPar = x + 2;
            }
            else
            {
                SucessorPar = x + 1;
            }
            Console.WriteLine(SucessorPar);
            Console.ReadKey();
        }
    }
}
