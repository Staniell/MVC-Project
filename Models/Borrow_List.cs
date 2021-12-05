namespace mp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Borrow_List
    {
        public DateTime? Account_Created { get; set; }

        [StringLength(50)]
        public string Borrower_Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Book_ID { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public DateTime? Date_Borrowed { get; set; }

        public DateTime? Date_Return { get; set; }

        public DateTime? Date_Paid { get; set; }

        public int? Fee { get; set; }

        public virtual Book Book { get; set; }

        public virtual Reg_Accounts Reg_Accounts { get; set; }
    }
}
