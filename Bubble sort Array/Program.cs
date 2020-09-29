using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asign numbers to the array
            int[] array = new int[10];


            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                

                array[i] = random.Next(1, 100);
            }

            Console.Write("Start array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            //Bubble sort
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < (array.Length - 1) - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int _temp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = _temp;

                    }
                }
            }

            

            Console.Write("Slut Array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();


            //Sætter Array modsat
            Array.Reverse(array);

            Console.Write("Slut Array med reverse: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
