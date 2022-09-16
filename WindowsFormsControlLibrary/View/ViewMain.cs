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
    public partial class ViewMain : Form
    {
        public ViewMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //For first element
            List<string> list1 = new List<string>();
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                string newStr = "";
                for(int j = 0; j < 8; ++j)
                {
                    char a = (char) (random.Next(94) + 33);
                    newStr += a;
                }
                list1.Add(newStr);
            }
            selectedListBox.FillList(list1);
            selectedListBox.SelectedElement = list1[random.Next(list1.Count)];
            
            //For second element
            DateTime timeFrom = new DateTime(1950, 12, 31, 23, 59, 59);
            DateTime timeTo = new DateTime(2100, 12, 31, 23, 59, 59);
            timePickBox.DateTo = timeTo;
            timePickBox.DateFrom = timeFrom;


            List<Car> cars = new List<Car>();
            Car car = new Car();
            car.VIN = "123XCSADAS23";
            car.Brand = "VW";
            car.Model = "Polo";
            cars.Add(car);
            Car car1 = new Car();
            car1.VIN = "453534SFAFAFAF";
            car1.Brand = "VW";
            car1.Model = "Polo";
            cars.Add(car1);
            Car car2 = new Car();
            car2.VIN= "676SADAS423";
            car2.Brand = "VW";
            car2.Model = "Passat";
            cars.Add(car2);
            Car car3 = new Car();
            car3.VIN = "asda1231";
            car3.Brand = "Honda";
            car3.Model = "Civic";
            cars.Add(car3);
            Car car4 = new Car();
            car4.VIN = "231sfadaghjf";
            car4.Brand = "Ford";
            car4.Model = "F-150";
            cars.Add(car4);
            Car car5 = new Car();
            car5.VIN = "tuytrytr1";
            car5.Brand = "Ford";
            car5.Model = "Focus";
            cars.Add(car5);
            Car car6 = new Car();
            car6.VIN = "231sfadaghjf";
            car6.Brand = "Ford";
            car6.Model = "F-150";
            cars.Add(car6);
            treeCustom.SetConfig(new List<string>() { "Brand", "Model", "VIN" });
            treeCustom.CreateTree(cars);
        }

        private void button_Click(object sender, EventArgs e)
        {
            var car = treeCustom.GetSelectedNode<Car>();
            MessageBox.Show(car.Brand + " " + car.Model + " " + car.VIN);
        }
    }
}