/*
* Nguyen thanh luong
* tinh tien dien
*/

using System;

namespace cau11
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int nCSMoi = 0, nCSCu = 0, dienTieuThu = 0, tienTraDM=0, tienVuotDM = 0;

            //nhap 
            Console.Write("Nhap chi so cu: ");
            int.TryParse(Console.ReadLine(), out nCSCu);

            Console.Write("Nhap chi so moi: ");
            int.TryParse(Console.ReadLine(), out nCSMoi);

            //tinh
            dienTieuThu = nCSMoi - nCSCu;

            if(dienTieuThu >= 50){
                tienTraDM = dienTieuThu * 1000;
            }else {
                tienTraDM = 50 * 1000;
                tienVuotDM = dienTieuThu - 50;
                if(tienVuotDM <= 100){
                    tienVuotDM *= 1800;
                }else {
                    tienVuotDM = 100 * 1800 + (tienVuotDM - 100) * 2500;
                }
            }

            //xuat

            Console.WriteLine("muc dien tieu thu: {0}", dienTieuThu);
            Console.WriteLine("tien tra dinh muc: {0}", tienTraDM);
            Console.WriteLine("tien vuot dinh muc: {}", tienVuotDM);

            Console.ReadKey();
        }
    }
}
