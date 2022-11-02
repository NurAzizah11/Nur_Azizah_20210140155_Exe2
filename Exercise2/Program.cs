    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Exercise2
    {
    ////algoritma yang sesuai dengan intruksi method 1 adalah insertion sort
    class ProgramInsertion //(kelas untuk algoritma insertion)

    {
        //3 digit nim terakhir : 155
        //Deklarasi array int dengan ukuran maksimum 45 + 10 + 20 + 20 - 2 * 15 = 65 data
        //(Maksimal data yang bisa disimpan adalah 65 data)
        private decimal n;

        //deklarasi variable desimal untuk menyimpan banyaknya data pada array
        private decimal[] azizah = new decimal[65];
        private decimal temp;

        //membuat fungsi (method) untuk menerima masukan
        public void Input() // Merupakan method yang hanya melewatkan nilai / tidak mengembalikan nilai
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array.
            while (true)
            {
                //Menuliskan berapa banyak elemen 
                Console.Write("Masukkan banyaknya elemen pada array : ");
                //Disimpan ke dalam variabel s
                string s = Console.ReadLine();
                //Konversi agar terbaca desimal
                n = decimal.Parse(s);
                //Menggunakan code pengambilan keputusan if else 
                //Jika data <= 65 maka dilanjutkan
                if (n <= 65)
                    break;
                else;
                //Jika data lebih dari 65, maka outputnya "Array dapat mempunyai maksimal 65 elemen"
                Console.WriteLine("\nArray dapat mempunyai maksimal 65 elemen.\n");
            }
            ////Menampilkan bagian instruksi untuk memasukkan isi dari atas
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("---------------------");

            //code untuk memasukkan elemen pada array
            //Code akan berulang hingga nilai perulangan lebih kecil atau sama dengan nilai array yang telah dimasukkan di awal / pengguna memasukkan elemen pada array 
            for (int i = 0; i < n; i++)
            {
                //Code untuk memasukkan data
                Console.Write("<" + (i + 1) + ">");
                //Data yang tersimpan adalah string
                string s1 = Console.ReadLine();
                azizah[i] = (int)decimal.Parse(s1);
            }

        }

        //Method yang tidak mengembalikan nilai
        //Method untuk menampilkan array
        public void Tampil()
        {
            //menampilkan array yang tersusun 
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Elemen array telah tersusun");
            Console.WriteLine("---------------------------");

            //Menggunakan perulangan for untuk menampilkan nilai data yang sudah tersusun
            //Akan mengulang hingga perulangan sama dengan jumlah data

            for (int NA = 0; NA < n; NA++) ;
            {
                //Code untuk menuliskan data yang sudah berurut
                Console.WriteLine(Convert.ToDecimal(azizah[FA])));
            }
            Console.WriteLine("");
        }
        public void Insertionsortarray() //method untuk mengurutkan data dengan algoritma insertion sort 
        {
            //1. Repeat steps 2, 3, 4, and 5 varying i from 1 to n - 1
            for (int i = 1; i < n; i++)
            {
                //2. Set temp = arr[i]
                int NA = i - 1;
                //3. Set j = i - 1
                int NA = i - 1;
                //4. Repeat until j becomes less than 0 or arr[j] becomes less than or equal to temp;
                //a.Shift  the value at index j to index k + 1
                //b.Descrement j by 1
                while (NA >= 0 && azizah[NA] > temp)
                {
                    azizah[NA + 1] = azizah[NA];
                    NA = NA - 1;
                }
                //5.Store temp at index j +
                azizah[NA + 1] = temp;
            }
        }
    }


    //Kelas untuk algoritma kedua : merge sort
    class ClassMerge
    {
        //Deklarasi array int dengan ukuran maksimal 20 - 2 * 15 + 10 + 20 
        //(Maksimal data yang bisa disimpan adalah 65 data)
        private int[] azizah = new int[65];
        //Deklarasi array kedua (B) dengan batas data 65
        private int[] B = new int[65];
        //deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

    }

       

       
            
    