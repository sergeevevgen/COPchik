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
    public partial class TimePickBox : UserControl
    {
        public TimePickBox()
        {
            InitializeComponent();
        }

        public DateTime DateFrom = DateTime.MinValue;
        public DateTime DateTo = DateTime.MaxValue;
        private DateTime TimePrev { get; set; }
        
        public DateTime? TimePicked 
        {
            get
            {
                if (dateTimePicker.Value < DateFrom || dateTimePicker.Value > DateTo)
                {
                    labelError.Text = $"From {DateFrom} to {DateTo}";
                    labelError.BackColor = Color.Red;
                    return null;
                }
                labelError.Text = string.Empty;
                labelError.BackColor = BackColor;
                return dateTimePicker.Value;
            }
            set
            {
                if (value < DateFrom || value > DateTo)
                {  
                    labelError.Text = $"From {DateFrom} to {DateTo}";
                    labelError.BackColor = Color.Red;
                    return;
                }
                labelError.Text = string.Empty;
                labelError.BackColor = BackColor;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            TimePicked = dateTimePicker.Value;
            if (TimePrev != TimePicked && TimePicked != null)
            {
                BackColor = Color.FromArgb(random.Next(256),
                    random.Next(256),
                    random.Next(256));
                TimePrev = TimePicked.Value;
            }
        }
    }
}
