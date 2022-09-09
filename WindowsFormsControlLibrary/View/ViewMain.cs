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
            //For second element
            DateTime timeFrom = new DateTime(1950, 12, 31, 23, 59, 59);
            DateTime timeTo = new DateTime(2100, 12, 31, 23, 59, 59);
            timePickBox.DateTo = timeTo;
            timePickBox.DateFrom = timeFrom;
        }
    }
}