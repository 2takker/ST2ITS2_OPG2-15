using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_tier;
using Data;

namespace Gruppe15_Opgave_2_GUI
{
    public partial class dataGUI : Form
    {
        private formBS BSform1;
        private formBT BTform1;
        private formBMI BMIform1;
        private ILogic lk;
        private formLogin _formLogin;
        private Login _login;
        

        public dataGUI(ILogic logicObject)
        {
            InitializeComponent();

            _login = new Login();
            lk = logicObject;

            _formLogin = new formLogin(_login, lk, this);

            _formLogin.Show();
            _formLogin.TopMost = true;

            btnBMI.Enabled = true;
            btnBS.Enabled = true;
            btnBT.Enabled = true;
            btnDoctor.Enabled = true;
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            BSform1 = new formBS(lk.getBSugarData(_login.SocSecNb));
            BSform1.ShowDialog();
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            BTform1 = new formBT(lk.getBPressureData(_login.SocSecNb));
            BTform1.ShowDialog();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMIform1 = new formBMI(lk.getWeightAndBMIData(_login.SocSecNb));
            BMIform1.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data for den valgte periode er sendt");
        }
    }
}
