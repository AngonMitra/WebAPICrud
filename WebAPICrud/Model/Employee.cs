using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPICrud.Model
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Doj { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationID { get; set; }

        [NotMapped]
        public string Designation { get; set; }
    }
}
