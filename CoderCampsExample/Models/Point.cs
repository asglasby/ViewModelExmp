using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderCampsExample.Models
{
    public struct Point
    {
        public int X;
        public int Y;

        //public Point()
        //{
        //    this.X = 0;
        //    this.Y = 0;
        //}

        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

    }
}