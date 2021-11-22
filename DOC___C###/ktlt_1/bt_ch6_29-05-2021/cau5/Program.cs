using System;

namespace cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            NhapSoNguyenDuong(ref nN);

            if(KiemTraSoCP(nN)){
                Console.WriteLine("{0} La so chinh phuong", nN);
            }else {
                Console.WriteLine("{0} Khong phai la so chinh phuong", nN);
            }
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static bool KiemTraSoCP(int n){
            for(int i = 1; i <= n/2; i++)
            {
                if(i*i == n)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
