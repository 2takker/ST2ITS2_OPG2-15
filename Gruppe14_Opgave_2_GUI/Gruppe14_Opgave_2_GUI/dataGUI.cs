using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppe14_Opgave_2_GUI
{
    public partial class dataGUI : Form
    {
        formBS BSform1;
        formBT BTform1;
        formBMI BMIform1;

        public dataGUI()
        {
            InitializeComponent();
            
            BTform1 = new formBT();
            BMIform1 = new formBMI();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            BSform1 = new formBS(dtpStart.Value, dtpSlut.Value);
            BSform1.ShowDialog();
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            BTform1.ShowDialog();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMIform1.ShowDialog();
        }
    }
}
