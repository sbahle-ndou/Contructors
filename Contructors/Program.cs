﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Porter", "JK Rowling", 400);
            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
