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
    public partial class formBT : Form
    {
        public formBT(List<DTO_BPressure> bPressures)
        {
            InitializeComponent();

            foreach (var e in bPressures)
            {
                chartBT.Series["Systole"].Points.AddXY(e.Date_, e.Systolic_);
                chartBT.Series["Diastole"].Points.AddXY(e.Date_, e.Diastolic_);
            }
        }
    }
}
