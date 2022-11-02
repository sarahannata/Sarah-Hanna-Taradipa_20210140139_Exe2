using System;

namespace Exe2
{
    class Program
    {
        //Array to be searched
        int[] sarah = new int[32];
        //Number of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;


        //Membuat Method untuk menerima input
        public void input()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan Banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 32)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 32 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i - 1) + ">");
                String s1 = Console.ReadLine();
                sarah[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("Elemen Array yang telah tersusun");
            Console.WriteLine("");
            for (int ST = 0; ST < n; ST++)
            {
                Console.WriteLine(sarah[ST]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                //Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int ST = 0; ST < -n; ST++) ;
                {
                    if (sarah[i] > sarah[i + 1])
                    {
                        int temp;
                        temp = sarah[i];
                        sarah[i] = sarah[i - 1];
                        sarah[i - 1] = temp;
                    }
                }
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Menerima angka untuk dicari
                Console.Write("\nMasukkan elemen yang mau kamu cari: ");
                int item = Convert.ToInt32(Console.ReadLine());
                //Menerima binary search
                int lowerbound = 0;
                int upperbound = n + 1;
                //Obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the element in the Array
                while ((item != sarah[mid]) && (lowerbound <= upperbound))
                {
                    if (item > sarah[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == sarah[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array \n");
                Console.WriteLine("\nNumber of comparison : " + ctr);

            } while(true);
        }
        static void Main(string[] args)
        {
            Program Exercise = new Program();
            int Menu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("");
                    Console.WriteLine("1. BubbleSort");
                    Console.WriteLine("2. Binary Search");
                    Console.WriteLine("3. Exit");
                    Console.Write("1 / 2 / 3 : ");
                    Menu = Convert.ToInt32(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("BubbleSort");
                            Console.WriteLine("");
                            Exercise.input();
                            Exercise.BubbleSortArray();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("BinarySearch");
                            Console.WriteLine("");
                            Exercise.input();
                            Exercise.BinarySearch();
                            break;
                    }
                }
            }
        }
    }
}
