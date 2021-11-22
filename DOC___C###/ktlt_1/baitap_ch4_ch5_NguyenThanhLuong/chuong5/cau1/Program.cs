/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * tinh gia tri khi nhap n
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch5_cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao
            int nN = 0;
            int kQua = 1;
            string sChon = "";

            //Nhap 
            Console.Write("Nhap nN= ");
            int.TryParse(Console.ReadLine(), out nN);

            Console.WriteLine("A = Tinh tong cac so le nho hon hay bang nN");
            Console.WriteLine("B = Tich boi so cua 3 nho hon hoac bang nN");

            //nhap lua chon va kiem tra
            do
            {
                Console.WriteLine("Vui long chon A | B");
                sChon = Console.ReadLine();

            } while (sChon != "A" && sChon != "B" && sChon != "a" && sChon != "b");

            //lua chon
            switch (sChon)
            {
                //tinh tong le 
                case "a":
                case "A":
                    for(int i = 1; i <= nN; i += 2)
                    {
                        kQua += i;
                    }
                    break;

                //tinh boi cua 3
                case "b":
                case "B":
                    for(int i = 3; i <= nN; i+=3)
                    {
                        kQua = kQua * i;
                    }

                    //hoac
                    //for (int i = 1; i * 3 <= nN; i++)
                    //{
                    //    kQua = kQua * i * 3;
                    //}
                    break;

                default:
                    Console.Write("Ban lua chon sai ");
                    break;
            }

            //xuat ra ket qua
            Console.WriteLine(sChon == "A" || sChon == "a" 
                                ? "Tong le <=nN la: {0}" 
                                : "Tich boi cua 3 <=nN la: {0}", kQua);

            Console.ReadKey();
        }
    }
}
