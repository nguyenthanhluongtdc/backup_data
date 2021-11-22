using System;

namespace cau8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            NhapSoNguyenDuong(ref nN);

            Console.WriteLine(Fibonaci(nN));
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }
        public static int Fibonaci(int n){
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
 
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
