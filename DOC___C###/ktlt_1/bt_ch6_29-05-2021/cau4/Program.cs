using System;

namespace cau4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            NhapSoNguyenDuong(ref nN);

            if(KiemTraSoNguyenTo(nN)==1){
                Console.WriteLine("{0} La so nguyen to", nN);
            }else {
                Console.WriteLine("{0} Khong phai la so nguyen to", nN);
            }
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static int KiemTraSoNguyenTo(int n){
            int kq = 1;

            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    kq = 0;
                    break;
                }
            }

            return kq;
        }
    }
}
