using System;

namespace cau11
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int nN = 0;
            string result = "";

            //goi ham
            NhapSoNguyenDuong(ref nN);
            inNSCP(nN, ref result);

            //xuats
            Console.WriteLine("{0} so chinh phuong dau tien: {1}", nN,result);
            
        }

        //ham nhap
        public static void NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

        }

        //ham in n so chinh phuong
        public static void inNSCP(int n, ref string result){
            for(int i = 1; i <= n; i++){
                result += i*i + "\t";
            }
        }
    }
}
