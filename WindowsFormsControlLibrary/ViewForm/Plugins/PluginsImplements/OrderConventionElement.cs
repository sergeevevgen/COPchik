using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Plugins.PluginsImplements
{
    public class OrderConventionElement : PluginsConventionElement
    {
        public string CustomerFIO { get; set; }
        public byte[] Image { get; set; }
        public Dictionary<string, int> Products { get; set; }
        public string Mail { get; set; }
    }
}