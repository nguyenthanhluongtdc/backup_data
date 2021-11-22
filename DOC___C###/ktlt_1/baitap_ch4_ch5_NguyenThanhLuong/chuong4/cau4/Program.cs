/*
 * Nguyen Thanh Luong
 * Ngay 10/04/2021
 * tim so chan chia het cho 3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenThanhLuong_ch4_cau4
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;

            //nhap
            do
            {
                Console.Write("nhap num: ");
                int.TryParse(Console.ReadLine(), out num);
            } while (num < 0 || num > 100);

            //thuc hien va xuat
            Console.Write(num % 2 == 0 && num % 3 == 0 ? "La so chan chia het cho 3" : "Khong thoa dieu kien");

            Console.ReadKey();
        }
    }
}
