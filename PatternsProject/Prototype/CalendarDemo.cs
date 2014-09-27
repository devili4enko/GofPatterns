using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Prototype
{
    public class CalendarDemo
    {
        public static CalendarEvent GetExictingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new Attendee[2];

            friends[0] = new Attendee() {DateOfBirth = new DateTime(1986, 08, 08), Name = "Dima"};
            friends[1] = new Attendee() { DateOfBirth = new DateTime(1986, 10, 24), Name = "Vova" };

            beerParty.Attendies = friends;
            beerParty.EventPriority = Priority.AboveNormal;
            beerParty.StartDateAndTime = DateTime.Now.AddDays(1).AddHours(7.0);

            return beerParty;
        }

        public static void Run()
        {
            var party = GetExictingEvent();
            var nextParty = (CalendarEvent)party.Clone();

            nextParty.StartDateAndTime = DateTime.Now.AddDays(7);
            nextParty.SetPriority(5);
            nextParty.Attendies[0].Email = "q@q.com";
            nextParty.Attendies[1].Email = "1wq@q.com";

            if (nextParty.Attendies!=party.Attendies)
            {
                Console.WriteLine("New Attenndies for next Friday");
            }

            if (nextParty.EventPriority!=party.EventPriority)
            {
                Console.WriteLine("Next party much more interesting");
            }

        }
    }
}
