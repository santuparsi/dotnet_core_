using System;

namespace HandsOnExceptiosn
{
    class BookTicket
    {
        public static void GetTickets(int count)
        {
            try
            {
                if (count <= 3)
                {
                    Console.WriteLine("Booking is Successfull..");
                }
                else
                    //throw new TicketBookingExcetion("Sorry!!" +
                    //    " can not book more than 3 tickets");
                    throw new TicketBookingExcetion();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter no of tickets to book");
                int count = int.Parse(Console.ReadLine());
                BookTicket.GetTickets(count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
