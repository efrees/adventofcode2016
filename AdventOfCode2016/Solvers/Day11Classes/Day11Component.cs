using System;

namespace AdventOfCode2016.Solvers.Day11Classes
{
    public class Day11Component
    {
        public string Type { get; set; }
        public string Element { get; set; }

        public Day11Component()
        {    
        }

        public Day11Component(string element, string type)
        {
            Element = element;
            Type = type;
        }

        public override bool Equals(object obj)
        {
            var otherComponent = obj as Day11Component;
            if (otherComponent != null)
            {
                return string.Equals(Type, otherComponent.Type, StringComparison.OrdinalIgnoreCase)
                       && string.Equals(Element, otherComponent.Element, StringComparison.OrdinalIgnoreCase);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() * 37 + Element.GetHashCode();
        }
    }
}