using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class InsertionSort
    {
        public void Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var current_Value = array[i];
                var j = i - 1;
                while (j >= 0 && array[j].CompareTo(current_Value) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current_Value;
            }
        }
        public void Display(string[] array)
        {
            Sort(array);
            foreach (var elements in array)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
