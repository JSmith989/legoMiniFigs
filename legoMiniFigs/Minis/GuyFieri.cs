using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigs.Minis
{
    public class GuyFieri
    {
        //Properties
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        //Methods
        public void FlavorTown()
        {
            Console.WriteLine("Guy rides the bus to flavortown");
        }
        public void Dynamite()
        {
            Console.WriteLine("Fieri throws a flavor dynamite");
        }
        public void Flame()
        {
            Console.WriteLine("Guy's hair starts on fire");
        }
        public void CovidRelief()
        {
            Console.WriteLine("Guy raises millions of dollars for service industry");
        }
    }
}
