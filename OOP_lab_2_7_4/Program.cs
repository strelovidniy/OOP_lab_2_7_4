using System;

namespace OOP_lab_2_7_3
{
    public class Program
    {
        public static int maxAbs(int[] arr)
        {
            int max = -1;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) >= max)
                    max = arr[i];
            }
            return max;
        }

        public static int sumZero(int[] arr)
        {
            bool switcher = false;
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (switcher)
                    sum += arr[i];

                if (arr[i] == 0)
                {
                    switcher = true;
                    sum = 0;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            Console.WriteLine("Максимальний за модулем елемент масиву: {0}.", maxAbs(a));
            Console.WriteLine("добуток елементiв масиву, розташованих пiсля останнього нульового елемента: {0}.", sumZero(a));

        }
    }
}
