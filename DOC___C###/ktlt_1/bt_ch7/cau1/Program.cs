/*
*Nguyen thanh luong
*/

using System;

namespace cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            
            int nN = 0;
            //int max = 0;
            int min = -1;
           // int position = -1;
            // float tbc = 0;
            // string result = "";
            NhapSoNguyenDuong(ref nN);

            int[] myArrInt = new int[nN];
            
            //nhap, xuat mang
            Console.WriteLine("nhap mang");
            nhapMang(ref myArrInt);
            
            Console.Write("mang vua nhap:  ");
            inMang(myArrInt);

            // arrSNT(myArrInt, ref result);
            // Console.WriteLine("So nguyen to: {0}", result);

            // TBC(myArrInt, ref tbc );
            // Console.WriteLine("TBC: {0}", tbc);


            // Console.WriteLine(
            //     ArrPositionSNT(myArrInt)!=-1
            //     ? "Vi tri SNT dau tien: {0}" 
            //     : "Khong tim thay"
            //     , ArrPositionSNT(myArrInt)
            //     );

            // tim phan tu max trong mang
            // max = ArrMax(myArrInt,ref position);
            // Console.WriteLine("Max = {0}", max);

            // Console.WriteLine(
            //     position != -1
            //         ? "Vi tri: {0}" 
            //         : "Khong tim thay"
            //         , position
            //     );

            min = PositiveMin(myArrInt);
            Console.WriteLine(
                min > 0
                ? "Min duong: {0}" 
                : "Khong tim thay min duong"
                , min
                );

            // Console.WriteLine("Mang da sap xep");
            // inMang(SortArr(myArrInt));


            Console.WriteLine(
                    KiemTraMangTang(myArrInt) 
                    ? "-- Mang tang"
                    : "-- Mang khong tang"
                );
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
                Console.WriteLine("{0}\t", d);
            }
        }

        //kiem tra so nguyen to
        public static int KiemTraSoNguyenTo(int n){
            int kq = 1;

            if(n == 1){
                return 0;
            }

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

        //tim so nguyen to
        public static void arrSNT(int[] arrInt, ref string result){
           
            foreach(int item in arrInt){
                
                if(KiemTraSoNguyenTo(item) == 1){
                    result += item+"\t";
                }
            }

        }

        //tinh trung binh cong
        public static void TBC(int[] arrInt, ref float tbc){
            int tong = 0;

            foreach(int item in arrInt){
                tong +=item;
            }
            tbc = (float) tong / arrInt.Length;
        }

        //lay vi tri so nguyen to dau tien trong mang
        public static int ArrPositionSNT(int[] arrInt){
           
            for(int i = 0; i < arrInt.Length; i++){
                
                if(KiemTraSoNguyenTo(arrInt[i]) == 1){
                    return i;
                }
            }

            return -1;
        }

        //tim max trong mang
        public static int ArrMax(int[] arrInt, ref int position) {
            int max = arrInt[0];

            for(int i = 0; i < arrInt.Length; i++){
                if(arrInt[i] > max) {
                    max = arrInt[i];
                    position = i;
                }
            }

            return max;
        }

        //tim so duong nho nhat
        public static int PositiveMin(int[] arrInt) {
            int min = arrInt[0];
            foreach(int item in arrInt) {
                if(item < min && item > 0) {
                    min = item;
                }
            } 

            return min;
        }

        public static int[] SortArr(int[] arrInt){
            int min = 0;
            for(int i = 0; i < arrInt.Length; i++) {
                min = arrInt[i];
                for(int j = i+1; j < arrInt.Length; j++) {
                    if(min > arrInt[j]){
                        min = arrInt[j];
                    }
                }
                arrInt[i] = min;
            }
            return arrInt;
        }

        public static bool KiemTraMangTang(int[] arrInt)
        {
            int temp = arrInt[0];
            
            for(int i = 1; i < arrInt.Length; i++){
                if(temp > arrInt[i]){
                    return false;
                }
                temp = arrInt[i]; 
            }

            return true;
        }
    }
}
