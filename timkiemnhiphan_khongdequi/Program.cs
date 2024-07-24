using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lam Tuan Dat
//2033212004
//buoi 3
internal class TimKiemNhiPhan_KhongDeQui
{
    static void Main()
    {
        int[] a;
        int n, x;

        do
        {
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        a = new int[n];

        nhapMang(a, n);
        xuatMang(a, n);

        Console.Write("\nNhap x can tim: ");
        x = int.Parse(Console.ReadLine());

        int kq = binarySearch(a, n, x);

        if (kq == -1)
            Console.WriteLine($"\nKhong tim thay {x} trong mang");
        else
            Console.WriteLine($"\nTim thay {x} tai vi tri thu {kq}");
    }

    static void nhapMang(int[] a, int n)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            a[i] = rand.Next(1, 100);
        }
    }

    static void xuatMang(int[] a, int n)
    {
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\t{a[i]}");
        }
        Console.WriteLine();
    }

    static int binarySearch(int[] a, int n, int key)
    {
        int left = 0;
        int right = n - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (a[mid] == key)
                return mid;

            if (key < a[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
}