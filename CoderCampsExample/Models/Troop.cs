using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderCampsExample.Models
{
    public class Troop
    {
        public int Id { get; set; }
        public List<Camper> Campers { get; set; }
        public DateTime StartDate { get; set; }
        public int LocationId { get; set; }
    }
}