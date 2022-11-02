﻿using System;

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

            }
        }
    }
}
