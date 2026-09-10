using System;
using LibDSA;

class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo đối tượng Sort chứa các thuật toán của bạn
        Sort sorter = new Sort();

        int[] selectionArray = { 64, 25, 12, 22, 11 };
        Console.WriteLine("--- KIỂM TRA SELECTION SORT ---");
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", selectionArray));

        // Gọi thuật toán sắp xếp lựa chọn
        sorter.SelectionSort(selectionArray);

        Console.WriteLine("Mảng sau khi xếp tăng dần: " + string.Join(", ", selectionArray));
        Console.WriteLine();

        int[] bubbleArray = { 34, 2, 53, 22, 1, 8 };
        Console.WriteLine("--- KIỂM TRA BUBBLE SORT ---");
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", bubbleArray));

        sorter.BubbleSort(bubbleArray);

        Console.WriteLine("Mảng sau khi xếp tăng dần: " + string.Join(", ", bubbleArray));
        Console.WriteLine();

        // Dừng màn hình để xem kết quả
        Console.ReadLine();
    }
}
