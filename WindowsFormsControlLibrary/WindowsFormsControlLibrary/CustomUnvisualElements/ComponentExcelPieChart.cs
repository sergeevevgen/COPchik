using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary.CustomUnvisualElements
{
    public partial class ComponentExcelPieChart : Component
    {
        public ComponentExcelPieChart()
        {
            InitializeComponent();
        }

        public ComponentExcelPieChart(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
