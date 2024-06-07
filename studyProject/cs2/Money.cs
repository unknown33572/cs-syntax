using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    public class Money
    {
        private readonly int amount;
        private readonly String currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Add(Money other)
        {
            if (!currency.Equals(other.currency))
            {
                throw new ArgumentException("Currency mismatch");
            }
            int added = amount + other.amount;
            return new Money(added, currency);
        }
    }
}
