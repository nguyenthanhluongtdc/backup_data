/*
 * Ten: Nguyen Thanh Luong
 * Ngay 17/04/2021
 * kiem tra thang 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau7
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo biến
            int num = 0;
            string kq = "";

            //nhập
            Console.Write("Nhap thang: ");
            int.TryParse(Console.ReadLine(), out num);

            //thực hiện
            if(num < 0 || num > 12)
            {
                kq = "thang khong hop le";
            }else
            {
                if(num < 4)
                {
                    kq = "quy 1";
                }else if(num < 7)
                {
                    kq = "quy 2";
                }else if(num < 10)
                {
                    kq = "quy 3";
                }else
                {
                    kq = "quy 4";
                }
            }

            //xuất
            Console.WriteLine(kq);

            Console.ReadKey();
        }
    }
}
