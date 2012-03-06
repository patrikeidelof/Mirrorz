// -----------------------------------------------------------------------
// <copyright file="NorthEdge.cs" company="">
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
    public class Edge : ISquare
    {
        private string value;
        public Edge(string value)
        {
            this.value = value;
        }

        public string EastValue
        {
            get
            {
                return this.value;
            }
        }

        public string SouthValue
        {
            get
            {
                return this.value;
            }
        }

        public string NorthValue
        {
            get
            {
                return this.value;
            }
        }

        public string WestValue
        {
            get
            {
                return this.value;
            }
        }
    }
}
