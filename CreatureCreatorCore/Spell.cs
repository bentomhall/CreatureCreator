using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureCreatorCore
{
    class Spell : IAction
    {
        public float AverageDamage { get; }
        public int Modifier { get; }
        public string Description { get; }
        public bool IsConcentration { get; }
        public int Targets { get; }
        public string Name { get; }
    }
}
