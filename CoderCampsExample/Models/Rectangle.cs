using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderCampsExample.Models
{
    public struct Rectangle
    {
        public Point P1;
        public Point P2;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.P1 =  new Point(x1, y1);
            this.P2 = new Point(x2, y2);
        }
        public Rectangle(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }
        public int Area()
        {
            int length = this.P1.X - this.P2.X;
            int width = this.P1.Y - this.P2.Y;
            return length * width;
        }
    }
    enum Days
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }
}