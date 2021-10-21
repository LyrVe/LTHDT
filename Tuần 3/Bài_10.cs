using System;

namespace Bài_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string text;
            char[] arr;
            int count_space = 0, count_char = 0;

            Console.WriteLine("Nhập xâu:");
            text = Console.ReadLine();
            int length = text.Length;
            arr = text.ToCharArray(0, length);

            for (int i = 0; i < length; i++)
            {
                if (char.IsWhiteSpace(arr[i]))
                {
                    if (i == 0 || i == length - 1)
                    {
                        delete(ref arr, i);
                    }
                    count_space++;
                    count_char = 0;
                    if (count_space >= 2)
                    {
                        delete(ref arr, i);
                    }
                }
                else
                {
                    count_char++;
                    if (count_char == 1)
                    {
                        arr[i] = char.ToUpper(arr[i]);
                    }
                    count_space = 0;
                }
            }
            print(arr, length);
            Console.ReadKey();
        }
        static void delete(ref char[] arr, int n)
        {
            arr[n] = '\0';
        }

        static void print(char[] arr, int length)
        {
            Console.WriteLine("Xâu hoàn chỉnh:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
