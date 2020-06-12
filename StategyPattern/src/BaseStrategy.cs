using System;
using System.Collections.Generic;
using System.Text;

namespace StategyPattern.src
{
    public abstract class BaseStrategy
    {
        public abstract double GetTicketPrice(double price);
    }
}
