﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("i am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine(age);
            
        }
    }
}
