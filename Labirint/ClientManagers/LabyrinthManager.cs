using DataTipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagers
{
    public class LabyrinthManager
    {
        public static LabyrinthManager Instance = new LabyrinthManager();

        private LabyrinthManager() { }

        public Queue<Step> queue;

        public bool[,]  getCell(Position pos)
        {
            return null;
        }

        public void find()
        {
            var step = queue.Dequeue();

            var cells = getCell(step.pos);

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (cells[i,j]) {
                        queue.Enqueue(new Step(step, new Position() { X = i, Y = j }));
                    }
                }
            }
        }
    }
}
