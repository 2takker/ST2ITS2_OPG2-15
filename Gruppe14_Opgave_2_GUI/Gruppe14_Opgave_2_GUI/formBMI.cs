using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logik;

namespace Gruppe14_Opgave_2_GUI
{
    public partial class formBMI : Form
    {
        string cpr_;
        logikLag lk = new logikLag();

        public formBMI(string cpr)
        {
            InitializeComponent();

            cpr_ = cpr;

            txtBoxBMI.Text = Convert.ToString(Math.Round(lk.udregnBMI(cpr),1));
        }
    }
}
