using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("--- BÀI 3: KỸ THUẬT HOÁN ĐỔI (SWAP) ---");

        // Khởi tạo 2 biến với giá trị ban đầu x=5, y=10
        int x = 5, y = 10;
        Console.WriteLine($"Trước khi hoán đổi: x = {x}, y = {y}");

        // Thuật toán hoán đổi sử dụng biến trung gian temp
        int temp = x; // Bước 1: Cất giá trị của x vào temp
        x = y;        // Bước 2: Lấy giá trị của y gán cho x
        y = temp;     // Bước 3: Lấy giá trị từ temp (x cũ) gán cho y

        Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}");
    }
}
