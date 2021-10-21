using System;
using static System.Math;

namespace Learning_.NET
{
    class Program
    {
        

        //1: ham liet ke uoc so cua n;
        public static void lietKe(uint n)
        {
      
            Console.WriteLine("Uoc so cua so " + n + " : ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

       

        //2: ham dem chu so cua n;
        public static void demSo(uint n)
        {

            uint temp = 0;
            uint x = n;
            while (n > 0)
            {
                n = n / 10;
                temp++;
            }
            Console.WriteLine("So " + x + " co " + temp + " chu so ");

        }
        //3: ham kiem tra so doi xung n;
        public static void SoDoiXung(uint n)
        {
            uint temp, r, SoDaoNguoc = 0;
            for (temp = n; n != 0; n = n / 10)
            {
                r = n % 10;
                SoDaoNguoc = SoDaoNguoc * 10 + r;
            }
            if (temp == SoDaoNguoc)
            {
                Console.WriteLine(temp + " la so doi xung");
            }
            else
            {
                Console.WriteLine(temp + " khong la so doi xung");
            }
        }
        //4 : ham kiem tra so chinh phuong;
        public static void SoChinhPhuong(uint n)
        {
            uint temp = n;
            double x = 0;
            x = x + (Math.Sqrt(n));
            if (x * x == temp)
            {
                Console.WriteLine(temp + " la so chinh phuong.");
            }
            else
            {
                Console.WriteLine(temp + " khong phai so chinh phuong.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ");
            uint n;
            Console.WriteLine("Moi ban nhap so n :");
            n = Convert.ToUInt32(Console.ReadLine());
            
            lietKe(n);
            demSo(n);
            SoDoiXung(n);
            SoChinhPhuong(n);

        }
    }
}
