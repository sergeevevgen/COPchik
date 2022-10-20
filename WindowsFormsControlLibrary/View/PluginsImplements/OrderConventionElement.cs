using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Plugins;

namespace View.PluginsImplements
{
    public class OrderConventionElement : PluginsConventionElement
    {
        public string CustomerFIO { get; set; }
        public string Image { get; set; }
        public string Product { get; set; }
        public string Mail { get; set; }
    }
}
