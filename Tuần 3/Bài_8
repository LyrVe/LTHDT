using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_8
{
    class program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string text;
            char[] arr;

            Console.WriteLine("Nhập chuỗi để chuyển chữ hoa thành chữ thường:");
            text = Console.ReadLine();
            arr = text.ToCharArray(0, text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLower(arr[i]))
                {
                    Console.Write(char.ToLower(arr[i]));
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
