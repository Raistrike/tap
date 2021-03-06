﻿using System;
using MyAttribute;

namespace MyLibrary
{
    public class Foo
    {
        [ExecuteMe]
        public void M1()
        {
            Console.WriteLine("M1");
        }

        [ExecuteMe(45)]
        [ExecuteMe(0)]
        [ExecuteMe(3)]
        public void M2(int a)
        {
            Console.WriteLine("M2 a={0}", a);
        }

        [ExecuteMe("hello", "reflection")]
        public void M3(string s1, string s2)
        {
            Console.WriteLine("M3 s1={0} s2={1}", s1, s2);
        }

        [ExecuteMe]
        public void MTest()
        {
            Console.WriteLine("MTest");
        }

        [ExecuteMe("tre")]
        [ExecuteMe]
        public void M1024(int i)
        {
            Console.WriteLine("M1024 i={0}",i);
        }
    }
}