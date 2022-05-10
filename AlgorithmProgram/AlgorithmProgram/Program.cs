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
        Console.WriteLine("1.Binary Search\n2.Insertion Sort\n3.Bubble Sort\n4.Anagrams\n5.Prime Numbers in a range\n6.Message demonstration\n7.Merge Sort\n8.Palindrome of Prime number\n9.Finding Number");
        while (check)
        {
            Console.WriteLine("Take an option to execute");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    string words = File.ReadAllText(path);
                    string[] input_Array = words.Split(',');
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
                case 3:
                    string integer1 = File.ReadAllText(path1);
                    string[] arr = integer1.Split(',');
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort(arr);
                    bubbleSort.Display(arr);
                    break;
                case 4:
                    Anagrams anagrams = new Anagrams();
                    Console.WriteLine("Enter the first word: ");
                    string first_Word = Console.ReadLine();
                    Console.WriteLine("Enter the second word: ");
                    string second_Word = Console.ReadLine();
                    anagrams.AnagramOfWords(first_Word, second_Word);
                    break;
                case 5:
                    PrimeNumbers numbers = new PrimeNumbers();
                    numbers.PrimeNumbersInRange();
                    break;
                case 6:
                    MessageDemonstration message = new MessageDemonstration();
                    message.Message();
                    break;
                case 7:
                    MergeSort merge1 = new MergeSort();
                    int[] arr1 = {3, 5, 6, 4, 9,7};
                    int[] firstArr = { 3, 5, 6 };
                    int[] secondArr = { 4, 9, 7 };
                    merge1.Merge(firstArr, secondArr);
                    merge1.Sorting(arr1);
                    break;
                case 8:
                    PalindromeOfPrime palindrome=new PalindromeOfPrime();
                    Console.WriteLine("Enter the number: ");
                    int num=Convert.ToInt32(Console.ReadLine());
                    palindrome.Prime(num);
                    palindrome.Palindrome();
                    break;
                case 9:
                    FindingNumber finding = new FindingNumber();
                    Console.WriteLine("Enter the power number: ");
                    int pow=Convert.ToInt32(Console.ReadLine());
                    finding.Find_Number(pow);
                    break;
                case 10:
                    Console.WriteLine("Enter a valid choice");
                    break;
                    default:break;
            }
        }
    }
}