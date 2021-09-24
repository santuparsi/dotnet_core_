using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLineReservation.API.Entities;
namespace AirLineReservation.API.Repositories
{
    interface IAccountRepository
    {
        void Register(User user);
        User Validate(User user);
    }
}
