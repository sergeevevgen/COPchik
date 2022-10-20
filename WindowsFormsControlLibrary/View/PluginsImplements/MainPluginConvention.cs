using DataBaseLogic.BindingModels;
using DataBaseLogic.Logics;
using DataBaseLogic.ViewModels;
using lab1COP.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Plugins;

namespace View.PluginsImplements
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

        public string PluginName => "Заказы";

        public UserControl GetControl => tableView;

        PluginsConventionElement IPluginsConvention.GetElement => Transform();

        private PluginsConventionElement Transform()
        {
            var el = tableView.GetSelectedObject<OrderViewModel>();
            return new OrderConventionElement()
            {
                Id = el.Id,
                CustomerFIO = el.CustomerFIO,
                Mail = el.Mail,
                Product = el.Product,
                Image = el.Image.ToString()
            };
        }

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
            orderLogic.Delete(new OrderBindingModel() { Id = element.Id });
            return true;
        }

        public System.Windows.Forms.Form GetForm(PluginsConventionElement element)
        {
            FormOrder formOrder = new FormOrder();
            if (element != null)
            {
                formOrder.Id = element.Id;
            }
            return formOrder;
        }

        public void ReloadData()
        {
            tableView.ClearStrings();
            var data = orderLogic.Read(null);
            if (data.Count != 0)
            {
                //var list = new List<DataGridViewColumn>();
                //list.Add(new DataGridViewColumn()
                //{
                //    HeaderText = 
                //})
                //for(int i = 0; i < data.Count; i++)
                //{
                //    list.Add(new DataGridViewColumn()
                //    {
                //        He
                //    })
                //}
                var element = data[0];
                List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
                foreach (var prop in element.GetType().GetProperties())
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
}