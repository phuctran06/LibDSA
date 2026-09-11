using System;
using LibDSA;

class Program
{
    public void ShowArray(int[] Array)
    {
        Console.WriteLine("________________________________");
        Console.WriteLine("CURRENT ARRAY:");
        Console.WriteLine(string.Join(", ", Array));
        Console.WriteLine();
    }

    public void SortMenu(Sort sorter, int[] Array, ref int[] CurrentArray)
    {
        int choice;

        while (true)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("SORT");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.Write("Choose algorithm: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number!");
                Console.WriteLine();
                continue;
            }

            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Please choose from 1 to 3!");
                Console.WriteLine();
                continue;
            }

            break;
        }

        // Create a new array from the original array
        CurrentArray = (int[])Array.Clone();

        Console.WriteLine();
        Console.WriteLine("Array before sorting:");
        Console.WriteLine(string.Join(", ", CurrentArray));
        Console.WriteLine();

        if (choice == 1)
        {
            Console.WriteLine("Using Selection Sort...");
            sorter.SelectionSort(CurrentArray);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Using Bubble Sort...");
            sorter.BubbleSort(CurrentArray);
        }
        else if (choice == 3)
        {
            Console.WriteLine("Using Insertion Sort...");
            sorter.InsertionSort(CurrentArray);
        }

        Console.WriteLine();
        Console.WriteLine("Array after sorting:");
        Console.WriteLine(string.Join(", ", CurrentArray));
        Console.WriteLine();
    }

    public void SearchMenu(int[] Array)
    {
        // Search will be implemented later
    }

    static void Main(string[] args)
    {
        int[] Array = { 64, 25, 12, 22, 11 };

        // Array used to store the latest sorting result
        int[] CurrentArray = (int[])Array.Clone();

        Sort sorter = new Sort();

        Program program = new Program();

        int choice;

        while (true)
        {
            Console.WriteLine("================================");
            Console.WriteLine("              MENU");
            Console.WriteLine("0. Show Current Array");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number!");
                Console.WriteLine();
                continue;
            }

            if (choice < 0 || choice > 3)
            {
                Console.WriteLine("Please choose from 0 to 3!");
                Console.WriteLine();
                continue;
            }

            if (choice == 0)
            {
                program.ShowArray(CurrentArray);
            }
            else if (choice == 1)
            {
                program.SortMenu(sorter, Array, ref CurrentArray);
            }
            else if (choice == 2)
            {
                program.SearchMenu(CurrentArray);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Exiting program...");
                break;
            }
        }
    }
}