using System;

namespace cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            NhapSoNguyenDuong();
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

       
    }
}
