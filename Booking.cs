using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssytem
{
    public class Booking
    {
        public string CustomerName { get; set; }
        public DateTime BookingTime { get; set; }
        public Booking(string customerName)
        {
            CustomerName = customerName;
            BookingTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{CustomerName} bokade vid tiden {BookingTime.ToShortTimeString}";
        }
    }
}
