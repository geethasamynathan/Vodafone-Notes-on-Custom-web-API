using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DB_First_Demo.Models
{
    public partial class AuthorContact
    {
        public long AuthorId { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public virtual Author Author { get; set; }
    }
}
