using System;

namespace Painting.Models.Commands
{
    public abstract class Command
    {
        protected bool[,] _map;

        public Command()
        {
            _map = new bool[0, 0];
        }

        public Command(bool[,] map)
        {
            _map = map;
        }

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
