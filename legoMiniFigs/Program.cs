using legoMiniFigs.Minis;
using System;

namespace legoMiniFigs
{
    class Program
    {
        static void Main(string[] args)
        {
            var muska = new ChadMuska
            {
                Hat = "Sidways Hat",
                Head = "Normal",
                Torso = "Long Tee",
                Legs = "Ripped Jeans",
                Accessories = "Boom Box",
            };
            var fieri = new GuyFieri
            {
                Hair = "Bleached Spiked",
                Head = "Normal",
                Torso = "Fire Tee",
                Legs = "Jeans",
                Accessories = "Knife",
            };
            var probst = new JeffProbst
            {
                Hair = "Brown",
                Head = "Normal",
                Torso = "Bahama Fishing Tee",
                Legs = "Khaki Shorts",
                Accessories = "Shark Immunity Necklace",
            };
            var tiger = new TigerWoods
            {
                Hat = "Nike Hat",
                Head = "Normal",
                Torso = "Nike Tee",
                Legs = "Nike Pants",
                Accessories = "Golf Clubs",
            };

            muska.Boom();
            fieri.FlavorTown();
            probst.Immunity();
            tiger.Four();

        }
    }
}
