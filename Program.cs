using System.ComponentModel.Design;
using System.Threading.Channels;

namespace CSharp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            // 0: 가위 1: 바위 2: 보
            Random rand = new Random(); 
            int aiChoice = rand.Next(0, 3); // 0~2사이 랜덤 값
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배
            if(choice == 0)
            {
                if(aiChoice == 0)
                {
                    Console.WriteLine("무승부입니다.");
                }
                else if(aiChoice == 1)
                {
                    Console.WriteLine("패배입니다.");
                }
                else
                {
                    Console.WriteLine("승리입니다.");
                }
            }
            else if(choice == 1)
            {
                if(aiChoice == 0)
                {
                    Console.WriteLine("승리입니다.");
                }
                else if(aiChoice == 1)
                {
                    Console.WriteLine("무승부입니다.");
                }
                else
                {
                    Console.WriteLine("패배입니다.");
                }
            }
            else
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("패배입니다.");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("승리입니다.");
                }
                else
                {
                    Console.WriteLine("무승부입니다.");
                }
            }

        }
    }
}
