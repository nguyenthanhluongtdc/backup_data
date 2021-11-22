using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = KiemTraSoNguyenTo(97);
            if(check) {
                Console.WriteLine("la so nguyen to");
            }else {
                Console.WriteLine("khong phai la so nguyen to");
            }
        }

        public static bool kiemTraSoNguyenTo(int n){
            if(n==1 || n<=0) 
                return false;

            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0) 
                    return false;
            }

            return true;
        }

        public static bool kiemTraSoChinhPhuong(int n){
            for(int i = 1; i <= n/2; i++)
            {
                if(i*i == n)
                    return true;
            }

            return false;
        }

        public static bool kiemTraSoHoanHao(int number) {
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n) return true;
            else return false;
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

        public static bool kiemTraSoDoiXung(int n){
            string str = "";
            int temp = n;

            while(temp>=1){
                str += temp % 10;
                temp = temp / 10;
            }

            if(n==int.Parse(str)){
                return true;
            }

            return false;
        }
    }
}
