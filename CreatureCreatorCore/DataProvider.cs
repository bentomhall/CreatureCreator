using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureCreatorCore
{
    internal class DataProvider
    {
        internal DataProvider(string conn)
        {
            connectionString = conn;
        }

        internal int ChallengeByDamagePerTurn(float dpr) { throw new NotImplementedException(); }
        internal int ChallengeByHitPoints(int hp) { throw new NotImplementedException(); }
        internal int AttackModifierforChallenge(int cr) { throw new NotImplementedException(); }
        internal int ArmorClassforChallenge(int cr) { throw new NotImplementedException(); }
        internal int ExperienceforChallenge(int cr) { throw new NotImplementedException(); }
        internal int DifficultyClassforChallenge(int cr) { throw new NotImplementedException(); }

        private readonly string connectionString;
    }
}
