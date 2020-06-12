using System;
using System.Collections.Generic;
using System.Text;

namespace StategyPattern.src
{
    class OldPersonStrategy:BaseStrategy
    {
        public override double GetTicketPrice(double price)
        {
            return Math.Round(price/3, 5);
        }
    }
}
