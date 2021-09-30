using System;
using System.Collections.Generic;

namespace Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var psw = new PasswordChecker(6,
            new List<char>() {
                '&', '!', '#', '$', '%', '\'', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~', '.'
            });

            psw.IsValid("Pass#.");

        }
    }
}
