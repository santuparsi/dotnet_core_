using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Eshoppy.UI.Models
{
    public class Item
    {
        
        public int ItemId { get; set; }
        [Required(ErrorMessage ="Pls Enter Name")]
        public string ItemName { get; set; }
        [Required(ErrorMessage ="Pls Enter Price")]
        public int? Price { get; set; }
        [Required(ErrorMessage ="Pls Enter Stock")]
        public int? Stock { get; set; }
    }
}
