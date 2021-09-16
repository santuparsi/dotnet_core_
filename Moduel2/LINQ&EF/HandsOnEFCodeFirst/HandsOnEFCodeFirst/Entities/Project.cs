using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst.Entities
{
    [Table("Project")]
    class Project
    {
        [Key]
        [Column(TypeName ="Char")]
        [StringLength(5)]
        public string ProjectCode { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName ="varchar")]
        public string ProjectName { get; set; }
    }
}
