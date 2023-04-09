namespace NUnitProgramming
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Enter the degree celicius value: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c == 0)
            {
                int f;
                Console.WriteLine("Enter the Fahrenheit Value: ");
                f = Convert.ToInt32(Console.ReadLine());
                int ans=fahrenheitConversion(f);
                Console.WriteLine("The value in degree is: "+ans);
                
            }
            else
            {
                int result = degreeConversion(c);

                Console.WriteLine("The value in fehrenheit is: " + result);

            }
           
        }
        public static int degreeConversion(int c)
        {
            int fahrenheit =( (c * 9) / 5) + 32;
            return fahrenheit;
        }
        public static int fahrenheitConversion(int f)
        {
            int degree = (f - 32) * 5 / 9;
            return degree;
        }

      //  (c * (9/5))+32=f; c to f
        //(F - 32) * 5/9=c; f to c
    }
}
