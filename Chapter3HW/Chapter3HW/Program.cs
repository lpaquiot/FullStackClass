using System;

namespace LoopTriangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FizzBuzz();
            //LoopingATriangle();
            Chessboard();
        }

        static void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
        }

        static void LoopingATriangle()
        {
            for (var triangle = "#"; triangle.Length <= 7; triangle += "#")
                Console.WriteLine(triangle);
        }

        static void Chessboard()
        {
            var board = "";
            var size = 8;

            for (var y = 0; y < size; y++)
            {
                for (var x = 0; x < size; x++)
                {
                    if ((x + y) % 2 == 0)
                        board += " ";
                    else
                        board += "#";
                }
                board += "\n";
            }

            Console.WriteLine(board);

        }
    }
}
