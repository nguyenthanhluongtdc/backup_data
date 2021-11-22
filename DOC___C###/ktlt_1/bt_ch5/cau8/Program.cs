﻿/*
 * Nguyen Thanh Luong
 * ngay 24/04/2021
 * in bang cuu chuong
 */
using System;

namespace cau8
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num =0;
        
            //nhap
            Console.Write("nhap so nguyen: ");
            int.TryParse(Console.ReadLine(), out num);

            //xuat
            for(int i = 1; i <=10 ; i++){
                Console.Write("{0}x{1} = {2}",num,i,num*i);
            }

            Console.ReadKey();
        }
    }
}
