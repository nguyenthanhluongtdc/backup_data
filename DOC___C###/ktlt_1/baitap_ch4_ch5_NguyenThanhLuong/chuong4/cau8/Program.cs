/*
 * Ten: Nguyen thanh luong
 * ngay: 17/04/2021
 * in ra mau
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau8
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            string color = "", kq = "";

            //nhap
            Console.Write("nhap ky tu color: ");
            color = Console.ReadLine();

            //thuc hien
            switch (color)
            {
                case "R":
                case "r":
                    kq = "RED";
                    break;

                case "G":
                case "g":
                    kq = "GREEN";
                    break;

                case "B":
                case "b":
                    kq = "BLUE";
                    break;

                default:
                    kq = "BLACK";
                    break;
            }

            //xuat
            Console.Write(kq);

            Console.ReadKey();
        }
    }
}
