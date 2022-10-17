using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibraryKutygin.NonVisualComponents.HelperModels
{
    public class WordTitleColumn
    {
        public string Name { get; set; }
        public decimal Width { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public FieldInfo FieldInfo { get; set; }
    }
}
