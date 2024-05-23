using System;
using Avalonia.Controls;
using Avalonia.Input;
using Digger.Architecture;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Digger
{
    class Player : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            switch (Game.KeyPressed)
            {
                case Key.Up:
                    return y - 1 >= 0 && Game.Map[x,y-1] is not Sack ? new CreatureCommand() { DeltaY = -1 } : new CreatureCommand();
                case Key.Down:
                    return y + 1 < Game.MapHeight && Game.Map[x, y + 1] is not Sack ? new CreatureCommand() { DeltaY = 1 } : new CreatureCommand();
                case Key.Left:
                    return x - 1 >= 0 && Game.Map[x-1, y] is not Sack ? new CreatureCommand() { DeltaX = -1 } : new CreatureCommand();
                case Key.Right:
                    return x + 1 < Game.MapWidth && Game.Map[x+1, y] is not Sack ? new CreatureCommand() { DeltaX = 1 } : new CreatureCommand();
                default:
                    return new CreatureCommand();
            }
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }
}
