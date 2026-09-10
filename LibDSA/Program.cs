using System;
using LibDSA;

class Program
{
    public void ShowArray(int[] Array)
    {
        Console.WriteLine("________________________________");
        Console.WriteLine("MẢNG HIỆN TẠI:");
        Console.WriteLine(string.Join(", ", Array));
        Console.WriteLine();
    }

    public void SortMenu(Sort sorter, int[] Array)
    {
        int choice;

        while (true)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("SORT");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Sort 3");
            Console.Write("Chọn thuật toán: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Vui lòng nhập số!");
                Console.WriteLine();
                continue;
            }

            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Vui lòng chọn từ 1 đến 3!");
                Console.WriteLine();
                continue;
            }

            break;
        }

        if (choice == 1)
        {
            sorter.SelectionSort(Array);

            Console.WriteLine("Mảng sau khi xếp tăng dần: "
                + string.Join(", ", Array));
        }
        else if (choice == 2)
        {
            sorter.BubbleSort(Array);

            Console.WriteLine("Mảng sau khi xếp tăng dần: "
                + string.Join(", ", Array));
        }
        else if (choice == 3)
        {
            // Tạm thời chưa gọi Sort thứ 3
            Console.WriteLine("Đã chọn Sort 3");
        }

        Console.WriteLine();
    }

    public void SearchMenu(int[] Array)
    {
        // Tạm thời chưa làm Search
    }

    static void Main(string[] args)
    {
        int[] Array = { 64, 25, 12, 22, 11 };

        Sort sorter = new Sort();

        Program program = new Program();

        int choice;

        while (true)
        {
            Console.WriteLine("================================");
            Console.WriteLine("        MENU CHÍNH");
            Console.WriteLine("================================");
            Console.WriteLine("0. Xem mảng hiện tại");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Exit");
            Console.Write("Chọn: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Vui lòng nhập số!");
                Console.WriteLine();
                continue;
            }

            if (choice < 0 || choice > 3)
            {
                Console.WriteLine("Vui lòng chọn từ 0 đến 3!");
                Console.WriteLine();
                continue;
            }

            if (choice == 0)
            {
                program.ShowArray(Array);
            }
            else if (choice == 1)
            {
                program.SortMenu(sorter, Array);
            }
            else if (choice == 2)
            {
                program.SearchMenu(Array);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thoát chương trình.");
                break;
            }
        }
    }
}