using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class EnquiryInformation
    {
        private readonly CustomerType _customerType;
        private List<DateTime> _datesOfReservation;

        private List<DateTime> DatesOfReservation
        {
            set
            {
                if (value == null)
                    throw new ArgumentException("Dates of Reservation Cannot be Null");
                _datesOfReservation = value;
            }
           
        }

        public EnquiryInformation(CustomerType customerType, List<DateTime> dateOfReservation)
        {
            this._customerType = customerType;
            this.DatesOfReservation = dateOfReservation;
        }

        public CustomerType GetCustomerType()
        {
            return _customerType;
        }

        public List<DateTime> GetDatesOfReservation()
        {
            return _datesOfReservation;
        }
    }
}
