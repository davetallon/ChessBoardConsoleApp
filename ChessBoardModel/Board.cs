using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        public bool falsePawn = false;

        //The size of the board. Usually 8x8.
        public int Size { get; set; }
        //2d array of type Cell
        public Cell[,] theGrid { get; set; }


        //CONSTRUCTOR
        public Board(int s)
        {
            //Initial board size is defined by S.
            Size = s;
            //Create a new 2d array of type 'Cell'
            theGrid = new Cell[Size, Size];

            //Fill the 2d Array with new Cells, each with unique x, y co-ordinates.
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //step 1 - clear all previous legal moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].IsLegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //step 2 - find all legal moves and mark cells as 'legal'.

            switch (chessPiece)
            {
                case "knight":
                   if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                   {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                   {
                       theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                   {
                       theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                   {
                       theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                   {
                       theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                   {
                       theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                   {
                      theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                   }
                   if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                   {
                      theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                   }  
                   break;

                case "king":
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    break;

                case "rook":
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                  
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                   
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    break;

                case "bishop":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }                  
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }                   
                    break;

                case "queen":
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }                   
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }                 
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                 
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].IsLegalNextMove = true;
                    }             
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }                    
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 3, currentCell.ColumnNumber + 3))
                    {
                        theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 4, currentCell.ColumnNumber + 4))
                    {
                        theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 5, currentCell.ColumnNumber + 5))
                    {
                        theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 6, currentCell.ColumnNumber + 6))
                    {
                        theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 7, currentCell.ColumnNumber + 7))
                    {
                        theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber - 8, currentCell.ColumnNumber + 8))
                    {
                        theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 3, currentCell.ColumnNumber - 3))
                    {
                        theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 4, currentCell.ColumnNumber - 4))
                    {
                        theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 5, currentCell.ColumnNumber - 5))
                    {
                        theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 6, currentCell.ColumnNumber - 6))
                    {
                        theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 7, currentCell.ColumnNumber - 7))
                    {
                        theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].IsLegalNextMove = true;
                    }
                    if (isSafe(currentCell.RowNumber + 8, currentCell.ColumnNumber - 8))
                    {
                        theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].IsLegalNextMove = true;
                    }
                    break;

                
                case "pawn":
                    //First if logic is only complete for player side, not oponent side.
                    if (currentCell.RowNumber >= 7)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = false;
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].IsLegalNextMove = false;
                        Console.WriteLine("Pawns can only start from row 6. Hit Enter to continue");
                        Console.ReadLine();
                        falsePawn = true;
                        break;
                    }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].IsLegalNextMove = true;
                        falsePawn = false;
                    }
                    break;

                default:
                    break;
            }
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;

            bool isSafe(int row, int col)
            {
                bool safeMove = true;
                if(row < 0 || row >= Size || col < 0 || col >= Size)
                {
                    safeMove = false;
                }
                return safeMove;
            }
        }
    }
}
