using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.ViewModels
{
    public class ProductViewModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
