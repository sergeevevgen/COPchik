using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary.CustomUnvisualElements
{
    public partial class ComponentExcelCustomizableTable : Component
    {
        public ComponentExcelCustomizableTable()
        {
            InitializeComponent();
        }

        public ComponentExcelCustomizableTable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
