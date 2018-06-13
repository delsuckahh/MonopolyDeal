using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyDeal
{
    class PropertySet : Pile
    {
        public PropertySet(string player, string type, string color) : base(player, type)
        {
            PropertyPile = new List<Card>();
            Owner = player;
            Type = type;
            Color = color;
            SetCapacity();
        }

        public void SetCapacity()
        {
            switch (Color)
            {
                case "Brown":
                case "Teal":
                case "Blue":
                    Capacity = 2;
                    break;
                case "Light Blue":
                case "Pink":
                case "Orange":
                case "Red":
                case "Yellow":
                case "Green":
                    Capacity = 3;
                    break;
                case "Black":
                    Capacity = 4;
                    break;
            }
        }

        

        List<Card> PropertyPile { get; set; }
        public string Color { get; set; }
        public int Capacity { get; set; }
    }
}
