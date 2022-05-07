using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PrimeNumbers
    {
        int rem = 0, rev = 0;
        public void PrimeNumbersInRange()
        {
            Console.WriteLine("Enter the Range of Numbers");
            int input=Convert.ToInt32(Console.ReadLine());
            if (input<=1)
            {
                Console.WriteLine("Invalid Number for Range");
            }
            else
            {
                for (int num = 2; num < input; num++)
                {
                    int flag = 0;
                    for (int i = 2; i < num; i++)
                    {
                        if (num%i==0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if(flag==0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
