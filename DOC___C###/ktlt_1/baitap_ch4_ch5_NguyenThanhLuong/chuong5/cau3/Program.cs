/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * kiem tra so nguyen to
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch5_cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao
            int nN = 0;
            bool failed = false;

            //nhap
            Console.Write("Nhap nN: ");
            int.TryParse(Console.ReadLine(), out nN);

            //kiem tra so nguyen to
            for(int i = 2; i < nN; i++)
            {
               if(nN % i == 0)
                {
                    failed = true;
                    break;
                }
            }

            //xuat
            Console.Write(
                            (failed
                                ? "{0} Khong phai la"
                                : "{0} la"  
                            ) 
                            + " so nguyen to", nN
                         );

            Console.ReadKey();
        }
    }
}
