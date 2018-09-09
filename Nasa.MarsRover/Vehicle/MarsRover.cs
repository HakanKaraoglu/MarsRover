using System.Collections.Generic;
using Nasa.MarsRover.Map;
using Nasa.MarsRover.Movement;
using Nasa.MarsRover.Movement.Base;

namespace Nasa.MarsRover.Vehicle
{
    public class MarsRover
    {
        private Position _position;

        public MarsRover(string initialPosition)
        {
            this._position = new PositionFactory().Create(initialPosition);
        }

        public Position GetPosition()
        {
            return _position;
        }

        public void Move(string moves)
        {
            Directive directiveFactory = new Directive();
            List<IDirective> moveList = directiveFactory.MakeDirectives(moves);

            foreach (var directive in moveList)
            {
                this._position = directive.Process(this._position);
            }
        }
    }
}
