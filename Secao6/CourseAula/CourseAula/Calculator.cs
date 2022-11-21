namespace CourseAula
{
    class Calculator
    {
        //Modificador de acesso params
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //Modificador de acesso ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        //Modificador de acesso out

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
