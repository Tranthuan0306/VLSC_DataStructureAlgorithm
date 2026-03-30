using System;

class Program
{
    static void Main(string[] args)
    {
        // Hỗ trợ gõ tiếng Việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập họ tên sinh viên: ");
        string name = Console.ReadLine();

        Console.Write("Nhập mã số sinh viên (MSSV): ");
        string mssv = Console.ReadLine();

        Console.WriteLine($"\nChào mừng sinh viên {name} (MS: {mssv}) đến với lớp CTDL&GT!");
    }
}