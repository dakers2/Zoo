using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Platypus : Mammal, IlayEggs //bring over ILayEggs interface
    {
        public void LayAnEgg()
        {
            Console.WriteLine("{0} laid an egg", this.Name);
        }
    }
}
