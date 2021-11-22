/*
*Nguyen thanh luong
*/

using System;

namespace cau7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;

            NhapSoNguyenDuong(ref n);
            int[] arr = new int[n];

            randomArr(ref arr);
            inMang(arr);

            NhapSoNguyenDuong(ref x);
            RemoveValueArr(ref arr, x);
            inMang(arr);

            NhapSoNguyenDuong(ref x);
            replaceValue(ref arr, x);
            inMang(arr);

            Console.WriteLine("xuat so nguyen to trong mang: ");
            inMang(xuatSNTInArray(arr));
        }

        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
            Console.WriteLine();
        }


         public static void NhapSoNguyenDuong(ref int n){
            do{
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

        }

        public static bool kiemTraSoNguyenTo(int number) {
            int bien_dem = 0;
            for (int i = 1; i <= number; i++){
                if (number % i == 0)
                    bien_dem++;
            }

            if (bien_dem == 2)
               return true;
            else
                return false;
        }

        public static void randomArr(ref int[] arrInt){
            Random random = new Random();
            for(int i = 0; i < arrInt.Length; i++){
                arrInt[i] = random.Next(1, 100);
            }
        }

        public static void RemoveValueArr(ref int[] arr, int x){
            for(int i = 0; i < arr.Length; i++) {
                if(arr[i] == x) {
                    if(i==arr.Length-1){
                        Array.Resize(ref arr, arr.Length-1);
                    }else {
                        for(int j = i; j <arr.Length-1; j++) {
                            arr[j] = arr[j+1];
                        }
                        Array.Resize(ref arr, arr.Length-1);
                    }
                }
                
            }
        }

        public static int KiemTraSoNguyenTo(int n){
            int kq = -1;

            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    kq = 0;
                    break;
                }
            }

            return kq;
        }

        public static void replaceValue(ref int[] arr, int x) {
            for(int i = 0; i < arr.Length; i++) {
                if(kiemTraSoNguyenTo(arr[i])) {
                   Array.Resize(ref arr, arr.Length+1);
                    for(int j = arr.Length-1; j > i; j--) {
                        arr[j] = arr[j-1];
                    }
                    arr[i] = x;
                    break;
                }
            }
        }

        public static int[] xuatSNTInArray(int[] arr) {
            int[] arrSNT = new int[0];
            for(int i = 0; i < arr.Length; i++) {
                if(kiemTraSoNguyenTo(arr[i])) {
                   Array.Resize(ref arrSNT, arrSNT.Length+1);
                   arrSNT[arrSNT.Length-1] = arr[i];
                }
            }

            return arrSNT;
        }

    }
}
