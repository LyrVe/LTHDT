using System;

namespace Bài_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string text;
            char[] arr;
            int count_word = 0, count_space = 0, count_char = 0;
            
            Console.WriteLine("Nhập xâu:");
            text = Console.ReadLine();
            arr = text.ToCharArray(0, text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(arr[i]))
                {
                    count_space++;
                    count_char = 0;
                } 
                else
                {
                    count_char++;
                    count_space = 0;
                }
                if (count_space == 0 && count_char == 1)
                {
                    count_word++;
                }
            }
            Console.WriteLine("Số từ trong xâu là {0}", count_word);
            Console.ReadKey();
        }
    }
}
