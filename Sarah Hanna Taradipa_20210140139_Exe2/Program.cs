using System;

namespace Exe2
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[32];
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
        }
    }
}
