using System;
namespace Demo
{
    public class MyApplication
    {
        public static void Main(string[] args)
        {
            int[] list = { 98, 23, 97, 36, 77 };
            Console.WriteLine("Original Unsorted List");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            //sort
            Array.Sort(list);
            // Descending order
            Array.Reverse(list);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
