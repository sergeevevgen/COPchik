using DataBase.BindingModels;
using DataBase.Logics;
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
    public partial class FormOrder : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private ProductLogic productLogic = new ProductLogic();
        private OrderLogic orderLogic = new OrderLogic();
        private bool flag = false;
        private byte[] image = null;

        public FormOrder()
        {
            InitializeComponent();
            var productList = productLogic.Read(null);
            var list = new List<string>();
            foreach (var product in productList)
            {
                list.Add(product.Name);
            }
            choiceListProduct.FillList(list);
            choiceListProduct.EventSelectedValueChanged += SmthChanged;
            textBoxMail.TextBoxTextChanged += SmthChanged;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = orderLogic.Read(new OrderBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.CustomerFIO;
                        pictureBox.Image = byteArrayToImage(view.Image);
                        choiceListProduct.ChoosenLine = view.Product;
                        textBoxMail.TextElement = view.Mail;
                        image = view.Image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            flag = false;
        }

        private void SmthChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                if (MessageBox.Show("Сохранить изменения перед закрытием?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save();
                }
            }
        }
        private void Save()
        {
            if (textBoxFIO.Text != string.Empty && choiceListProduct.ChoosenLine != string.Empty && textBoxMail.TextElement != null && image != null)
            {
                flag = false;
                if (id != null)
                {
                    orderLogic.CreateOrUpdate(new OrderBindingModel()
                    {
                        Id = id,
                        CustomerFIO = textBoxFIO.Text,
                        Image = image,
                        Product = choiceListProduct.ChoosenLine,
                        Mail = textBoxMail.TextElement
                    });
                }
                else
                {
                    orderLogic.CreateOrUpdate(new OrderBindingModel()
                    {
                        CustomerFIO = textBoxFIO.Text,
                        Image = image,
                        Product = choiceListProduct.ChoosenLine,
                        Mail = textBoxMail.TextElement
                    });
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите значения");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public Image byteArrayToImage(byte[] bytes)
        {
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Выберите изображение";
            dialog.Filter = "jpg files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image_new = new Bitmap(dialog.FileName);
                pictureBox.Image = image_new;
                image = ImageToByteArray(image_new);  
            }

            dialog.Dispose();
        }
    }
}
