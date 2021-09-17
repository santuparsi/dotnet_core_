using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShoppy.API.Entities
{
    [Table("Product")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(30)]
        public string ItemName { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
