using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
     // OOP(은닉성/상속성/다형성)

    class Player
    {
        protected int hp;
        protected int attack;   
    }
     class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    internal class Program
    { 
        static void EnterGame(Player player)
        {
            // is가 가능하면 as도 사용 가능
            // as는 형변환 할 수 있으면 형변환시킨다, 변환할 수 없으면 null 반환
            Mage mage = (player as Mage);

            if (mage != null)
            {
                Console.WriteLine("Mage");
                mage.mp = 10;
            }
        }
        static void Main(string[] args)
        {
            Knight knight2 = null; // 빈값
            Knight knight = new Knight();
            Mage mage = new Mage();


            // Mage 타입 -> Player 타입
            // Player 타입 -> Mage 타입 (강제 형변환)
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            Player p1 = knight;
            Mage m1 = mage;

            EnterGame(mage);
        }
    }
}
