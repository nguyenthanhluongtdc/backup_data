/*
 * Nguyen Thanh Luong
 * ngay 24/04/2021
 * in uoc so cua n
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch5_cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo
            int nN = 0;
            string uocSo = "";

            //nhap
            Console.Write("Nhap nN: ");
            int.TryParse(Console.ReadLine(), out nN);

            //tim uoc so cua nN
            for(int i = nN; i >= 2; i--)
            {
                if (nN % i == 0)
                {
                    uocSo += nN / i + "\t";
                }
            }

            //xuat uoc so cua nN
            Console.Write("\n*****Tat ca uoc so cua {0} la:\n {1}", nN, uocSo);

            Console.ReadKey();
        }
    }
}
