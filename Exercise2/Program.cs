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



                }
            }
        }
    }