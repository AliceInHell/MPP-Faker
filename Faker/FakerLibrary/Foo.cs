using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerLibrary
{
    public class Foo
    {
        public int first;
        public int second;
        private int third;

        public int getThird()
        {
            return this.third;
        }

        public Foo(int f, int s, int t)
        {
            first = f;
            second = s;
            third = t;
        }
    }
}
