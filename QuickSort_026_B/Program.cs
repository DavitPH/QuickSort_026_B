using System;

namespace QuickSort_026_B
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int [20];
        private int cmp_count = 0; //number of comporasion
        private int mov_count = 0; //number of data movements

        //number of elements in array
        private int n;


        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the numbers of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);

                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 element \n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
