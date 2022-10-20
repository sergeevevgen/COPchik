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
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Id",
                Width = 10,
                Visible = false,
                DataPropertyName = "Id"
            });
            columns.Add(new DataGridViewColumn()
            {
                HeaderText = "CustomerFIO",
                Width = 50,
                Visible = true,
                DataPropertyName = "CustomerFIO",
            });
            columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Image",
                Width = 50,
                Visible = true,
                DataPropertyName = "Image",
            });
            columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Product",
                Width = 50,
                Visible = true,
                DataPropertyName = "Product",
            });
            columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Mail",
                Width = 50,
                Visible = true,
                DataPropertyName = "Mail",
            });
            tableView.ConfigureDataGridView(columns);
            //var list = new List<ProductBindingModel>() { new ProductBindingModel() { Name = "Говяжий фарш"}, new ProductBindingModel() { Name = "бургер" } };
            //foreach(var item in list)
            //{
            //    productLogic.CreateOrUpdate(item);
            //}
            ReloadData();
        }

        public string PluginName => "Заказы";

        public UserControl GetControl => tableView;

        PluginsConventionElement IPluginsConvention.GetElement => tableView.GetSelectedObject<PluginsConventionElement>();

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
            ReloadData();
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
                tableView.FillDataGrid(data);
            }
        }
    }
}