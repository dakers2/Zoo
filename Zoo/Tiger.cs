using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger : Mammal
    {
        public void Jump(int distance)
        {
            Console.WriteLine("{0} just jumped {1} meters!", Name, distance);
        }
    }
}
