using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    // OOP(은닉성/상속성/다형성 Polymorphism)

    class Player
    {
        protected int hp;
        protected int attack;

        // virtual : 자식 클래스에서 재정의 가능
        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    // 오버로딩 : 함수 이름의 재사용, 같은 이름의 메서드를 매개변수로 구분
    // 오버라이딩 : 부모의 메서드를 자식 클래스에서 재정의
    class Knight : Player
    {

        // new : 부모에 있는 Move 메서드를 숨김
        // override : 부모에 있는 Move 메서드를 재정의
        // sealed : 자식 클래스에서 더 이상 재정의 불가
        public override void Move()
        {
            base.Move(); // 부모의 Move 호출
            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            Console.WriteLine("SuperKnight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;

        public new void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    internal class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
            
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
 
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();

            //EnterGame(mage);
        }
    }
}
