using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_TinhToan
{
    class Program
    {
        static string a, b;
        static char tt = ' ';
        static int A, B;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Kiem tra nhap vao co phai la so
            do
            {
                if (a == null || b == null)
                {
                    CheckInput_So();
                }
                else
                {
                    Console.WriteLine("Vui long nhap lai A,B: ");
                    CheckInput_So();
                }
            } while (int.TryParse(a, out A) == false || int.TryParse(b, out B) == false);


            //Kiem tra cong thuc nhap vao dung/sai
            do
            {
                if (tt == ' ')
                {
                    CheckInput_CongThuc();
                }
                else
                {
                    Console.Write("Vui long nhap lai cong thuc: ");
                    CheckInput_CongThuc();
                }
            } while ((tt != ' ') && (tt != '+') && (tt != '-') && (tt != '*') && (tt != '/'));

            //Cac phep tinh/xuat ra ket qua
            ResultOut();
            Console.ReadKey();
        }
        //Ket thuc ham main!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        //Kiem tra nhap vao co phai la so
        static void CheckInput_So()
        {
            Console.Write("Nhập A: ");
            a = Console.ReadLine();
            Console.Write("Nhập B: ");
            b = Console.ReadLine();
        }
        //Kiem tra cong thuc nhap vao
        static void CheckInput_CongThuc()
        {
            Console.Write("Cong thuc: ");
            tt = char.Parse(Console.ReadLine());
        }
        //Cac phep tinh/xuat ra ket qua
        static void ResultOut()
        {
            switch (tt)
            {
                case '+': Console.Write("Ket qua: " + (A + B));
                    break;
                case '-': Console.Write("Ket qua: " + (A - B));
                    break;
                case '*': Console.Write("Ket qua: " + (A * B));
                    break;
                case '/': Console.Write("Ket qua: " + (A / B));
                    break;
            }
        }
    }
}
