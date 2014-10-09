using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Drawing;

namespace LighWeight
{
    abstract class Unit
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public Image Picture { get; protected set; }
    }
}
