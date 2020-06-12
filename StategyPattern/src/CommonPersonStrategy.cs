using System;
using System.Collections.Generic;
using System.Text;

namespace StategyPattern.src
{
    class CommonPersonStrategy:BaseStrategy
    {
        public override double GetTicketPrice(double price)
        {
            return price;
        }
    }
}
