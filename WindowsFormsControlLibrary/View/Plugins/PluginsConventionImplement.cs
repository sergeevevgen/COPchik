using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Plugins
{
    public class PluginsConventionImplement : IPluginsConvention
    {
        public string PluginName => throw new NotImplementedException();

        public UserControl GetControl => throw new NotImplementedException();

        public PluginsConventionElement GetElement => throw new NotImplementedException();

        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            throw new NotImplementedException();
        }

        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            throw new NotImplementedException();
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            throw new NotImplementedException();
        }

        public bool DeleteElement(PluginsConventionElement element)
        {
            throw new NotImplementedException();
        }

        public Form GetForm(PluginsConventionElement element)
        {
            throw new NotImplementedException();
        }

        public void ReloadData()
        {
            throw new NotImplementedException();
        }
    }
}
