/*
 * Tên: Nguyen Thanh Luong
 * Ngay: 17/04/2021
 * Kiem tra ket qua thi dau
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau6
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo biến
            int toan = 0, ly = 0, hoa = 0, sum = 0;
            string kq = "";

            //nhập
            Console.Write("Nhap toan: ");
            int.TryParse(Console.ReadLine(), out toan);

            Console.Write("Nhap ly: ");
            int.TryParse(Console.ReadLine(), out ly);

            Console.Write("Nhap hoa: ");
            int.TryParse(Console.ReadLine(), out hoa);

            //thực hiện
            sum = toan + ly + hoa;
            if(sum > 15 || toan > 4 ||ly > 4 || hoa > 4)
            {
                kq = "thi hong";
            }else
            {
                if(toan < 5 || ly < 5 || hoa < 5)
                {
                    kq = "đậu, hoc chua deu cac mon";
                }else
                {
                    kq = "đậu, hoc deu cac mon";
                }
            }

            //xuất
            Console.WriteLine(kq);

            Console.ReadKey();
        }
    }
}
