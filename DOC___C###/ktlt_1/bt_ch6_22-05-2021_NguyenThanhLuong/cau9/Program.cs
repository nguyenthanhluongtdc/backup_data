using System;

namespace cau9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            NhapSoNguyenDuong(ref num1, ref num2);

            Console.WriteLine("USCLN: {0}", UCLN(num1, num2));
            Console.WriteLine("BSCNN: {0}", BCNN(num1, num2));
        }

        public static void NhapSoNguyenDuong(ref int num1, ref int num2){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out num1);

            }while(num1 <= 0);

            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out num2);

            }while(num2 <= 0);
        }

        public static int UCLN(int num1, int num2)
        {
            while (num1 != 0 && num2 != 0)
            {
                if (num1 >= num2)
                    num1 = num1 % num2;
                else
                    num2 = num2 % num1;
            }

            return num1+num2; 
        }

        public static int BCNN(int num1, int num2)
        {
            int ucln = UCLN(num1, num2);
            return num1 * num2 / ucln;
        }
    }
}
