﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cercleEtPoints
{
    public class Pts
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Pts() { }
        public Pts(double x, double y) {  X = x; Y = y; }

        public override string ToString()
        {
            return "("+X+", "+Y+")";
        }
    }
}
