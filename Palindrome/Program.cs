using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your word:");
            string word = Console.ReadLine();

            Console.WriteLine(Plndrm(word));
            Console.ReadLine();
        }
        public static bool Plndrm(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = word[i];
                char b = word[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
    }
}
