using System;

namespace cau7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = 0;
            NhapSoNguyenDuong(ref nN);

            if(KiemTraSoDS(nN)){
                Console.WriteLine("La so doi xung");
            }else {
                Console.WriteLine("Khong phai la so doi xung");
            }

            Console.WriteLine(LietKeSoDX(1, 500));
            Console.WriteLine("Tong so doi xung: {0}",DemSoDX(1, 500));
        }

         public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static bool KiemTraSoDS(int n){
            string str = "";
            bool check = false;
            int temp = n;

            while(temp>=1){
                str += temp % 10;
                temp = temp / 10;
            }

            if(n==int.Parse(str)){
                check = true;
            }

            return check;
        }

        public static string LietKeSoDX(int min, int max){
            string str = "";
            
            for(int i = min; i<=max; i++){
                if(KiemTraSoDS(i)){
                    str += i + "\t";
                }
            }

            return str;
        }

        public static int DemSoDX(int min, int max){
            int dem = 0;
            for(int i = min; i<=max; i++){
                if(KiemTraSoDS(i)){
                    dem++;
                }
            }

            return dem;
        }
    }
}
