using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming)

    // Ref 참조
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {

        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }


        public void Move()
        {
            Console.WriteLine("knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }

    // 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }
        internal class Program
    {
       
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;

        }
    }
}
