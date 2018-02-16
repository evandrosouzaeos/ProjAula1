using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula1_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota = 0;
            int aux = 0;

            Console.Write("Nota:");

            while (aux == 0)
            {
                try
                {
                    nota = Convert.ToInt32(Console.ReadLine());
                    aux = 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("Caracter inválido!");
                    Console.Write("Notassss:");
                }
            }

            while (nota != 0) 
            {

                aux = 0;

                switch (nota)
                {
                    case 1:

                        Console.WriteLine("A nota é 1");
                        break;

                    case 5:

                        Console.WriteLine("A nota é 5");
                        break;

                    default:
                        Console.WriteLine("Sabe lá... que nota é essa!");
                        break;
                }
                Console.Write("Nota:");
                while (aux == 0)
                {
                    try
                    {
                        nota = Convert.ToInt32(Console.ReadLine());
                        aux = 1;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Caracter inválido!");
                        Console.Write("Nota:");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
