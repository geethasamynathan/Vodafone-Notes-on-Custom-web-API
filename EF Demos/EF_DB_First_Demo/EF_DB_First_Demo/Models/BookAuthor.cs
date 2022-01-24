using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DB_First_Demo.Models
{
    public partial class BookAuthor
    {
        public long BookId { get; set; }
        public long AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
