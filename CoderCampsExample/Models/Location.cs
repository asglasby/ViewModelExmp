using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderCampsExample.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ClassRoom { get; set; }
        public string Picture { get; set; }
        public List<Troop> Troops { get; set; }
    }
}