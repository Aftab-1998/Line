﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe
{
    public class LineLengthComparison
    {
        public double CalculateLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
            return length;

        }
    }
}