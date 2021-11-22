using System;

namespace cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            NhapSoNguyenDuong(ref n);
            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            Console.Write("Nhap thu nhat: ");
            nhapMang(ref arrOne);
            Console.Write("Nhap thu hai: ");
            nhapMang(ref arrTwo);

            Console.Write("Xuat mang thu nhat: "); inMang(arrOne);
            Console.Write("Xuat mang thu hai: "); inMang(arrTwo);
            Console.Write("Tong mang: "); inMang(TongMang(arrOne, arrTwo));
        }

        public static int NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

            return n;
        }

        public static void nhapMang(ref int[] arrInt)
        {
            for(int i = 0; i<arrInt.Length; i++)
            {
                Console.Write("arrDouble[{0}] = ", i);
                arrInt[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
        }

        public static int[] TongMang(int[] arrOne, int[] arrTwo){
            int[] arrResult = new int[arrOne.Length];

            for(int i =0; i<arrOne.Length; i++){
                arrResult[i] = arrOne[i] + arrTwo[i];
            }

            return arrResult;
        }
    }
}
