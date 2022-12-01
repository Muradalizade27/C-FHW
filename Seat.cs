using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Entities
{
    internal class Seat
    {
        public int Row;
        public int Column;
        public bool IsFull;

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            IsFull = false;
        }
    }
}
