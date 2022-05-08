using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagrams
    {
        public bool AnagramOfWords(string first_Word, string second_Word)
        {
            char[] str1=first_Word.ToCharArray();
            char[] str2=second_Word.ToCharArray();
            Array.Sort(str1);
            Array.Sort(str2);
            string value1=new string(str1);
            string value2=new string(str2);
            if (value1==value2)
            {
                Console.WriteLine("Both are Anagrams");
                return true;
            }
            else
            {
                Console.WriteLine("Both are not Anagrams");
                return false;
            }
        }
    }
}
