namespace Bokningssytem
{
    public class Program
    {
        static BookingManager bookingManager = new();
        static void Main(string[] args)
        {
            //BookingManager book = new();
            Booking booking1 = new("Simon Eke");
            //booking1.ToString();
            //book.AddBooking(booking1.CustomerName);
            //book.DisplayBooking();

            Thread thread1 = new Thread(() => MakeBooking(booking1.CustomerName));
            Thread thread2 = new Thread(() => MakeBooking("Abdi"));
            Thread thread3 = new Thread(() => MakeBooking("Matti"));
            Thread thread4 = new Thread(() => MakeBooking("Mike"));
            Thread thread5 = new Thread(() => MakeBooking("Fritiof"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            thread5.Join();

            bookingManager.DisplayBooking();
        }

        static void MakeBooking(string customerName)
        {
            Console.WriteLine($"{customerName} makes a booking.");
            
            Thread.Sleep(new Random().Next(1000,5000));
            bookingManager.AddBooking(customerName);
        }
    }
}
