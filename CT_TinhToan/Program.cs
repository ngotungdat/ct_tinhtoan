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
            Console.Write("Nhập A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Công thức (+ - * /): ");
            string tt = Console.ReadLine();

            while (tt == " " && tt != "+" == true && tt != "-" == true && tt != "*" == true && tt != "/" == true)
            {
                Console.Write("Vui lòng nhập lại công thức! ");
                tt = Console.ReadLine();
            }
            switch (tt)
            {
                case "+": Console.Write("Ket qua: " + (a + b));
                    break;
                case "-": Console.Write("Ket qua: " + (a - b));
                    break;
                case "*": Console.Write("Ket qua: " + (a * b));
                    break;

                case "/": Console.Write("Ket qua: " + (a / b));
                    break;
                default:
                    Console.Write("Cong thuc nhap vao khong chinh xac!");
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
