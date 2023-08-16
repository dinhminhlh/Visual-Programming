using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int max = arr[0], dem = 0, tong = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                tong += arr[i];
                if (arr[i] < 0)
                {
                    dem++;
                }
            }

            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.WriteLine("Tong day: " + tong);
            Console.WriteLine("So phan tu am: " + dem);

        }
    }
}
