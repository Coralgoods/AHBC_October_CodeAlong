﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    class Turtle : Reptile, IEggLayer
    {
        public int IncubationTime { get; set; }       

        public void LayEggs()
        {
            throw new NotImplementedException();
        }

        bool IEggLayer.LayEggs()
        {
            throw new NotImplementedException();
        }
    }
}
