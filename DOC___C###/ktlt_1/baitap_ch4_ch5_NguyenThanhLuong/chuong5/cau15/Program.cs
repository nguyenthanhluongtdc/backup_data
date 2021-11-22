/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * kiem tra so doi xung
 */

using System;

namespace cau15
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

            if(num == str){
                Console.WriteLine("la so doi xung");
            }else {
                Console.WriteLine("Khong phai la so doi xung");
            }

            Console.ReadKey();
            
        }
    }
}
