using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBWrapper
{
    public partial class Transactions
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; set; }

        public virtual TransactionCategories Category { get; set; }
        public virtual Users User { get; set; }
    }
}
