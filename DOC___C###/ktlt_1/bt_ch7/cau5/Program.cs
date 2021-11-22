/*
*Nguyen thanh luong
*/

using System;

namespace cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            //nhap n
            NhapSoNguyenDuong(ref n);

            //create array
            int[] arrInt = new int[n];

            //random array
            randomArr(ref arrInt);

            //xuat mang
            inMang(arrInt);

            //xuat max
            Console.Write("MAX = {0}\n", findMaxInArray(arrInt));

        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        //xuat mang
        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
            Console.WriteLine();
        }

        //random array
        public static void randomArr(ref int[] arrInt){
            Random random = new Random();
            for(int i = 0; i < arrInt.Length; i++){
                arrInt[i] = random.Next(0, 1000);
            }
        }

        //tim max in array
        public static int findMaxInArray(int[] arrInt) {
            int max = arrInt[0];
            for(int i = 1; i < arrInt.Length; i++){
                if(max < arrInt[i]) {
                    max = arrInt[i];
                }
            }
            return max;
        }
    }
}
