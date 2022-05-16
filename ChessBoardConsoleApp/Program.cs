using System;
using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            //Display an empty chess board.
            printBoard(myBoard);



            //Ask the user for 2 inputs: an X and a Y co-ordinate
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;


            //Prompt the user for a chess piece.
            Console.WriteLine("What chess piece would you like to use?");
            string chessPiece = Console.ReadLine();


            //Calculate all legal moves for that piece. 
            myBoard.MarkNextLegalMoves(currentCell, chessPiece);

            while (myBoard.falsePawn) 
            {
                currentCell = setCurrentCell();
                myBoard.MarkNextLegalMoves(currentCell, chessPiece);
            }

            printBoard(myBoard);

             

            //Print the chess board {X is the occupied square. + is a legal move. . is an empty cell.

            //Wait for user to press enter and program will close.
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            int rowNumber;
            int columnNumber;

            // get x & y co-ordinates from user, then return a cell location from theGrid.
            Console.WriteLine("Enter a row number: ");
            try
            {
                rowNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                rowNumber = 3;
                Console.WriteLine("Response is not valid, the default row number is set to 3.");
            }
            
            Console.WriteLine("Enter a column number: ");
            try
            {
                columnNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                columnNumber = 3;
                Console.WriteLine("Response is not valid, the default column number is set to 3.");
            }
            
            return myBoard.theGrid[rowNumber, columnNumber];
        }

        private static void printBoard(Board myBoard)
        {
            //Print the chess board. Use X for piece location and use + for legal moves and use . for empty square.

            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if(c.IsLegalNextMove == true)
                    {
                        Console.Write("| + ");
                    }
                    else if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("| X ");
                    }
                    else
                    {
                        Console.Write("|   ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("=================================");
        }
    }
}
