using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst.Entities
{
    [Table("Employee")]
    class Employee
    {
        [Key] //set as a primary key
        public int Eid { get; set; }
        [Required] //set as not null
        [StringLength(20)]
        public string Ename { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? JoinDate { get; set; } //set as null
        public int? Salary { get; set; } //set as null
        [Column("Designation",TypeName ="Varchar")]
        [StringLength(20)]
        public string Desig { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(5)]
        [ForeignKey("Project")]
        public string ProjectCode { get; set; }
        public Project Project { get; set; } //navigation property

    }
}
