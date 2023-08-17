using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBWrapper
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; set; }
        public int? UserTransactionId { get; set; }

        public virtual Users UserTransaction { get; set; }
    }
}
