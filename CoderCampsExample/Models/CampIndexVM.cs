using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderCampsExample.Models
{
    public class CampIndexVM
    {
        public string Title { get; set; }
        public List<Troop> Troops { get; set; }
        public List<Location> Locations { get; set; }
        public List<Camper> Campers { get; set; }
    }
}