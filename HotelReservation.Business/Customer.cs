using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Customer
    {
        private HotelRate _hotelRate;


        private HotelRate HotelRate
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Null Value for Hotel Rate");
                }
                _hotelRate = value;
            }
        }

        private CustomerType _customerType;


        public Customer(CustomerType customerType,HotelRate hotelRate)
        {
            this.HotelRate = hotelRate;
            this._customerType = customerType;
        }

        public int GetCustomerHotelRateByDate(DateTime rateOnDate)
        {
            return _hotelRate.GetRateByDate(rateOnDate);
        }

        public int GetCustomerHotelRateByDayOfWeek(DayOfWeek rateOnDayOfWeek)
        {
            return _hotelRate.GetRateByDayOfWeek(rateOnDayOfWeek);
        }
    }


}
