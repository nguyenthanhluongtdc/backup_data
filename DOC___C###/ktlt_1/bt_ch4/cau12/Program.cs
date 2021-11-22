/*
* Nguyen thanh luong
* kiem tra ky tu
*/
using System;

namespace cau12
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao vien
            char cKyTu;
            
            //nhap
            Console.Write("nhap 1 ky tu: ");
            cKyTu = Console.ReadLine()[0];

            if(cKyTu >= 'A' && cKyTu <= 'Z'){
                Console.Write("A-Z");
            }else if(cKyTu >= 'a' && cKyTu <= 'z'){
                Console.Write("a-z");
            }else if(cKyTu >= '0' && cKyTu <= '9'){
                Console.Write("0-9");
            }else {
                Console.Write("ky tu khac");
            }

            Console.ReadKey();
        }
    }
}
