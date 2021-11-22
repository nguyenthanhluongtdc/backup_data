
/**
*Ten: nguyen thanh luong
*Ngay: 19/06/2021
*kiem tra ex3 (tim so hoan hao va xu ly so doi xung)
**/
using System;

namespace kiemtra_cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int[] arrA = new int[10];

            //nhap
            nhapMang(ref arrA);

            //xuat
            Console.WriteLine("\n=====Mang da nhap=====");
            inMang(arrA);

            //xuat danh sach so hoan hao
            Console.WriteLine("\n=====Danh sach so hoan hao: {0}",listHH(arrA));

            //xuat danh sach so doi xung
            Console.WriteLine("\n=====Danh sach so doi xung: {0}",listSDX(arrA));

            //xuat tong so doi xung
            Console.WriteLine("\n=====Tong so doi xung: {0}",sumSDX(arrA));

            //xuat Vị trí thứ 2 số đối xứng trong mảng
            Console.WriteLine("\n=====Vi tri thu 2 cua so doi xung: {0}",findSecondPositionSDX(arrA) != -1
                                                                    ? findSecondPositionSDX(arrA)
                                                                    : "Khong tim thay");

            //xuat số đối xứng chẵn trong mảng
            Console.WriteLine("\n=====Danh sach so doi xung chan: {0}", checkEvenSDX(arrA));

            Console.ReadKey();
        }

        //method nhap mang
        public static void nhapMang(ref int[] arrInt)
        {
            for(int i = 0; i<arrInt.Length; i++)
            {
                do {
                    Console.Write("arrDouble[{0}] = ", i);
                    arrInt[i] = int.Parse(Console.ReadLine());
                }while(arrInt[i] <= 0);
            }
        }

        //method xuat mang
        public static void inMang(int[] arrInt)
        {
            foreach(int d in arrInt)
            {
                Console.Write("{0}\t", d);
            }
            Console.WriteLine();
        }

        //method kiem tra so hoan hao
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

        //method kiem tra so doi xung
        public static bool KiemTraSoDX(int n){
            string str = "";
            bool check = false;
            int temp = n;

            if(n>10) {
                while(temp>=1){
                    str += temp % 10;
                    temp = temp / 10;
                }

                if(n==int.Parse(str)){
                    check = true;
                }
            }

            return check;
        }

        //danh sach so hoan hao trong mang
        public static string listHH(int[] arrInt){
            string str = "";
            foreach(int item in arrInt) {
                if(checkHH(item)){
                    str += item+"\t";
                }
            }

            return str;
        }

        //danh sach so doi xung trong mang
        public static string listSDX(int[] arrInt){
            string str = "";
            foreach(int item in arrInt) {
                if(KiemTraSoDX(item)){
                    str += item+"\t";
                }
            }

            return str;
        }

        //tong so doi xung
        public static int sumSDX(int[] arrInt) {
            int sum = 0;
            foreach(int item in arrInt) {
                if(KiemTraSoDX(item)){
                    sum += item;
                }
            }

            return sum;
        }

        //method tim vi tri so doi xung thu 2
        public static int findSecondPositionSDX(int[] arrInt) {
            int dem = 0;
            for(int i = 0; i < arrInt.Length; i++) {
                if(KiemTraSoDX(arrInt[i])){
                    dem++;
                    if(dem==2) {
                        return i;
                    }
                }
            }
            return -1;
        }

        //kiem tra so doi xung, chan
        public static string checkEvenSDX(int[] arrInt) {
            string str = "";
            foreach(int item in arrInt) {
                if(KiemTraSoDX(item) && item%2 == 0){
                    str += item+"\t";
                }
            }

            return str;
        }

    }
}
