using System;
using System.Collections.Generic;

namespace Collection_List_Dictionary
{
    class Program2
    {
        public static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void xuat(int[] a, int n)
        {
            Console.Write("Mang a[] : ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Moi ban nhap so phan tu cua mang a [] :");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[1000];
            
            nhap(a, n);
            xuat(a, n);

            Console.WriteLine();
            //List
            List<int> intList = new List<int>(a);
            Console.WriteLine("phan tu dau tien cua mang a = " + intList[0]);

            //Dictionary
            Dictionary<string, string> MyDicTest = new Dictionary<string, string>();
            MyDicTest.Add("go", "goodbye");
            MyDicTest.Add("pl", "playing");
            MyDicTest.Add("sd", "standing");

           
            foreach (KeyValuePair<string, string> item in MyDicTest)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }




        }
    }
}
