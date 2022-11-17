namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;

            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);

            //Nullable
            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}