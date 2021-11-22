/*
* Nguyen thanh luong
* in so ngay trong thang
*/
using System;

namespace cau13
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int nThang = 0;

            //nhap
            Console.Write("Nhap thang: ");
            int.TryParse(Console.ReadLine(), out nThang);
            
            if(nThang == 1 || nThang == 3 || nThang == 5 || nThang == 7 || nThang == 8 || nThang == 10 || nThang == 12){
                Console.Write("Thang co 31 ngay");
            }else if(nThang > 12 && nThang !=2) {
                Console.Write("thang co 30 ngay");
            }else {
                if(nThang % 4 == 0 && nThang % 100 !=0){
                    Console.Write("thang co 29 ngay");
                }else {
                    Console.Write("thang co 28 ngay");
                }
            }

            Console.ReadKey();
        }
    }
}
