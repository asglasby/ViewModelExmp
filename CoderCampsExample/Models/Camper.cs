using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderCampsExample.Models
{
    public class Camper
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public int  TroopId { get; set; }
    }
}
