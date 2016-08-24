using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammal : Animal //read this as "Mammal is an Animal"
    {
        public string HairColor { get; set; }
        public bool WarmBlooded {
            get
            {
                return true;
            }
        }

        // This is accessing the private property within Animal.
        // Need to have a separate way to get/set these
        // Also accessible to Tiger class since that inherits from Mammal
        public void SetCurrentZoo(string zooName)
        {
            CurrentZoo = zooName;
        }

        public string GetCurrentZoo()
        {
            return CurrentZoo;
        }
    }
}
