using System;

namespace cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            int tongUS = 0;
            int demUS = 0;

            NhapSoNguyenDuong(ref nN);
            DemUS(nN, ref demUS);
            TongUS(nN, ref tongUS);

            Console.WriteLine("Tong US cua {0} la: {1}",nN,tongUS);
            Console.WriteLine("So luong US cua {0} la: {1}",nN,demUS);
        }


         public static void NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

        }

         public static void DemUS(int n, ref int dem){

            for(int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                {
                   dem++;
                }
            }
        }

        public static void TongUS(int n, ref int tongUS){
            for(int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                {
                    tongUS += n / i;
                }
            }
        }
    }
}
