﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullAndRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Push > Pull > RollBack > Branching");
            Console.WriteLine("New line added to pull to local from remote");
            Console.WriteLine("Another line added");

            Console.WriteLine("This line will be appeared on new branch");
            Console.ReadKey();
        }
    }
}
