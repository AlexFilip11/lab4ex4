using System;

namespace lab4ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi.
            Console.WriteLine("introduceti nr de elemente din vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele din vector: ");
            vector = ReadVector(n);
            ShowVector(vector, n - 1);
        }
        static int[] ReadVector(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        static void ShowVector(int[] vector, int n)
        {
            if(n<0)
            {
                return;
            }
            Console.Write(vector[n] + " ");
            ShowVector(vector, n-1);
        }
    }
}
