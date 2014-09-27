using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Laptop
    {
        public int RAM { get; set; }
        public string Resolution { get; set; }
        public int VideoCard { get; set; }
        public int HDD { get; set; }
        public bool DVD { get; set; }
        public double Processor { get; set; }

        public override string ToString()
        {
            return String.Format("Processor {0}, RAM {1}, HDD {2}, Resolution {3}, Videocard {4}, DVD {5}", Processor, RAM, HDD, Resolution, VideoCard, DVD);
        }
    }
}
