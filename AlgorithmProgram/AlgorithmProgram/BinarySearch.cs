using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BinarySearch
    {
        public void Search(string[] input_Array, string value)
        {
            int min = 0;
            int max = input_Array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (input_Array[mid].Equals(value))
                {
                    Console.WriteLine("The word is at {0} position", mid);
                }
                if (value.CompareTo(input_Array[mid]) > 0)
                {
                    max = mid - 1;
                    Console.WriteLine("The word is at {0} position", max);
                }
                else
                {
                    min = mid + 1;
                    Console.WriteLine("The word is at {0} position", min);
                }
            }
        }
    }
}
