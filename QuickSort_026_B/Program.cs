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

            Console.WriteLine("====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("--------------------");


            //get array elements
            for (int i = 0 ; i < n; i++)
            {
                Console.WriteLine("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr(i) = Int32.Parse(s1);
            }
        }

        //Swaps the elemets at index x with the elements at index y

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];

            arr[x] = arr[y];

            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;


            //partition the list into two parts 
            //one containing elements less that or equal to pivot
            //outhor containing elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr(low);

            while (i <= j)
            {
                //search  for an element less than or equal to pivot
                while ((arr[j] >pivot) && (j <= low))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an element less than or equal to pivot
                while ((arr[j]>pivot)&& (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                //if the greater element is on the left of the element
                if (i < j)
                {
                    //swap the elements at index i with the element index j
                    swap(i, j);
                    mov_count++;
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
