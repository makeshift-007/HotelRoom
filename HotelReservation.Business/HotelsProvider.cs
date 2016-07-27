 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class HotelsProvider
    {
        private List<Hotel> _hotels;
        public HotelsProvider()
        {
            _hotels = new List<Hotel>();

            _hotels.Add(new Hotel("Lakewood", 3,
                new Customer(CustomerType.Regular, new HotelRate(110, 90)),
                new Customer(CustomerType.Rewards, new HotelRate(80, 90))));

            _hotels.Add(new Hotel("Bridgewood", 4,
               new Customer(CustomerType.Regular, new HotelRate(160, 60)),
               new Customer(CustomerType.Rewards, new HotelRate(110, 50))));

            _hotels.Add(new Hotel("Ridgewood", 5,
               new Customer(CustomerType.Regular, new HotelRate(220, 150)),
               new Customer(CustomerType.Rewards, new HotelRate(100, 40))));

        }

        public List<Hotel> GetHotels()
        {
            return _hotels;
        }
    }
}
