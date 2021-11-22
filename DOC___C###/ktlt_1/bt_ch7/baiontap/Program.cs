using System;

namespace baiontap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            NhapSoNguyenDuong(ref n, "so nguyen duong");
            int[] arr = new int[n];

            randomArr(ref arr);
            inMang(arr);

            // inMang(xuatSNTInArray(arr));

            // Console.WriteLine("TBC: {0}", tinhTBCInArray(arr));

            // Console.WriteLine("so luong HH: {0}", amountHH(arr));

            NhapSoNguyenDuong(ref x, "x");
            Console.WriteLine("Vi tri cuoi cung cua {0} trong mang la: {1}", x, findLastPositionX(arr, x)==-1
                                                                                ?"khong tim thay"
                                                                                :findLastPositionX(arr, x));

            Console.WriteLine("Vi tri thu 3 cua {0} la: {1}", x, findThreePositionX(arr, x)==-1
                                                                ?"khong tim thay"
                                                                :findThreePositionX(arr, x));

            Console.WriteLine("Vi tri SNT dau tien: {0}", findFirstPositionSNT(arr));
        }

        public static void NhapSoNguyenDuong(ref int n, string str){
            do{
                Console.Write("Nhap {0}: ", str);
                int.TryParse(Console.ReadLine(), out n);

            }while(n <= 0);

        }

        public static void randomArr(ref int[] arrInt){
            Random random = new Random();
            for(int i = 0; i < arrInt.Length; i++){
                arrInt[i] = random.Next(1, 10);
            }
        }

        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
            Console.WriteLine();
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

        public static float tinhTBCInArray(int[] arr) {
            int tong = 0;
            foreach(int item in arr) {
                tong +=item;
            }

            return (float)tong/arr.Length;
        }

        public static bool checkHH(int n){
            int tongUS = 0;

            bool kqua = false;

            for(int i = n/2; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    tongUS += i;
                }
            }

            if(tongUS==n){
                kqua = true;
            }

            return kqua;
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

        public static int amountHH(int[] arr) {
            int demHH = 0;
            foreach(int item in arr) {
                if(checkHH(item)) {
                    demHH++;
                }
            }

            return demHH;
        }

        public static int findLastPositionX(int[] arr, int x){
            for(int i = arr.Length-1; i >= 0; i--) {
                if(arr[i] == x) {
                    return i;
                }
            }

            return -1;
        }

        public static int findThreePositionX(int[] arr, int x){
            int dem = 0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == x) {
                    dem++;
                    if(dem==3) return i;
                }
            }
            return -1;
        }

        public static int findFirstPositionSNT(int[] arr){
            int i = 0;
            foreach(int item in arr) {
                if(kiemTraSoNguyenTo(item)){
                    return i;
                }
                i++;
            }
            return -1;
        }

        // public static int findThreePositionX2(int[] arr, int x, int i, int dem){
        //     if(arr.Length==i){
        //         return -1;
        //     }

        //     if(arr[i]==x){
        //         dem++;
        //         if(dem==3) return i;
        //     }

        //     return findLastPositionX(arr, x, i++, dem);
        // }
    }

}
