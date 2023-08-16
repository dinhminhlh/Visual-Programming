using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Input();
            Console.WriteLine("Mang ban dau: ");
            Output(numbers);

            Sort(numbers);
            Console.WriteLine("Mang sau khi sap xep: ");
            Output(numbers);
        }
        static int[] Input()
        {
            Console.WriteLine("Moi nhap so luong phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static void Sort(int[] arr)
        {
            Array.Sort(arr);
        }

        static void Output(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
