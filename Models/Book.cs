namespace mp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [Key]
        public int Book_ID { get; set; }

        [StringLength(50)]
        public string Book_Name { get; set; }
        [StringLength(20)]
        public string Genre { get; set; }
        public short? fee { get; set; }

        public virtual Borrow_List Borrow_List { get; set; }
    }
}
