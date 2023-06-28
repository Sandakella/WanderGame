using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] Map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#','X',' ','#',' ',' ',' ',' ',' ',' ',' ','X','#',' ','#',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ','#','#','#','#',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
                {'#',' ',' ','#','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','#','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','X',' ','#'},
                {'#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#'},
                {'#',' ','#','#','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#','#',' ',' ',' ',' ',' ','#'},
                {'#',' ','#',' ','#',' ','#',' ',' ',' ','#',' ','#','#',' ','#',' ',' ',' ','#'},
                {'#',' ','#',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
                {'#','X','#',' ','#',' ','#','X','#',' ',' ',' ',' ',' ',' ',' ','#','#','X','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            int userX = 10; int userY = 9;
            char[] bag = new char[1];

            while (true)
            {
                Console.SetCursorPosition(0, 22);
                Console.Write("Сумка:");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < Map.GetLength(0); i++)
                {
                    for (int j = 0; j < Map.GetLength(1); j++)
                    {
                        Console.Write(Map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;

                }
                if (Map[userX, userY] == 'X')
                {
                    Map[userX, userY] = 'O';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
