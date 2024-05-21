using System;
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
