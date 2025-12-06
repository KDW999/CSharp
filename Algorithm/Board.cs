using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm
{


    internal class Board
    {
        const char CIRCLE = '\u25cf';
        public TileType[,] _tile; // 배열
        public int _size;

        public enum TileType
        {
            Empty,
            Wall,
        }
        public void Initialize(int size)
        {
            if (size % 2 == 0)
                return;
            _tile = new TileType[size, size];
            _size = size;

            //GenerateByBinaryTree();
            GenerateBySideWinder();
        }
        void GenerateBySideWinder()
        {
            // 길 막는 작업
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        _tile[y, x] = TileType.Wall;
                    else
                        _tile[y, x] = TileType.Empty;
                }
            }

            Random rand = new Random();
            for (int y = 0; y < _size; y++)
            {
                int count = 1;
                for (int x = 0; x < _size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == _size - 2 && x == _size - 2)
                        continue;

                    if (y == _size - 2)
                    {
                        _tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == _size - 2)
                    {
                        _tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0)
                    {
                        _tile[y, x + 1] = TileType.Empty;
                        count++;
                    }
                    else
                    {
                        int randomIndex = rand.Next(0, count);
                        _tile[y + 1, x - randomIndex * 2] = TileType.Empty;
                        count = 1;
                    }
                }


            }
        }
        // 짝수 인덱스에서 랜덤 방향으로 벽을 뚫고 나가서 출구를 찾는 미로 알고리즘 느낌
        void GenerateByBinaryTree()
        {
            {
                // 길 막는 작업
                for (int y = 0; y < _size; y++)
                {
                    for (int x = 0; x < _size; x++)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                            _tile[y, x] = TileType.Wall;
                        else
                            _tile[y, x] = TileType.Empty;
                    }
                }

                // 랜덤으로 우측 혹은 아래로 길을 뚫는 작업
                // Binary Tree Algorithm
                Random rand = new Random();
                for (int y = 0; y < _size; y++)
                {
                    for (int x = 0; x < _size; x++)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                            continue;

                        if (y == _size - 2 && x == _size - 2)
                            continue;

                        if (y == _size - 2)
                        {
                            _tile[y, x + 1] = TileType.Empty;
                            continue;
                        }

                        if (x == _size - 2)
                        {
                            _tile[y + 1, x] = TileType.Empty;
                            continue;
                        }

                        if (rand.Next(0, 2) == 0)
                        {
                            _tile[y, x + 1] = TileType.Empty;
                        }
                        else
                        {
                            _tile[y + 1, x] = TileType.Empty;
                        }
                    }
                }
            }
        }

        public void Render()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);
                    Console.Write(CIRCLE);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = prevColor;
        }

        ConsoleColor GetTileColor(TileType type)
        {
            switch (type)
            {
                case TileType.Empty:
                    return ConsoleColor.Green;
                case TileType.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }

        }
    }
}
