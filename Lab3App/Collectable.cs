using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public Collectable(string description)
        {
            Description = description;
        }
        public abstract void Display();//abstract method to be overriden

        public virtual void AddMe(List<Collectable> list)//method to be overriden unless it is abstract, then it automatically gets overriden
        {
            
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

    }
}

