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

        private TreeView treeViewCustom;

        private static void CreateTree(List<T> tree)
        {
            treeViewCustom.Nodes.Clear();
        }

        public void AddNode()
        {

        }

    }
}
