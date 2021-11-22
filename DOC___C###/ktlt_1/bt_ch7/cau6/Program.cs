/*
*Nguyen thanh luong
*/

using System;

namespace cau6
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int[] arrA = new int[300];
            int[] arrB = new int[200];
            int[] arrC = new int[200];

            //xu ly
            randomArray(ref arrA);
            createArrB_C(arrA, ref arrB, ref arrC);

            //create mang
            Console.WriteLine("mang A:");
            inMang(arrA);

            Console.Write("Mang B: ");
            
            inMang(arrB);
            
            Console.WriteLine("Mang C: ");
            inMang(arrC);

            Console.ReadKey();
        }

        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
        }

        public static void randomArray(ref int[] arrA) {
             Random random = new Random();
            for(int i = 0; i < 200; i++) {
                arrA[i] = random.Next(-100, 100);
            }
        }

        public static void createArrB_C(int[] arrA, ref int[] arrB, ref int[] arrC) {
            for(int i = 0; i < arrA.Length; i++) {
                if(arrA[i] >= 0) {
                    Array.Resize(ref arrA, arrA.Length+1);
                    arrB[arrB.Length - 1] = arrA[i];
                }else {
                    Array.Resize(ref arrB, arrB.Length+1);
                    arrC[arrC.Length - 1] = arrA[i];
                }
            }
        }
    }
}
