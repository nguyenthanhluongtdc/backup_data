using System;

namespace cau10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nguyen thanh luong
            */

            //khai bao bien
            int nN = 0;
            int dem = 0;

            //goi ham
            NhapSoNguyenDuong(ref nN);
            DemSoHoanHao(nN,ref dem);

            //xuat
            Console.WriteLine ("Tong so hoan hao <= {0} la: {1}", nN, dem);
        }

        //ham nhap
        public static void NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

        }

        // ham dem so luong so hoan hao
        public static void DemSoHoanHao(int n, ref int dem){
            int uocSo = 0;

            for(int i=1 ; i<=n; i++){
                for(int j = i; j >= 2; j--)
                {
                    if (i % j == 0)
                    {
                        uocSo += i/j;
                    }
                }

                if(uocSo == i){
                    dem++;
                }

                uocSo = 0;
            }
        }
    }
}
