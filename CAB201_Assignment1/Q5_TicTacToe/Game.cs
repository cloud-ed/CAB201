using System.Diagnostics;

namespace TicTacToe
{
    class Game
    {
        public string[] lines;
        public Board Board;

        public Game(string[] lines)
        { 
            Board = new Board(lines);
        }

        public bool HasWinner()
        {
            if (Board.IsEmpty() == false)
            {
                if (Board.IsHomogeneous((Board.GetDiagonal(true))) == true)
                {
                    return true;
                }
                else if (Board.IsHomogeneous(Board.GetDiagonal(false)) == true)
                {
                    return true;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (Board.IsHomogeneous(Board.GetRow(i)) == true)
                    {
                        return true;
                    }
                    else if (Board.IsHomogeneous(Board.GetColumn(i)) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public char GetWinner()
        {
            if (HasWinner() == true)
            {
                if (Board.GetDiagonal(true) == "XXX")
                {
                    return 'X';
                }
                else if (Board.GetDiagonal(false) == "XXX")
                {
                    return 'X';
                }
                else if (Board.GetDiagonal(true) == "OOO")
                {
                    return 'O';
                }
                else if (Board.GetDiagonal(false) == "OOO")
                {
                    return 'O';
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Board.GetRow(i) == "XXX")
                        {
                            return 'X';
                        }
                        else if (Board.GetRow(i) == "OOO")
                        {
                            return 'O';
                        }
                        else if (Board.GetColumn(i) == "XXX")
                        {
                            return 'X';
                        }
                        else if (Board.GetColumn(i) == "OOO")
                        {
                            return 'O';
                        }
                    }
                }
            }
            return '.';
        }
    }
}