using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class EggLayingAnimal
    {
        public void LayAnEgg()
        {
            Console.WriteLine("I've laid an egg");
        }
    }


    public interface IlayEggs // interface can be reused with multiple classes
    {
        //cannot declare public/private; interfaces are entirely public by default
        void LayAnEgg();
    }
}
