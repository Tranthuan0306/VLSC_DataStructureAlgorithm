using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("--- THUẬT TOÁN SẮP XẾP NỔI BỌT (BUBBLE SORT) ---");

        // 1. Khởi tạo một mảng lộn xộn
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;

        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        // 2. Thuật toán Bubble Sort (Dùng kỹ thuật Swap bạn đã học)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Hoán đổi (Swap) dùng biến tạm temp
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", arr));
    }
}