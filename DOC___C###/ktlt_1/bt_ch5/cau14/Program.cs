/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * in ra so dao nguoc
 */

using System;

namespace cau14
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;
            string str = "";
            
            //nhap
            Console.Write("nhap so nguyen: ");
            int.TryParse(Console.ReadLine(), out num);

            //thuc hien
            while(num>=1){
                str += num%10;
                num = num/10;
            }

            Console.WriteLine("So dao nguoc la: {0}",str);

            Console.ReadKey();
            
        }
    }
}
