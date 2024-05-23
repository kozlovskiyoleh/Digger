using System;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Input;
using Digger.Architecture;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Digger
{
    class Sack : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            if(y+1<Game.MapHeight)
            {
                if (Game.Map[x,y+1] is null)
                {
                    return new CreatureCommand() { DeltaY = 1 };
                }

            }
            return new CreatureCommand();
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
           return false;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public string GetImageFileName()
        {
            return "Sack.png";
        }
    }
}
