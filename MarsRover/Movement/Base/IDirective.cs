using MarsRover.Map;

namespace MarsRover.Movement.Base
{
   public interface IDirective
   {
       Position Process(Position position);
   }
}
