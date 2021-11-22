/*
 * Nguyen Thanh Luong 
 * Ngay 10/04/2021
 * in ra ket qua xep loai
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            double DTB = 0;
            string kq = "";

            //nhap
            
            do
            {
                Console.Write("Nhap DTB: ");
                double.TryParse(Console.ReadLine(), out DTB);

                //thuc hien
                kq = DTB >= 0 && DTB < 3
                    ? "Kem"
                    : DTB >= 3 && DTB < 5

                    ? "Yeu"
                    : DTB >= 5 && DTB < 6.5

                    ? "Trung binh kha"
                    : DTB >= 6.5 && DTB < 8

                    ? "Kha"
                    : DTB >= 8 && DTB < 9

                    ? "Gioi"
                    : DTB >= 9 && DTB < 10

                    ? "Xuat xac"
                    : "true";

            } while (kq == "true");

            //xuat
            Console.Write(kq);

            Console.ReadKey();
        }
    }
}
