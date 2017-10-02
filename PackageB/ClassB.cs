using PackageA;

namespace PackageB
{
    public static class ClassB
    {
        public static int Add(int a, int b)
        {
            return a + b + 1;
        }

        public static int Add2(int a, int b)
        {
            return ClassA.Add(a, b) + 2;
        }

    }
}
