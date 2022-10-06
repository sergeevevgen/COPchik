using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLogic.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string CustomerFIO { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [ForeignKey("OrderId")]
        public virtual List<Product> Products { get; set; }
        [Required]
        public string Mail { get; set; }
    }
}
