using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        abstract class Monster
        {
            public abstract void shout(); // 추상 메서드는 자식에서 무조건 오버라이딩 해야함
           
        }

        abstract class Flyable
        {
            public abstract void Fly();
        }
        
        interface IFlyable
        {
           void Fly();
        }

        class Orc : Monster
        {
            public override void shout()
            {
                Console.WriteLine("록타르 오가르");
            }
        }

        // 상속은 다중 상속이 안된다, 인터페이스는 다중 구현이 가능
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }
     
        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }   

        static void Main(string[] args)
        {
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);
 
        }
    }
}
