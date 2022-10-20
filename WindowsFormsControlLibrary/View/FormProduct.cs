using DataBaseLogic.BindingModels;
using DataBaseLogic.Logics;
using DataBaseLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormProduct : Form
    {

        private ProductLogic productLogic;
        List<ProductViewModel> list;
        public FormProduct()
        {
            productLogic = new ProductLogic();
            list = new List<ProductViewModel>();
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                list = productLogic.Read(null);
                if (list != null)
                {
                    dataGridViewUnits.DataSource = list;
                    dataGridViewUnits.Columns[0].Visible = false;
                    dataGridViewUnits.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUnits_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewUnits_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = (string)dataGridViewUnits.CurrentRow.Cells[1].Value;
            if (!string.IsNullOrEmpty(typeName))
            {
                if (dataGridViewUnits.CurrentRow.Cells[0].Value != null)
                {
                    productLogic.CreateOrUpdate(new ProductBindingModel()
                    {
                        Id = Convert.ToInt32(dataGridViewUnits.CurrentRow.Cells[0].Value),
                        Name = (string)dataGridViewUnits.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    productLogic.CreateOrUpdate(new ProductBindingModel()
                    {
                        Name = (string)dataGridViewUnits.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridViewUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                if (dataGridViewUnits.Rows.Count == 0)
                {
                    list.Add(new ProductViewModel());
                    dataGridViewUnits.DataSource = new List<ProductViewModel>(list);
                    dataGridViewUnits.CurrentCell = dataGridViewUnits.Rows[0].Cells[1];
                    return;
                }
                if (dataGridViewUnits.Rows[dataGridViewUnits.Rows.Count - 1].Cells[1].Value != null)
                {
                    list.Add(new ProductViewModel());
                    dataGridViewUnits.DataSource = new List<ProductViewModel>(list);
                    dataGridViewUnits.CurrentCell = dataGridViewUnits.Rows[dataGridViewUnits.Rows.Count - 1].Cells[1];
                    return;
                }
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productLogic.Delete(new ProductBindingModel() { Id = (int)dataGridViewUnits.CurrentRow.Cells[0].Value });
                    LoadData();
                }
            }
        }
    }
}