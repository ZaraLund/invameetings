using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvaMeetings.Web
{
    public class EventModel
    {
        public string name { get; set; }
        public string address { get; set; }
        public DateTime? date { get; set; }
        public string description { get; set; }

        public EventModel() {
            date = DateTime.Now;
        }
    }
}
