using System;

namespace cau6
{
    class Program
    {
        static void Main(string[] args)
        {
           int nN = 0;
           NhapSoNguyenDuong(ref nN);

           Console.WriteLine
            ( 
               KiemTraHH(nN) 
               ? "La so hoan hao" 
               : "Khong phai la so hoan hao"
            );

            Console.WriteLine(LietKeSoHH(1, 1000));
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static bool KiemTraHH(int n){
            int tongUS = 0;

            for(int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                {
                    tongUS += n / i;
                }
            }

            return tongUS == n ? true : false;
        }

        public static string LietKeSoHH(int min, int max){
            
            string str = "So hoan hao " + min + "-" + max + " la:\t";
            int tongUS = 0;

            for(int i = min; i <= max; i++){
                for(int j = i; j >= 2; j--)
                {
                    if (i % j == 0)
                    {
                        tongUS += i / j;
                    }
                }

                if(tongUS == i){
                    str += i+"\t";
                }

                tongUS = 0;
            }

            return str;
        }

       
    }
}
