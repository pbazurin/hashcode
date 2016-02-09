using System;

namespace Painting.Models.Commands
{
    public abstract class Command
    {
        public bool[,] Map { get; set; }

        public virtual void Do()
        {
            throw new NotImplementedException();
        }

        public virtual void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
