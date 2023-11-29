namespace DataAccessLayer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EmpProfile")]
    public partial class EmpProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpCode { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(255)]
        public string EmpName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? DeptCode { get; set; }

        public virtual DeptMaster DeptMaster { get; set; }
    }
}
