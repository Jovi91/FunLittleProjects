using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    public abstract class Location
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Location[] Exits { set; get; }

        public Location(string name)
        {
            this.name = name;
        }
        public virtual string Description
        {
            get
            {
                string description;
                description = "Stoisz w " + Name + ". Widzsz stąd wyjścia do ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += Exits[i].Name;

                    if (i+1 < Exits.Length)
                        description += ", ";
                    else
                        description += ". ";

                }

                return description;
            }
        }
    }
}
