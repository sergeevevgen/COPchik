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
            car.Price = 500000;
            car.Name = "VW";
            cars.Add(car);
            Car car1 = new Car();
            car1.VIN = "453534SFAFAFAF";
            car1.Price = 300000;
            car1.Name = "Ford";
            cars.Add(car1);
            Car car2 = new Car();
            car2.VIN= "676SADAS423";
            car2.Price = 7999999;
            car2.Name = "Lamba";
            cars.Add(car2);
            treeCustom.CreateTree(cars);
        }
    }
}