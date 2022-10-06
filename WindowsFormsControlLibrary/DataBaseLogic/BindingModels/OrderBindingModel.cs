
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.BindingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public string CustomerFIO { get; set; }

        public byte[] Image { get; set; }
        public Dictionary<string, int> Products { get; set; }
        public string Mail { get; set; }
    }
}
