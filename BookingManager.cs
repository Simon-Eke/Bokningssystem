using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokningssytem
{
    public class BookingManager
    {
        private List<Booking> Bookings;
        private readonly object LockObject = new();
        public BookingManager()
        {
            Bookings = new List<Booking>();
        }

        // Add a thread secure booking
        public void AddBooking(string customerName)
        {
            lock(LockObject) // hur fan funkar lockobject ??????
            {
                Bookings.Add(new Booking(customerName));
                Console.WriteLine($"{customerName} has made a booking.");
            }           
        }

        public void DisplayBooking()
        {
            Console.WriteLine("\nHere are all the bookings: \n");
            foreach (var booking in Bookings)
            {
                Console.WriteLine($"Booking Name:{booking.CustomerName} \nBooking Time:{booking.BookingTime}");
            }
        }
    }
}
