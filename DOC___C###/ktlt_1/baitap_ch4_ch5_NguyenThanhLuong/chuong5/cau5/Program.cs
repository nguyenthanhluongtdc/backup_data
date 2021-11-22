﻿/*
 * Nguyen Thanh Luong
 * ngay 24/04/2021
 * kiem tra so hoan hao
 */
using System;

namespace cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo
            int nN = 0;
            int uocSo = 0;

            //nhap
            Console.Write("Nhap nN: ");
            int.TryParse(Console.ReadLine(), out nN);

            //tim uoc so cua nN
            for(int i = nN; i >= 2; i--)
            {
                if (nN % i == 0)
                {
                    uocSo += nN / i;
                }
            }

            if(uocSo == nN){
                Console.Write("la so hoan hao");
            }else {
                Console.Write("khong phai la so hoan hao");
            }

            //xuat uoc so cua nN

            Console.ReadKey();
        }
    }
}
