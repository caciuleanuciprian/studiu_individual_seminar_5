using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiuIndividualProblema5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            bool mhm = true;

            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());


            int[] array = new int[n];

            Console.WriteLine("Elementele vectorului: ");

            int i = 0;

            while (i < n)
            {
                array[i] = int.Parse(Console.ReadLine());
                i++;
            }

            i = 1;

            while (i < n)
            {
                if (array[i - 1] < array[i])
                {
                    mhm = false;
                }

                i++;
            }

            if (mhm == true)
            {
                Console.WriteLine("Este crescator de la dreapta la stanga.");
            }
            else
            {
                Console.WriteLine("Nu este crescator de la dreapta la stanga.");
            }


            Console.ReadLine();
        }
    }
}
