using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    
    internal class Program
    {
        class TestException : Exception
        {

        }

        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리 참조 (null)
                // 3. 오버플로우
                int a = 10;
                int b = 0;
                int result = a / b;

                //throw new TestException();
            }
            catch (DivideByZeroException)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // DB, 파일 정리 등
            }
        }
    }
}
