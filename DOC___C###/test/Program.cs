using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int[] arrUocSo = new int[0];

            timUocSo(10, ref arrUocSo);

            xuatMang(arrUocSo);
        }

        public static void xuatMang (int[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }

        public static void timUocSo(int number, ref int[] arrUocSo) {

            for(int i = 1; i <= number; i++) {
                if(number%i == 0) {
                    Array.Resize(ref arrUocSo, arrUocSo.Length+1);
                    arrUocSo[arrUocSo.Length-1] = i;
                } 
            }
        }
    }
}
