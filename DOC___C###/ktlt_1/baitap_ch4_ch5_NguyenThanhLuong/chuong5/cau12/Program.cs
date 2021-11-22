﻿/*
 * Nguyen Thanh Luong
 * ngay: 24/04/2021
 * in cac so nguyen to tu 2 - n
 */
using System;

namespace cau12
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

                for(int j = 2; j < i; j++){
                    if(i%j==0){
                        failed = true;
                        break;
                    }
                }

                if(!failed){
                    Console.Write(i+"\t");
                }

                failed = false;

            }

            Console.ReadKey();
        }
    }
}
