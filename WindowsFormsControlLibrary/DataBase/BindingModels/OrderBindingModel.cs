
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BindingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public string CustomerFIO { get; set; }
        public byte[] Image { get; set; }
        public string Product { get; set; }
        public string Mail { get; set; }
    }
}