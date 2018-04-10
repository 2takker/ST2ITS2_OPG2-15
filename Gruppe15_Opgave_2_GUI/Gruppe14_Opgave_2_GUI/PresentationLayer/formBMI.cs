using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Gruppe15_Opgave_2_GUI
{
    public partial class formBMI : Form
    {
        public formBMI(List<DTO_Weight> weights)
        {
            InitializeComponent();

            foreach (var e in weights)
            {
                chartBMI.Series["Vaegt"].Points.AddXY(e.Date_, e.Weight_);
                chartBMI.Series["BMI"].Points.AddXY(e.Date_, e.BMI_);}
        }
    }
}
