using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string CustomerFIO { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string Mail { get; set; }
    }
}