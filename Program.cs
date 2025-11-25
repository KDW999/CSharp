using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        class Map
        {

            int[,] tiles = {
            {1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 1, 1, 1, 1 }};
            public void Render()
            {
            ConsoleColor defaultColor = Console.ForegroundColor;

                for(int y=0; y<tiles.GetLength(1); y++)
                {
                    for(int x =0; x<tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = defaultColor;
            }
        }

        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();

            int[,] arr = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            for(int i=0; i<arr.GetLength(1); i++)
            {
                for(int j=0; j<arr.GetLength(0); j++)
                {
                    Console.Write(arr[i,j]+" / ");
                }
                Console.WriteLine();
            }
        }
    }
}
