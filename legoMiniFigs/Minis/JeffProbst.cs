using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigs.Minis
{
    public class JeffProbst
    {
        //Properties
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        //Methods
        public void TribalCouncil()
        {
            Console.WriteLine("Jeff takes you to tribal council");
        }
        public void Immunity()
        {
            Console.WriteLine("Probst gives himself individual immunity");
        }
        public void Fire()
        {
            Console.WriteLine("Jeff takes away your fire");
        }
        public void Vote()
        {
            Console.WriteLine("Jeff goes and tallies the votes");
        }
    }
}
