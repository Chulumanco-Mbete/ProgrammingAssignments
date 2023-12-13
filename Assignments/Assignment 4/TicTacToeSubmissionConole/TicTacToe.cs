using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        public static string[,] ArrPos = { { "", "", "" }, { "", "", "" }, { "", "", "" } };

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
            int XturnCount = 0;
            int OturnCount = 0;
            bool xTurn = true;
            bool oTurn = true;

            

            while (true)
            {
                while (xTurn)
                {
                    //Player X code
                    Console.SetCursorPosition(2, 19);
                    Console.Write("Player X");
                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");
                    var row1 = Console.ReadLine();
                    Console.SetCursorPosition(2, 22);
                    Console.Write("Please Enter Column: ");
                    var column1 = Console.ReadLine();

                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                    if (ArrPos[int.Parse(row1), int.Parse(column1)] != "X" && ArrPos[int.Parse(row1), int.Parse(column1)] != "O")
                    {
                        _boardRenderer.AddMove(int.Parse(row1), int.Parse(column1), PlayerEnum.X, true);
                        ArrPos[int.Parse(row1), int.Parse(column1)] = "X";
                        xTurn = false;
                        oTurn = true;
                        XturnCount += 1;
                    }
                    else
                    {
                        //Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again.");
                    }
                }
                // Horizontal ----------------------------------------
                if (ArrPos[0, 0] == "X" && ArrPos[0, 1] == "X" && ArrPos[0, 2] == "X") 
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                else if (ArrPos[1, 0] == "X" && ArrPos[1, 1] == "X" && ArrPos[1, 2] == "X")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                else if (ArrPos[2, 0] == "X" && ArrPos[2, 1] == "X" && ArrPos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                // Diagonal -----------------------------------------
                else if (ArrPos[0, 0] == "X" && ArrPos[1, 1] == "X" && ArrPos[2, 2] == "X") 
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                else if (ArrPos[2, 0] == "X" && ArrPos[1, 1] == "X" && ArrPos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                // Coloumns ------------------------------------------
                else if (ArrPos[0, 0] == "X" && ArrPos[1, 0] == "X" && ArrPos[2, 0] == "X") 
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                else if (ArrPos[0, 1] == "X" && ArrPos[1, 1] == "X" && ArrPos[2, 1] == "X")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }
                else if (ArrPos[0, 2] == "X" && ArrPos[1, 2] == "X" && ArrPos[2, 2] == "X")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!");
                    break;
                }

                if (XturnCount == 5 & OturnCount == 4)
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Draw!");
                    break;
                }

                while (oTurn)
                {
                    //Player O code
                    Console.SetCursorPosition(3, 25);
                    Console.Write("Player O");
                    Console.SetCursorPosition(3, 26);
                    Console.Write("Please Enter Row: ");
                    var row2 = Console.ReadLine();
                    Console.SetCursorPosition(3, 28);
                    Console.Write("Please Enter Column: ");
                    var column2 = Console.ReadLine();

                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                    if (ArrPos[int.Parse(row2), int.Parse(column2)] != "X" && ArrPos[int.Parse(row2), int.Parse(column2)] != "O")
                    {
                        _boardRenderer.AddMove(int.Parse(row2), int.Parse(column2), PlayerEnum.O, true);
                        ArrPos[int.Parse(row2), int.Parse(column2)] = "O";
                        xTurn = true;
                        oTurn = false;
                        OturnCount += 1;
                    }
                    else
                    {
                        //Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again.");
                    }
                }
                // Horizontal ----------------------------------------
                if (ArrPos[0, 0] == "O" && ArrPos[0, 1] == "O" && ArrPos[0, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                else if (ArrPos[1, 0] == "O" && ArrPos[1, 1] == "O" && ArrPos[1, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                else if (ArrPos[2, 0] == "O" && ArrPos[2, 1] == "O" && ArrPos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                // Diagonal -----------------------------------------
                else if (ArrPos[0, 0] == "O" && ArrPos[1, 1] == "O" && ArrPos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                else if (ArrPos[2, 0] == "O" && ArrPos[1, 1] == "O" && ArrPos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                // Coloumns ------------------------------------------
                else if (ArrPos[0, 0] == "O" && ArrPos[1, 0] == "O" && ArrPos[2, 0] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                else if (ArrPos[0, 1] == "O" && ArrPos[1, 1] == "O" && ArrPos[2, 1] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
                else if (ArrPos[0, 2] == "O" && ArrPos[1, 2] == "O" && ArrPos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!");
                    break;
                }
            }  
        }
    }
}
