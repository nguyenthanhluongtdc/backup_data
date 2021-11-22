using System;

namespace sochinhphuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
