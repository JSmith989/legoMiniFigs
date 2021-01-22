using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigs.Minis
{
    public class ChadMuska
    {
        //Properties
        public string Hat { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        //Methods
        public void Kickflip()
        {
            Console.WriteLine("Muska does a kickflip");
        }
        public void Boom()
        {
            Console.WriteLine("Chad busts out his boombox and plays shitty music");
        }
        public void Skate()
        {
            Console.WriteLine("Chad starts skating");
        }
        public void SpecialMove()
        {
            Console.WriteLine("Muska does his signature Backside Hurricane");
        }
    }
}
