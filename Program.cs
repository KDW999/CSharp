using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace CSharp
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int sum = n;
            for (int i=n-1; i>0; i--) 
            {
                sum = sum * i;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
