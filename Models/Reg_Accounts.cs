namespace mp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reg_Accounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reg_Accounts()
        {
            Borrow_List = new HashSet<Borrow_List>();
        }

        [Key]
        [StringLength(50)]
        public string Borrower_Name { get; set; }

        [StringLength(20)]
        public string Phone_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Borrower_Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Borrower_Password { get; set; }

        public DateTime? Account_Created { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow_List> Borrow_List { get; set; }
    }
}
