using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_22Homework.bashir.m.Models
{
    class NotAvailableException:Exception
    {
        public NotAvailableException()
        {
        }
        public NotAvailableException(string message):base(message)
        {

        }
    }
}
