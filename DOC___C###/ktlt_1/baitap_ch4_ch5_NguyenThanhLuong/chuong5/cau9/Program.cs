/*
 * Nguyen Thanh Luong
 * ngay 24/04/2021
 * ve tam gia vuong can
 */
using System;

namespace cau9
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;

            //nhap 
            Console.Write("nhap so nguyen: ");
            int.TryParse(Console.ReadLine(), out num);

            for(int i = 1; i <= num; i++){
                for(int j = 1; j<=i; j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
