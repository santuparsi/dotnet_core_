using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptiosn
{
    class TicketBookingExcetion:Exception
    {
        public TicketBookingExcetion(string msg):base(msg)
        {
            
        }
    }
}
