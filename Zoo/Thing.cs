using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Thing
    {
        public abstract string GetLocation();
        // this method is empty and requires other classes to have an override method for it
    }
}
