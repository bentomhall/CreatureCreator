using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureCreatorCore
{
    interface IAction
    {
        float AverageDamage { get; }
        int Modifier { get; }
        string Description { get; }
        bool IsConcentration { get; }
        int Targets { get; }
        string Name { get; }
    }
}
