using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Tạo mảng 1 triệu phần tử để thấy sự chênh lệch
        int size = 1000000;
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = i;

        int target = 999999; // Tìm phần tử cuối cùng

        // 2. Tìm kiếm tuyến tính (Linear Search)
        Stopwatch sw = Stopwatch.StartNew();
        int linearIndex = LinearSearch(arr, target, out int linearSteps);
        sw.Stop();
        Console.WriteLine($"[Linear] Index: {linearIndex}, Steps: {linearSteps}, Time: {sw.Elapsed.TotalMilliseconds} ms");

        // 3. Tìm kiếm nhị phân (Binary Search)
        sw.Restart();
        int binaryIndex = BinarySearch(arr, target, out int binarySteps);
        sw.Stop();
        Console.WriteLine($"[Binary] Index: {binaryIndex}, Steps: {binarySteps}, Time: {sw.Elapsed.TotalMilliseconds} ms");
    }

    // Hàm Tìm kiếm tuyến tính
    static int LinearSearch(int[] arr, int x, out int steps)
    {
        steps = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            steps++;
            if (arr[i] == x) return i;
        }
        return -1;
    }

    // Hàm Tìm kiếm nhị phân
    static int BinarySearch(int[] arr, int x, out int steps)
    {
        steps = 0;
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            steps++;
            int mid = left + (right - left) / 2;
            if (arr[mid] == x) return mid;
            if (arr[mid] < x) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}