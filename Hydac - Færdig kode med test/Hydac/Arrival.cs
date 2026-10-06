using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public class Arrival
    {
        private DateTime date;
        public DateTime Date { get { return date; } }
        private DateTime time;
        public DateTime Time { get { return time; } }

        public Arrival(DateTime date, DateTime time)
        {
            this.date = date;
            this.time = time;
        }
    }
}
