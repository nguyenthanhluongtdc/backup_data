using System;

namespace songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
            kiemTraSoNguyenTo(3);
        }

        public static void kiemTraSoNguyenTo(int number) {
            int bien_dem = 0;
            for (int i = 1; i <= number; i++){
                if (number % i == 0)
                    bien_dem++;
            }

            if (bien_dem == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");
        }
    }
}
