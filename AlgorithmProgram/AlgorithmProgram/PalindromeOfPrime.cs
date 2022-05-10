using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PalindromeOfPrime
    {
        int rem=0;
        int rev=0;
        List<int> list=new List<int>();
        public void Palindrome()
        {
            Console.WriteLine("\nPalindrome of Prime Numbers are: ");
            foreach(int data in list)
            {
                int value = data;
                while (value > 0)
                {
                    rem = value % 10;
                    value = value / 10;
                    rev = rev * 10 + rem;
                }
                Console.Write(rev + " ");
            }
        }
        public void Prime(int input)
        {
            Console.WriteLine("Prime numbers are: ");
            for (int num = 2; num < input; num++)
            {
                int flag = 0;
                int count = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write(num + " ");
                    list.Add(num);
                }
            }
        }
    }
}
