using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Farmer_Private_Public
{
    class Farmer
    {

        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        private int numberOfCows;


        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

    
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultiplier;
            }
        }
        
    }
}
