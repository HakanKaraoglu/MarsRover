using System.Collections.Generic;
using MarsRover.Movement.Base;

namespace MarsRover.Movement
{
    public class Directive
    {
        public List<IDirective> MakeDirectives(string directives)
        {
            var directiveArray = directives.ToCharArray();
            var directiveList = new List<IDirective>(directiveArray.Length);

            foreach (var directive in directiveArray)
            {
                switch (directive)
                {
                    case 'L':
                        directiveList.Add(new LeftMovement());
                        break;

                    case 'R':
                        directiveList.Add(new RightMovement());
                        break;

                    case 'M':
                        directiveList.Add(new NextMovement());
                        break;
                }
            }
            return directiveList;
        }
    }
}
