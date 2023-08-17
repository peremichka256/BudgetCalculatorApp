using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBWrapper
{
    public partial class Users
    {
        public Users()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int TransactionId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
