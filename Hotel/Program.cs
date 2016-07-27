using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation;

namespace HotelReservation.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var hotelManager = new HotelBookingManager(new HotelsProvider().GetHotels());
            var enquiryParser = new EnquiryParser();

            foreach (var input in GetInputs())
            {
                System.Console.WriteLine(hotelManager.GetCheapestHotelByEnquiry(enquiryParser.GetEnquiryByInput(input)));
            }

            System.Console.Read();

        }

        private static List<string> GetInputs()
        {
            return new List<string>()
            {
                "Regular:16Mar2009(mon),17Mar2009(tues),18Mar2009(wed)",
                "Regular:20Mar2009(fri),21Mar2009(sat),22Mar2009(sun)",
                "Rewards:26Mar2009(thur),27Mar2009(fri),28Mar2009(sat)"
            };
        }
    }
}
