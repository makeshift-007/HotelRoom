using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class EnquiryInformation
    {
        private CustomerType CustomerType { set; get; }
        private List<DateTime> _datesOfReservation;

        private List<DateTime> DatesOfReservation
        {
            set
            {
                if (value == null)
                    throw new ArgumentException("Dates of Reservation Cannot be Null");
                _datesOfReservation = value;
            }
            get { return _datesOfReservation; }
        }

        public EnquiryInformation(CustomerType customerType, List<DateTime> dateOfReservation)
        {
            this.CustomerType = customerType;
            this.DatesOfReservation = dateOfReservation;
        }

        public CustomerType GetCustomerType()
        {
            return CustomerType;
        }

        public List<DateTime> GetDatesOfReservation()
        {
            return DatesOfReservation;
        }
    }
}
