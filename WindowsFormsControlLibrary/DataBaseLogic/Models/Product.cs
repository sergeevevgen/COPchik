﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual Order Order { get; set; }
    }
}
