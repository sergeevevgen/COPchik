using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.ViewModels
{
    public class OrderViewModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("ФИО покупателя")]
        public string CustomerFIO { get; set; }

        public byte[] Image { get; set; }
        [DisplayName("Выбранный товар")]
        public Dictionary<string, int> Products { get; set; }
        [DisplayName("Почта")]
        public string Mail { get; set; }
    }
}
