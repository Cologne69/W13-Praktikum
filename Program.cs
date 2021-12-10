using System;

namespace W13_Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Berapa data: ");
                int brpData = int.Parse(Console.ReadLine());
                string[,] data = new string[6, brpData];
                for (int i = 0; i < brpData; i++)
                {
                    Console.WriteLine($"\nData ke-{i + 1}");
                    Console.Write("NIM           : ");
                    data[0, i] = Console.ReadLine().ToUpper();
                    for (int j = 0; j < brpData; j++)
                    {

                    }
                    Console.Write("NAMA \t\t : ");
                    data[1, i] = Console.ReadLine().ToUpper();
                    Console.Write("JENIS KELAMIN \t : ");
                    data[2, i] = Console.ReadLine().ToUpper();
                    Console.Write("TAHUN MASUK \t : ");
                    data[3, i] = Console.ReadLine().ToUpper();
                    Console.Write("PROGRAM STUDI \t : ");
                    data[4, i] = Console.ReadLine().ToUpper();
                    Console.Write("KELAS \t\t : ");
                    data[5, i] = Console.ReadLine().ToUpper();
                }
                Console.Clear();
                Console.WriteLine("NO   NIM    NAMA                JENIS KELAMIN          TAHUN MASUK   PROGRAM STUDI     KELAS");
                for (int i = 0; i < brpData; i++)
                {
                    Console.SetCursorPosition(0, i + 1);
                    Console.Write($"{i + 1}");
                    Console.SetCursorPosition(5, i + 1);
                    Console.Write(data[0, i]);
                    Console.SetCursorPosition(12, i + 1);
                    Console.Write(data[1, i]);
                    Console.SetCursorPosition(32, i + 1);
                    Console.Write(data[2, i]);
                    Console.SetCursorPosition(55, i + 1);
                    Console.Write(data[3, i]);
                    Console.SetCursorPosition(69, i + 1);
                    Console.Write(data[4, i]);
                    Console.SetCursorPosition(87, i + 1);
                    Console.Write(data[5, i]);
                }
                Console.Write("\nTambah data? (y/n) ... ");
                string cariLagi = Console.ReadLine().ToLower();

                if (cariLagi == "y")
                {
                    continue;
                }
                if (cariLagi == "n")
                {
                    System.Environment.Exit(0);
                }
            }
        }     
    }
}
