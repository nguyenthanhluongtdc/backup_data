/*
*Nguyen thanh luong
*/

using System;

namespace cau4
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int n = 0;

            //nhap n
            NhapSoNguyenDuong(ref n);

            //xu ly
            int[] arrOne = new int[n];
            int[] arrB = new int[0];
            int[] arrC = new int[0];

            //xuat
            Console.Write("Nhap thu nhat: ");
            nhapMang(ref arrOne);

            Console.Write("Xuat mang thu nhat: "); 
            inMang(arrOne);
            createArrayOddEvent(arrOne, ref arrB, ref arrC);
            
            Console.Write("Xuat arrB: "); 
            inMang(arrB);

            Console.Write("Xuat arrC: "); 
            inMang(arrC);
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static void nhapMang(ref int[] arrInt)
        {
            for(int i = 0; i<arrInt.Length; i++)
            {
                Console.Write("arrDouble[{0}] = ", i);
                arrInt[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
        }

        public static void createArrayOddEvent(int[] arrA,ref int[] arrB,ref int[] arrC) {
            foreach(int item in arrA) {
                if(item % 2 == 0) {
                    Array.Resize(ref arrB, arrB.Length+1);
                    arrB[arrB.Length-1] = item;
                }else {
                    Array.Resize(ref arrC, arrC.Length+1);
                    arrC[arrC.Length-1] = item;
                }
            }
        }
    }
}
