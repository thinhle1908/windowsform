using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Numberic
    {
        public static List<string> uocCuaSo(string str)
        {
            int a = int.Parse(str);
            List<string> danhSachCacUoc = new List<string>();
            for (int i = 1;i < a; i++)
            {
                if(a % i == 0)
                {
                    danhSachCacUoc.Add(i.ToString());  
                }
            }

            return danhSachCacUoc;
        }
        public static string tongUocCacSo(string[]str)
        {
            int a = 0;
            int b = 0;
            foreach(string i in str)
            {
                a = int.Parse((string)i);
                b += a;
            }
            return $"Tong cua tat ca phan tu la: {b}";
        }
        public static string soLuongSoChan(string[] str)
        {
            int a = 0;
            int soLuongSoChan = 0;
            foreach (string i in str)
            {
               
                a = int.Parse((string)i);
                if(a % 2 == 0)
                {
                    soLuongSoChan++;
                }
                
            }
            return $"So luong so chan la :{soLuongSoChan}";
        }
        public static string soLuongUocCacSoNguyenTo(string[] str)
        {
            int a = 0;
            int count = 0;
            int soNguyenTo = 0;
            foreach (string i in str)
            {

                a = int.Parse((string)i);
                if (a != 1)
                {
                    for (int j = 1; j < a; j++)
                    {
                        if (a % j == 0)
                        {
                            count++;
                        }
                       
                    }
                }
                if(count == 1)
                {
                    soNguyenTo++;
                }
                count = 0;
            }
            return $"So luong uoc cac so nguyen to la :{soNguyenTo}";
        }
        public static string[] tang2DonViChoMoiPhanTu(string[]str)
        {
            for (int i = 0; i < str.Count(); i++)
            {
                str[i] =$"{ int.Parse(str[i])  + 2}";
            }
            return str;
        }
        public static string[] binhPhuong(string[] str)
        {
            for (int i = 0; i < str.Count(); i++)
            {
                str[i] = $"{Math.Pow(int.Parse(str[i]),2)}";
            }
            return str;
        }
    }
}
