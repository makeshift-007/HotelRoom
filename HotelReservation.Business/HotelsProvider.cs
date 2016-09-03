using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{

    public interface IHotelProvider
    {

        List<HotelInformation> GetRewardCustomerHotels();
        List<HotelInformation> GetRegularCustomerHotels();
    }


    public class HotelsProvider : IHotelProvider
    {


        public List<HotelInformation> GetRewardCustomerHotels()
        {
            return new List<HotelInformation>{
                new HotelInformation("Lakewood", 3,80,90),
                new HotelInformation("Bridgewood", 4,110,50),
                new HotelInformation("Ridgewood", 5,100,40)
            };
        }
        public List<HotelInformation> GetRegularCustomerHotels()
        {
            return new List<HotelInformation>{
                new HotelInformation("Lakewood", 3,110,90),
                new HotelInformation("Bridgewood", 4,160,60),
                new HotelInformation("Ridgewood", 5,220,150)
            };
        }
    }
}
