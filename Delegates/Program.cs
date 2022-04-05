using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        //delegate bool Check(int num);
        //delegate void Write <T, U, out C>( T a, U b);
        //delegate int Topla(int num1, int num2);
        static void Main(string[] args)
        {
            /*    Topla topla = Summer;
                topla += delegate (int b, int z)
                {
                    return b + z;
                };
                topla += (n, m) =>
                {
                    Console.WriteLine("topla");
                    return n - m;
                };
                Console.WriteLine(topla(5,9));*/

            Action<int, int> test = (n, m) => Console.WriteLine("test");
            Predicate<string> test2 = m => m.Length>5;
            Func <int, int, string> test3 = (n,m) => "test";
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(8);
            numbers.Add(23);
            numbers.Add(14);
            int n  = numbers.Find(n=>n>2);
            List <int> m = numbers.FindAll(n=>n>2);
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
        }
        static int Summer(int n, int m)
        {
            return n + m;
        }
        static void Test(string word1)
        {
            Console.WriteLine(word1);
        }
    }
}