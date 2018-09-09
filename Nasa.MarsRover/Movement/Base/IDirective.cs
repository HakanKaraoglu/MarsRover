using Nasa.MarsRover.Map;

namespace Nasa.MarsRover.Movement.Base
{
   public interface IDirective
   {
       Position Process(Position position);
   }
}
