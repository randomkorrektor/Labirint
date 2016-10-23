using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Cell
    {
        public CellType Type;
        public Position Position;
        public Cell(CellType type, Position pos) {
            Type = type;
            Position = pos;
        }
    }
}
