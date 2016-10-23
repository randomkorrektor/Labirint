using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTipes
{
    public class Step
    {
        public Step Before;

        public Position pos;
        public Step(Step before, Position pos)
        {
            Before = before;
        }
    }
}
