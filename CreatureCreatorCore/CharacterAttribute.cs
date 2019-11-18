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
            Value = value;
            Attribute = type;
        }

        public int Value { get; set; }

        public AttributeType Attribute {get; set;}

        public int Modifier { get { return (Value - 10) / 2; } }
    }
}
