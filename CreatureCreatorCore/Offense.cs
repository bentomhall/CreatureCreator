using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureCreatorCore
{
    internal class Offense
    {

        internal Offense(DataProvider data, IDictionary<AttributeType, CharacterAttribute> attributes) 
        {
            this.data = data;
            this.attributes = attributes;
            TargetCR = 0;
        }

        internal int TargetCR { get; set; }

        internal double CalculateOffensiveCR()
        {
            var dpr = CalculateBaseDamage();
            var adjustments = ApplyTraits();
            var baseOffensiveCR = data.ChallengeByDamagePerTurn(dpr+adjustments.Item1);
            var mod = CalculateModifier() + adjustments.Item2;
            var adjustedOffensiveCR = baseOffensiveCR + Math.Floor((mod - data.AttackModifierforChallenge(baseOffensiveCR)) / 2.0);
            return adjustedOffensiveCR;
        }

        private float CalculateBaseDamage()
        {
            throw new NotImplementedException();
        }

        private Tuple<int,int> ApplyTraits() { throw new NotImplementedException(); }
        private int CalculateModifier() { throw new NotImplementedException(); }

        private readonly IDictionary<AttributeType, CharacterAttribute> attributes;
        private readonly DataProvider data;
    }
}
