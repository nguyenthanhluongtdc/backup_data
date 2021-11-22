/*
 * Nguyen thanh Luong
 * Ngay 10/4/2021
 * Giai phuong trinh bat nhat
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int numA = 0, numB = 0;

            //nhap
            Console.Write("Nhap a: ");
            int.TryParse(Console.ReadLine(), out numA);

            Console.Write("Nhap b: ");
            int.TryParse(Console.ReadLine(), out numB);

            //thuc hien
            Console.WriteLine( numA == 0 ? "Phuong trinh vo nghiem" : (-numB / numA).ToString() );

            Console.ReadKey();

            //xuat

        }
    }
}
