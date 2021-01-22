using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigs.Minis
{
    public class TigerWoods
    {
        //Properties
        public string Hat { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        //Methods
        public void Four()
        {
            Console.WriteLine("Tiger hits his driver right at you");
        }
        public void GreenJacket()
        {
            Console.WriteLine("Tiger puts on his green jacket");
        }
        public void HoleInOne()
        {
            Console.WriteLine("Woods gets a hole in one");
        }
        public void Slice()
        {
            Console.WriteLine("Tiger slices your throat");
        }
    }
}
