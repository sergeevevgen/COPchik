using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class TreeCustom : UserControl
    {
        public TreeCustom()
        {
            InitializeComponent();
        }

        public void CreateTree<T>(List<T> elements) where T : class, new()
        {
            var properties = elements.First().GetType().GetProperties();
            var fields = elements.First().GetType().GetFields();
            var i = new List<TreeNode>();
            foreach (var element in elements)
            {
                i.Add(treeView.Nodes.Add(properties[0].GetValue(element).ToString()));
            }
        }
    }
}
