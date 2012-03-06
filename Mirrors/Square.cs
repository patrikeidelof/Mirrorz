// -----------------------------------------------------------------------
// <copyright file="Square.cs" company="">
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
    public class Square : ISquare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="switched">
        /// The switched.
        /// </param>
        /// <param name="north">
        /// The north.
        /// </param>
        /// <param name="south">
        /// The south.
        /// </param>
        /// <param name="east">
        /// The east.
        /// </param>
        /// <param name="west">
        /// The west.
        /// </param>
        public Square(bool switched, ISquare north, ISquare south, ISquare east, ISquare west)
        {
            this.Switched = switched;
            this.north = north;
            this.south = south;
            this.west = west;
            this.east = east;
        }

        public Square()
        {
            
        }

        /// <summary>
        /// </summary>
        private ISquare north;

        /// <summary>
        /// </summary>
        private ISquare south;

        /// <summary>
        /// </summary>
        private ISquare east;

        /// <summary>
        /// </summary>
        private ISquare west;

        /// <summary>
        /// Gets or sets a value indicating whether Switched.
        /// </summary>
        public bool Switched { get; set; }

        public bool Connected
        {
            get
            {
                if (north == null || east == null || west == null || south == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Gets value from north.
        /// </summary>
        public virtual string NorthValue 
        { 
            get
            {
                return this.Switched ? this.west.EastValue : this.east.WestValue;
            } 
        }

        /// <summary>
        /// Gets value from South.
        /// </summary>
        public virtual string SouthValue 
        { 
            get
            {
                return this.Switched ? this.east.WestValue : this.west.EastValue;
            } 
        }

        /// <summary>
        /// Gets value from East.
        /// </summary>
        public virtual string EastValue 
        { 
            get
            {
                return this.Switched ? this.south.NorthValue : this.north.SouthValue;
            } 
        }

        /// <summary>
        /// Gets value from West.
        /// </summary>
        public virtual string WestValue
        {
            get
            {
                return this.Switched ? this.north.SouthValue : this.south.NorthValue;
            }
        }

        /// <summary>
        /// </summary>
        public ISquare North
        {
            get
            {
                return this.north;
            }
            set
            {
                this.north = value;
            }
        }

        /// <summary>
        /// </summary>
        public ISquare South
        {
            get
            {
                return this.south;
            }
            set
            {
                this.south = value;
            }
        }

        /// <summary>
        /// </summary>
        public ISquare East
        {
            get
            {
                return this.east;
            }
            set
            {
                this.east = value;
            }
        }

        /// <summary>
        /// </summary>
        public ISquare West
        {
            get
            {
                return this.west;
            }
            set
            {
                this.west = value;
            }
        }
    }
}
