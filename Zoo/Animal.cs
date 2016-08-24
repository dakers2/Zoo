using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal : Thing
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public DateTime Birthdate { get; set; }

        //Encapsulation
        //only accessible within the animal class, not to any inherited classes!!
        private string Birthplace { get; set; }

        //because Birthplace is private, we need a public method in order to set it
        public void SetBirthPlace(string birthplace)
        {
            Birthplace = birthplace;
        }

        public string GetBirthPlace()
        {
            return Birthplace;
        }

        //Protected properties can be accessed by the 
        protected string CurrentZoo { get; set; }

        //from Thing class - overriding abstract method
        public override string GetLocation()
        {
            return "Chicago";
        }
    }
}
