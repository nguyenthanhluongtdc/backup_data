/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * kiem tra so chinh phuong
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch5_cau4
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao
            int nN = 0;
            bool failed = true;

            //nhap
            Console.Write("Nhap nN: ");
            int.TryParse(Console.ReadLine(), out nN);

            //kiem tra so chinh phuong
            for(int i = 1; i <= nN; i++)
            {
                if(i*i == nN)
                {
                    failed = false;
                    break;
                }
            }

            //xuat
            Console.Write(
                            (failed 
                                ? "{ 0} khong la" 
                                : "{0} la"
                            ) 
                            + " so chinh phuong", nN
                         );

            Console.ReadKey();
        }
    }
}
