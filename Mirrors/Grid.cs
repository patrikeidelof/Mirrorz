// -----------------------------------------------------------------------
// <copyright file="Grid.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Mirrors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Grid
    {
        private Row[] rows;

        public Grid()
        {
            MakeThreeByThree();
        }

        private void MakeThreeByThree()
        {
            rows = new Row[5];
            rows[0] = new Row(5);
            rows[1] = new Row(5);
            rows[2] = new Row(5);
            rows[3] = new Row(5);
            rows[4] = new Row(5);
            
            rows[0].AddSquare(new Edge("0") );
            rows[0].AddSquare(new Edge("A"));
            rows[0].AddSquare(new Edge("B"));
            rows[0].AddSquare(new Edge("C"));
            rows[0].AddSquare(new Edge("0"));
            
            rows[1].AddSquare(new Edge("L"));
            rows[1].AddSquare(new Square(true, rows[0][1], rows[2][1], rows[1][2], rows[1][0]));
            rows[1].AddSquare(new Square(true, rows[0][2], rows[2][2], rows[1][3], rows[1][1]));
            rows[1].AddSquare(new Square(true, rows[0][3], rows[2][3], rows[1][4], rows[1][2]));
            rows[1].AddSquare(new Edge("D"));

            rows[2].AddSquare(new Edge("K"));
            rows[2].AddSquare(new Square(true, rows[1][1], rows[3][1], rows[2][2], rows[2][0]));
            rows[2].AddSquare(new Square(true, rows[1][2], rows[3][2], rows[2][3], rows[2][1]));
            rows[2].AddSquare(new Square(true, rows[1][3], rows[3][3], rows[2][4], rows[2][2]));
            rows[2].AddSquare(new Edge("E"));

            rows[3].AddSquare(new Edge("J"));
            rows[3].AddSquare(new Square(true, rows[2][1], rows[4][1], rows[3][2], rows[3][0]));
            rows[3].AddSquare(new Square(true, rows[2][2], rows[4][2], rows[3][3], rows[3][1]));
            rows[3].AddSquare(new Square(true, rows[2][3], rows[4][3], rows[3][4], rows[3][2]));
            rows[3].AddSquare(new Edge("F"));
            
            rows[4].AddSquare(new Edge("0"));
            rows[4].AddSquare(new Edge("I"));
            rows[4].AddSquare(new Edge("H"));
            rows[4].AddSquare(new Edge("G"));
            rows[4].AddSquare(new Edge("0"));
        }

        public string Start(int row, int column, int edge)
        {
            switch (edge)
            {
                case 1:
                    {
                        return rows[row][column].NorthValue;
                    }
                case 2:
                    {
                        return rows[row][column].EastValue;
                    }
                case 3:
                    {
                        return rows[row][column].SouthValue;
                    }
                case 4:
                    {
                        return rows[row][column].WestValue;
                    }
                default:
                    {
                        throw new ApplicationException("Argument error.");
                    }
            }
        }
    }
}
