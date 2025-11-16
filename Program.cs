using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
    class Player // 부모 클래스 OR 기반 클래스
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }

    class Mage : Player
    {

    }

    class Archer : Player
    {

    }
    class Knight : Player // 자식 OR 파생 클래스
    {
        public void Stun()
        {

        }
        
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
        }
    }
}
