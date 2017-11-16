using System;
using System.Collections;
using System.Collections.Generic;

namespace EasySorting
{
    internal class CompareName : IComparer<Model>
    {
        public int Compare(Model m1, Model m2)
        {
            return m1.Navn.CompareTo(m2.Navn);
        }
    }
    internal class CompareShoeUp : IComparer<Model>
    {
        public int Compare(Model m1, Model m2)
        {
            return m1.Sko.CompareTo(m2.Sko);
        }
    }
    internal class CompareShoeDown : IComparer<Model>
    {
        public int Compare(Model m2, Model m1)
        {
            return m1.Sko.CompareTo(m2.Sko);
        }
    }
}