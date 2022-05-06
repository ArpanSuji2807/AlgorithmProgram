using System;
using AlgorithmProgram;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("welcome to the program");
        bool check = true;
        const string path = @"D:\PracticeProblem\AlgorithmProgram\AlgorithmProgram\AlgorithmProgram\BinarySearchFile.txt";
        BinarySearch binary = new BinarySearch();
        Console.WriteLine("1.Binary Search");
        while (check)
        {
            Console.WriteLine("Take an option to execute");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    string words = File.ReadAllText(path);
                    string[] input_Array=words.Split(',');
                    Console.WriteLine("Enter a word to search");
                    string word = Console.ReadLine();
                    binary.Search(input_Array, word);
                    break;
            }
        }
    }
}