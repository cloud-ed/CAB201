using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3X_Classes
{
    class WhoLivesHere
    {
        string person;
        string city;


        public WhoLivesHere(string person, string city)
        {
            this.person = person;
            this.city = city;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{person} lives in {city}.");
        }
    }
}
