﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.run();
        }
    }
    class Tester
    {
        public void run()
        {
            int doub;
            int trip;
            method(out doub, out trip);
            Console.WriteLine("Double: {0} Triple: {1}", doub, trip);
        }
        public void method(out int doub,out int trip)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            doub = num * 2;
            trip = num * 3;

        }
        // Again, capitalisation for method names.
        // Out variables are a feature of C# that we rarely actually use in production, as it usually makes things 
        // harder to read, and you can usually avoid them - it's good to know how they work though.
    }
}
