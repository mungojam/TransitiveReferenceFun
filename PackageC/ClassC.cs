using System;
using PackageB;

namespace PackageC
{
    public static class ClassC
    {
        public static int AddB(int a, int b)
        {
            return ClassB.Add(a, b);
        }

        public static int AddB2(int a, int b)
        {
            return ClassB.Add2(a, b);
        }

    }
}
