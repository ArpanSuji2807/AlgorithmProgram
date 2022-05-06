using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BubbleSort
    {
        public void Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
        public void Display(string[] array)
        {
            Console.Write("Sorted to: ");
            foreach (var data in array)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
