using lab1COP.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Plugins.PluginsImplements
{
    public class MainPluginConvention : IPluginsConvention
    {
        public OutputComponent tableView;
        public OrderLogic orderLogic;
        public ProductLogic productLogic;

        public MainPluginConvention()
        {
            tableView = new OutputComponent();
            orderLogic = new OrderLogic();
            productLogic = new ProductLogic();
            ReloadData();
        }

        public string PluginName => "Orders";

        public UserControl GetControl => tableView;

        public PluginsConventionElement GetElement => tableView.GetSelectedObject<PluginsConventionElement>();

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
            
        }

        public System.Windows.Forms.Form GetForm(PluginsConventionElement element)
        {
            throw new NotImplementedException();
        }

        public void ReloadData()
        {
            tableView.ClearStrings();
            var data = orderLogic.Read(null);
            var element = data[0];
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            foreach(var prop in element.GetType().GetProperties())
            {
                if (prop.Name.Equals("Id") || prop.Name.Equals("id"))
                {
                    columns.Add(new DataGridViewColumn()
                    {
                        HeaderText = prop.Name,
                        Width = 200,
                        Visible = false,
                        DataPropertyName = prop.Name
                    });
                }
                else
                {
                    columns.Add(new DataGridViewColumn()
                    {
                        HeaderText = prop.Name,
                        Width = 200,
                        Visible = true,
                        DataPropertyName = prop.Name
                    });
                }
            }
            tableView.ConfigureDataGridView(columns);
            tableView.FillDataGrid(data);
        }
    }
}