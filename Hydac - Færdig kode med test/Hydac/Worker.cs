using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public class Worker
    {
        private int idNumber;
        public int IdNumber { get { return idNumber; } }
        private string name;
        public string Name { get { return name; } }
        private Smiley smiley;
        public Smiley Smiley { get { return smiley; } }
        private Arrival[] arrivals;
        private int arrivalCount;

        public Worker(int idNumber, string name)
        {
            this.idNumber = idNumber;
            this.name = name;
            arrivalCount = 0;
            arrivals = new Arrival[365];
        }
        public void RegisterArrival(Arrival arrival, Smiley smiley)
        {
            arrivals[arrivalCount] = arrival;
            arrivalCount++;
            this.smiley = smiley;
        }
            
    }
}
