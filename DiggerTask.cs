using System;
using Avalonia.Input;
using Digger.Architecture;

namespace Digger;
class Terrain : ICreature
{
    public CreatureCommand Act(int x, int y)
    {
        return new CreatureCommand();
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return true;
    }

    public int GetDrawingPriority()
    {
        return 2;
    }

    public string GetImageFileName()
    {
        return "Terrain.png";
    }
}

class Player : ICreature
{
    public CreatureCommand Act(int x, int y)
    {
        switch(Game.KeyPressed)
        {
            case Key.Up:
                return new CreatureCommand() { DeltaY = - 1 };
            case Key.Down:
                return new CreatureCommand() { DeltaY = 1 };
            case Key.Left:
                return new CreatureCommand() { DeltaX = - 1 };
            case Key.Right:
                return new CreatureCommand() { DeltaX = 1 };
            default:
                return new CreatureCommand();
        }
        //return new CreatureCommand();
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
//Напишите здесь классы Player, Terrain и другие.