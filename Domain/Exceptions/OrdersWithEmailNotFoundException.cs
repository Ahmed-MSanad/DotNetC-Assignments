using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class OrdersWithEmailNotFoundException(string email) : NotFoundException($"Orders with email {email} were not found.")
    {

    }
}
