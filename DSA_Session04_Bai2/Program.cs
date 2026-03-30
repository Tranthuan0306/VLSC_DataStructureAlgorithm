using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("--- BÀI 2: MÁY TÍNH CƠ BẢN ---");

        Console.Write("Nhập số nguyên a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");

        if (b != 0) {
            // Ép kiểu (double) để lấy kết quả số thập phân
            Console.WriteLine($"{a} / {b} = {(double)a / b}");
        } else {
            Console.WriteLine("Lỗi: Không thể chia cho số 0!");
        }
    }
}