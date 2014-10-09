using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class SkiResortFacade
    {
        private RentSki rentSki;
        private BuySkiTicket ticketOffice;
        private RentRoom hotel;

        public SkiResortFacade()
        {
            rentSki= new RentSki();
            ticketOffice=new BuySkiTicket();
            hotel = new RentRoom();
        }

        public int FullComplex(int feetSize, int level, int height, int weight, int size, int daysToStay, int quality)
        {
            var boots =  rentSki.RentBoots(feetSize, level);
            var skies = rentSki.RentSkies(height, weight);
            var closes = rentSki.RentCloses(size);

            var tickets = ticketOffice.OneDay()*daysToStay;

            var room = hotel.Rent(quality)*daysToStay;

            return boots + skies + closes + tickets + room;
        }

        public int OneDayWithoutSkies()
        {
            return ticketOffice.OneDay();
        }

        public int WeekEndDealWithoutSkies(int quality)
        {
            var tickets = ticketOffice.OneDay() * 2;

            var room = hotel.Rent(quality) * 2;

            return  tickets + room;
        }
    }
}
