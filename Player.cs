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
                    return y - 1 >= 0 ? new CreatureCommand() { DeltaY = -1 } : new CreatureCommand();
                case Key.Down:
                    return y + 1 < Game.MapHeight ? new CreatureCommand() { DeltaY = 1 } : new CreatureCommand();
                case Key.Left:
                    return x - 1 >= 0 ? new CreatureCommand() { DeltaX = -1 } : new CreatureCommand();
                case Key.Right:
                    return x + 1 < Game.MapWidth ? new CreatureCommand() { DeltaX = 1 } : new CreatureCommand();
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
