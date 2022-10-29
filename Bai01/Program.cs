using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        
        static int sumOfOddNumber(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static bool isPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        
        static int countPrimeNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i])) 
                {
                    count++;
                }
            }
            return count;
        }

        static bool isSquareNumber(int x)
        {
            return Math.Sqrt(x) % 1 == 0;
        }
        
        static int findMinSquareNumber(int[] arr)
        {
            Array.Sort(arr);
            int res = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isSquareNumber(arr[i]))
                {
                    res = arr[i];
                    break;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            bool b = isSquareNumber(n);

            
            int sum = 0;
            sum = sumOfOddNumber(arr);
            Console.WriteLine("Tong cac so le: " + sum);

            //So luong so nguyen to
            int count = 0;
            count = countPrimeNumber(arr);
            Console.WriteLine("So luong so nguyen to trong mang: " + count);

            //Tim so chinh phuong nho nhat
            int res = findMinSquareNumber(arr);
            Console.WriteLine("So chinh phuong nho nhat: " + res);
        }
    }
}
