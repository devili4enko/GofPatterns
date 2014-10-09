using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfCalendarPrototype = (CalendarPrototype)this.MemberwiseClone();
            return copyOfCalendarPrototype;
        }
    }
}
