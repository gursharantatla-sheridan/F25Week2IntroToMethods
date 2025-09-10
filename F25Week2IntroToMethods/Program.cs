namespace F25Week2IntroToMethods
{
    internal class Program
    {
        //int x;

        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Before changes: \n");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValue(ref n, s, a);

            Console.WriteLine("\n\nAfter changes: \n");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            Console.WriteLine("\n\n\n");


            int rad = 5;
            double circum, area;

            Calculate(rad, out circum, out area);

            Console.WriteLine("Circumference = " + circum);
            Console.WriteLine("Area = " + area);
        }

        static void Calculate(int r, out double cir, out double ar)
        {
            cir = 2 * Math.PI * r;
            ar = Math.PI * r * r;
        }



        static void ChangeValue(ref int num, string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
