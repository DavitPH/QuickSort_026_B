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
                Console.Write("Enter the numbers of elements in the array : ");
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
                Console.Write("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
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

            pivot = arr[low];

            while (i <= j)
            {
                //search  for an element less than or equal to pivot
                while ((arr[i] >pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an element less than or equal to pivot
                while ((arr[j]>pivot) && (j >= low))
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

            if (low < j)
            {

                swap(low, j);
                mov_count++;
            }

            q_sort(low, j - 1);
            q_sort(j + 1, high);
        }

        void display()
        {
            Console.WriteLine("");
            Console.WriteLine("Sorted array elements");
            Console.WriteLine("");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("/nNumber of comporisons : ", + cmp_count);
            Console.WriteLine("/nNumber of data movements : ", +mov_count);
        }

        int getSize()
        {
            return (n);
        }

        static void Main(string[] args)
        {
            //declaring the object of the class
            Program my_list = new Program();

            //accpet array elements
            my_list.input();


            //caling the sorting function 
            //first call the QUICK SORT Alogarithm

            my_list.q_sort(0, my_list.getSize() - 1);

            //display started array
            my_list.display();

            //to exit from the console

            Console.WriteLine("\n\nPress Enter to Exit");
            Console.Read();
        }
    }
}
