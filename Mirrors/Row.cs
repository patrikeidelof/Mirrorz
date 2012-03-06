// -----------------------------------------------------------------------
// <copyright file="Row.cs" company="">
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
    public class Row
    {
        private ISquare[] squares;

        private int max;
        private int next;

        public Row(int columns)
        {
            this.squares = new ISquare[columns];
            this.max = columns-1;
        }

        public ISquare[] Squares;

        public void AddSquare(ISquare square)
        {
            if (next <= max)
            {
                this.squares[next] = square;
                next++;
            }
            else throw new ApplicationException("Not enough room for this square!");
        }

        public ISquare this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return squares[i];
            }
            set
            {
                squares[i] = value;
            }
        }
    }
}
