using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureCreatorCore
{
    public enum AttributeType
    {

    }
    public class CharacterAttribute
    {

        public CharacterAttribute(AttributeType type, int value)
        {
            if (value > 30 || value < 1) { throw new ArgumentException("Attributes must be between 1 and 30."); }
            Value = value;
            Attribute = type;
        }

        public int Value { get; }

        public AttributeType Attribute {get;}

        public int Modifier { get { return (Value - 10) / 2; } }
    }
}
