using System;

namespace cau11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            int lt = 1;
            int s = 0;
            Console.Write("Nhap x: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Nhap n: ");
            int.TryParse(Console.ReadLine(), out n);
            //Nhap gia tri x, n
            for(int i = 1; i <= n; i++){
                lt = lt * x;
                s += lt;
            }
            //Tinh s = x^1 + x^2 + .. + x^n
            Console.Write("ket qua= {0}", s);

            Console.ReadKey();
        }
    }
}
