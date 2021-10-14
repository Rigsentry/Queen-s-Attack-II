using System;

namespace Queen_s_Attack_II
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sample 0
            var n0 = 4;
            var k0 = 0;
            var r_q0 = 4;
            var c_q0 = 4;
            int[,] obstacles0 = new int[,] { };

            //Sample 1
            var n1 = 5;
            var k1 = 3;
            var r_q1 = 4;
            var c_q1 = 3;
            int[,] obstacles1 = new int[,]
            {
                { 5, 5 },
                { 4, 2 },
                { 2, 3 }
            };

            //Sample 2
            var n2 = 1;
            var k2 = 0;
            var r_q2 = 1;
            var c_q2 = 1;
            int[,] obstacles2 = new int[,] { };

            //Sample 3
            //var n3 = 100000;
            //var k3 = 0;
            //var r_q3 = 4187;
            //var c_q3 = 5068;
            //int[,] obstacles3 = new int[,] { };

            Console.WriteLine("Sample 0:");
            queenMoveCalculator(n0,  k0,  r_q0,  c_q0, obstacles0);
            
            Console.WriteLine("Sample 1:");
            queenMoveCalculator(n1, k1, r_q1, c_q1, obstacles1);

            Console.WriteLine("Sample 2:");
            queenMoveCalculator(n2, k2, r_q2, c_q2, obstacles2);

            //Console.WriteLine("Sample 3:");
            //queenMoveCalculator(n3, k3, r_q3, c_q3, obstacles3);

            static void queenMoveCalculator(int n, int k, int r_q, int c_q, int[,] obstacles)
            {
                var i = 0;
                var j = 0;
                var z = 0;
                var queenMoves = 0;

                //creating Board with empty spaces "-"
                string[,] board = new string[n, n];
                for(i = 0; i < n; i++)
                {
                    for(j = 0; j < n; j++)
                    {
                        //board[i, j] = i + "," + j;
                        board[i, j] = "-";
                    }
                }

                //Placing the queen in the board
                var queenRow = r_q - 1;
                var queenColumn = c_q - 1;
                board[queenRow, queenColumn] = "Q";

                //adding obstacles
                for (i = 0; i < k; i++)
                {
                    for (j = 0; j < 1; j++)
                    {
                        var obstacleColumn = obstacles[i, 0] - 1;
                        var obstacleRow = obstacles[i, 1] - 1;

                        board[obstacleColumn, obstacleRow] = "X";
                    }
                }

                for(z = 1; z <= 8; z++)
                {
                    switch (z)
                    {
                        case 1:
                            for(i = 1; queenRow - i >= 0 && queenColumn - i >= 0; i++)
                            {
                                if (board[queenRow - i, queenColumn - i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow - i, queenColumn - i] = "✓";
                                }
                            }
                            break;

                        case 2:
                            for (i = 1; queenRow - i >= 0; i++)
                            {
                                if (board[queenRow - i, queenColumn] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow - i, queenColumn] = "✓";
                                }
                            }
                            break;

                        case 3:
                            for (i = 1; queenRow - i >= 0 && queenColumn + i < n; i++)
                            {
                                if (board[queenRow - i, queenColumn + i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow - i, queenColumn + i] = "✓";
                                }
                            }
                            break;

                        case 4:
                            for (i = 1; queenColumn + i < n; i++)
                            {
                                if (board[queenRow, queenColumn + i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow, queenColumn + i] = "✓";
                                }
                            }
                            break;

                        case 5:
                            for (i = 1; queenRow + i < n && queenColumn + i < n; i++)
                            {
                                if (board[queenRow + i, queenColumn + i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow + i, queenColumn + i] = "✓";
                                }
                            }
                            break;

                        case 6:
                            for (i = 1; queenRow + i < n; i++)
                            {
                                if (board[queenRow + i, queenColumn] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow + i, queenColumn] = "✓";
                                }
                            }
                            break;

                        case 7:
                            for (i = 1; queenRow + i < n && queenColumn - i >= 0; i++)
                            {
                                if (board[queenRow + i, queenColumn - i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow + i, queenColumn - i] = "✓";
                                }
                            }
                            break;

                        case 8:
                            for (i = 1; queenColumn - i >= 0; i++)
                            {
                                if (board[queenRow, queenColumn - i] == "X")
                                {
                                    break;
                                }
                                else
                                {
                                    board[queenRow, queenColumn - i] = "✓";
                                }
                            }
                            break;

                    }
                }

                //Printing the Final Board
                for (i = 0; i < board.GetLength(0); i++)
                {
                    for (j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write(board[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                foreach (var moves in board)
                {
                    if(moves == "✓")
                    {
                        queenMoves++;
                    }
                }

                Console.WriteLine("The Queen can move " + queenMoves + " spaces");
                Console.WriteLine();
            }
        }
    }
}
