using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int r = 0;

            //imprimir
            Console.WriteLine("Teste aplicação!");

            //popular variáveis
            Console.WriteLine("Informe o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de a: ");
            b = Convert.ToInt32(Console.ReadLine());

            //operação: somar
            r = a + b;

            if (r >= 9)
            {
                Console.WriteLine("Que soma!!! Tá voando");
            }
            else
            {
                Console.WriteLine("Tente outra vez!");
            }

            Console.WriteLine("A soma dos valores informados é: " + r);
            Console.ReadKey();
        }
    }
}
