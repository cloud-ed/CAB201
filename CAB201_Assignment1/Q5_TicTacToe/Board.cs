using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    class Board
    {
        private char[,] board;

        /// <summary>
        /// Constructor of the Board class. Fill the 2D board of characters using the lines array of strings.
        /// </summary>
        /// <param name="lines">The array of strings to fill the 2D board of characters</param>
        public Board(string[] lines)
        {
            int arraySize = 0;
            arraySize += lines[0].Length;
            arraySize += lines[1].Length;
            arraySize += lines[2].Length;

            if (arraySize!= 9)
            {
                board = new char[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = 'X';
                    }
                }
            }
            else
            {
                board = new char[3, 3];
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        board[i, j] = lines[i][j];
                    }
                }
            }
            
        }

        /// <summary>
        /// Get whether the board is valid, i.e. the board is a 3x3 board with only 'X', 'O' and '.' characters
        /// and the number of 'X' is equal to or one more than the number of 'O'
        /// </summary>
        /// <returns>True if the board is valid, false otherwise</returns>
        public bool IsValid()
        {
            int countX = 0;
            int countO = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != '.' && board[i, j] != 'O' && board[i, j] != 'X')
                    {
                        return false;
                    }
                    if (board[i, j] == 'X')
                    {
                        countX++;
                    }
                    else if (board[i, j] == 'O')
                    {
                        countO++;
                    }
                }
            }
            if (countX != countO && countX != countO + 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get the string representation of a row of the board, with 0 being the top row and 2 being the bottom row
        /// </summary>
        /// <param name="row">The row number</param>
        /// <returns>The string representation of a row of the board</returns>
        public string GetRow(int row)
        {
            string rowString = "";
            for (int i = 0; i < 3; i++)
            {
                rowString += board[i, row];
            }
            return rowString;
        }

        /// <summary>
        /// Get the string representation of a column of the board, with 0 being the left column and 2 being the right column
        /// </summary>
        /// <param name="column">The column number</param>
        /// <returns>The string representation of a column of the board</returns>
        public string GetColumn(int column)
        {
            string rowColumn = "";
            for (int i = 0; i < 3; i++)
            {
                rowColumn += board[column, i];
            }
            return rowColumn;
        }

        /// <summary>
        /// Get the string representation of a diagonal of the board
        /// </summary>
        /// <param name="topLeftToBottomRight">Whether the diagonal is from top left to bottom right</param>
        /// <returns>The string representation of a diagonal of the board</returns>
        public string GetDiagonal(bool topLeftToBottomRight)
        {
            string diagonal = "";
            if (topLeftToBottomRight == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    diagonal += board[i, i];
                }
            }
            else
            {
                diagonal += board[0, 2];
                diagonal += board[1, 1];
                diagonal += board[2, 0];
            }
            return diagonal;
        }

        /// <summary>
        /// Check if a string is homogeneous, i.e. all characters in the string are the same
        /// </summary>
        /// <param name="line">The string to check for homogeneity</param>
        public static bool IsHomogeneous(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != line[0])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsEmpty()
        {
            string tempRow1 = GetRow(0);
            string tempRow2 = GetRow(1);
            string tempRow3 = GetRow(2);

            if ((tempRow1+tempRow2+tempRow3) == ".........")
            {
                return true;
            }
            else { return false; }
        }
    }
}