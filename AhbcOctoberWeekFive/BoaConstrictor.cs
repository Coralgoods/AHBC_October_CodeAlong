﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    class BoaConstrictor : Reptile, IEggLayer, INestBuilder
    {
        public int IncubationTime { get; set; }
        public string NestType { get; set; }

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
