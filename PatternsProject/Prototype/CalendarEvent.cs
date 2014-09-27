using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class CalendarEvent : CalendarPrototype
    {
        public Attendee[] Attendies { get; set; }
        public Priority EventPriority{ get; set; }
        public DateTime StartDateAndTime { get; set; }


        /// <summary>
        /// Overriden method for deep copying
        /// </summary>
        /// <returns></returns>
        public override CalendarPrototype Clone()
        {
            var copy = (CalendarEvent) base.Clone();

            var attandies = (Attendee[]) Attendies.Clone();
            copy.Attendies = attandies;
            copy.EventPriority =  EventPriority;

            return copy;
        }

        public void SetPriority(int priority)
        {
            if (priority>0 && priority<=6)
            {
                this.EventPriority = (Priority) priority;
            }
        }
    }
}
