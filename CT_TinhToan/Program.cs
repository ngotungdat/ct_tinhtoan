using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string a, b;
            char tt = ' ';
            int A, B;

            //Kiem tra nhap vao co phai la so
            do
            {
                Console.Write("Nhập A: ");
                a = Console.ReadLine();
                Console.Write("Nhập B: ");
                b = Console.ReadLine();       
            } while (int.TryParse(a, out A) == false || int.TryParse(b, out B) == false);
            
            //Kiem tra cong thuc nhap vao dung/sai
            do
            {
                if (tt == ' ')
                {
                    Console.Write("Cong thuc: ");
                    tt = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Vui long nhap lai cong thuc: ");
                    tt = char.Parse(Console.ReadLine());
                }
            } while ((tt != ' ') && (tt != '+') && (tt != '-') && (tt != '*') && (tt != '/'));

            //Cac phep tinh/xuat ra ket qua
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

            Console.ReadKey();
        }
    }
}
