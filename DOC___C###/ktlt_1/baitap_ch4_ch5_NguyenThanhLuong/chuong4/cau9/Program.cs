/*
 * Ten: Nguyen Thanh Luong
 * ngay:17/04/2021
 * tinh + - * /
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau9
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            double num1 = 0, num2 = 0, kq = 0;
            int nChon = 0;

            //nhap
            Console.Write("Nhập num1: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Nhập num2: ");
            double.TryParse(Console.ReadLine(), out num2);

           
            
            Console.WriteLine("1. phep cong");
            Console.WriteLine("2. phep tru");
            Console.WriteLine("3. phep nhan");
            Console.WriteLine("4. phep chia");
            do
            {
                Console.WriteLine("******* Vui long lua chon phep tinh ben tren");
                int.TryParse(Console.ReadLine(), out nChon);
            } while (nChon < 1 || nChon > 4);

            //thuc hien
            switch (nChon)
            {
                case 1:
                    kq = num1 + num2;
                    break;

                case 2:
                    kq = num1 - num2;
                    break;

                case 3:
                    kq = num1 * num2;
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("Khong chia duoc");
                    }else
                    {
                        kq = num1 / num2;
                    }
                    
                    break;

                default:
                    break;
            }

            //xuat
            if (kq!=0)
            {
                Console.Write("Ket qua: {0}", kq);
            }

            Console.ReadKey();
        }
    }
}
