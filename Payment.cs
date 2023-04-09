using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProgramming
{
    internal class Payment
    {
      /*  public static void Main(string[] args)
        {
            double P;
            Console.WriteLine("Enter the Principal Amount: ");
            P =Convert.ToDouble(Console.ReadLine());

            double Y;
            Console.WriteLine("Enter No.of Years: ");
            Y =Convert.ToDouble(Console.ReadLine());

            double R;
            Console.WriteLine("Enter the rate of interest: ");
            R = Convert.ToDouble(Console.ReadLine());

            double result=monthlyPayment(P,Y,R);
            Console.WriteLine("The Monthly Payment amount is: "+result);

            
        }*/
        public static double monthlyPayment(double P,double Y,double R)
        {
            double n = 12 * Y ;
            double r = R / (12 * 100);

            double pay = (P * r) / 1-Math.Pow( (1 + r), -n);
            return pay;
        }
    }
}
