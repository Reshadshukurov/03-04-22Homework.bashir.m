using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_22Homework.bashir.m.Models
{
    class NotFoundException:Exception
    {
        public NotFoundException()
        {

        }
        public NotFoundException(string message):base(message)
        {

        }
    }
}
