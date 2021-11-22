using System;

namespace cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DemUS(6));
            Console.WriteLine(TongUS(6));
        }

        public static int DemUS(int n){

            int dem = 0;

            for(int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                {
                   dem++;
                }
            }

            return dem;
        }

        public static int TongUS(int n){
            int tongUS = 0;
            for(int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                {
                    tongUS += n / i;
                }
            }

            return tongUS;
        }
    }
}
