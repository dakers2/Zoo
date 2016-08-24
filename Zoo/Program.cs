using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    /// <summary>
    /// A guide to using C# keywords
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.Birthdate = new DateTime(2011, 8, 24);
            t.HairColor = "Orange, White, Black";
            t.Name = "Tony";
            t.IsAlive = true;
            t.Jump(20);

            t.SetBirthPlace("Chicago");
            t.SetCurrentZoo("Brookfield");


            Platypus p = new Platypus();
            p.Name = "Patty";
            p.LayAnEgg();

            // with interfaces, you can never create new instances of that object
            // e.g. you can't do this:
            // ILayEggs p = new ILayEggs;

            //alternate way to write this:
            //ILayEggs p = new Platypus();
            // but you need to cast the type to access all properties of Platypus class
            //((Platypus)p).Name = "Patty";
            //p.LayAnEgg();

            Console.ReadLine();
        }
    }
}
