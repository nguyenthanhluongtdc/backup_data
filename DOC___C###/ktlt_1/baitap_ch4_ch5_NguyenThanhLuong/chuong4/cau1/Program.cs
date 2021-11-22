/*
 * Nguyen thanh Luong
 * Ngay: 10/4/2021
 * tim max
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_Ch4_Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int numA = 0, numB = 0, numC = 0, numD = 0, max = 0;

            //nhap
            Console.Write("Nhap a: ");
            int.TryParse(Console.ReadLine(), out numA);

            Console.Write("Nhap b: ");
            int.TryParse(Console.ReadLine(), out numB);

            Console.Write("Nhap c: ");
            int.TryParse(Console.ReadLine(), out numC);

            Console.Write("Nhap d: ");
            int.TryParse(Console.ReadLine(), out numD);

            //thuc hien
            max = numA < numB ? numB : numA;
            max = max < numC ? numC : max;
            max = max < numD ? numD : max;

            //xuat
            Console.WriteLine("Max = {0}",max);

            Console.ReadKey();
        }
    }
}
