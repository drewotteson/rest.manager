using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Reservations
    {
        public string ReserveTime { get; set; }
        public string PartySize { get; set; }
        public string PartyName { get; set; }

        public Reservations(string reserveTime, string partySize, string partyName)
        {
            this.ReserveTime = reserveTime;
            this.PartyName = partyName;
            this.PartySize = PartySize;
        }

        public Reservations()
        {

        }
    }
}
