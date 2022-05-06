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
        const string path1 = @"D:\PracticeProblem\AlgorithmProgram\AlgorithmProgram\AlgorithmProgram\IntegerFile.txt";
        InsertionSort sort = new InsertionSort();
        Console.WriteLine("1.Binary Search\n2.Insertion Sort");
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
                case 2:
                    string integer = File.ReadAllText(path1);
                    string[] array = integer.Split(',');
                    sort.Sort(array);
                    sort.Display(array);
                    break;
            }
        }
    }
}