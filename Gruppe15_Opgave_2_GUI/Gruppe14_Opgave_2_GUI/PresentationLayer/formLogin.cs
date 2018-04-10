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

namespace Gruppe15_Opgave_2_GUI
{
    public partial class formLogin : Form
    {
        private bool _validLogin;
        private readonly Login _login;
        private readonly ILogic _logic;
        private readonly dataGUI _dataGui;

        public formLogin(Login login, ILogic logic, dataGUI dataGui)
        {
            InitializeComponent();

            _login = login;
            _logic = logic;
            _dataGui = dataGui;

            _dataGui.Enabled = false;

            _validLogin = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_logic.checkLogin(SocSecBox.Text, PwBox.Text))
            {
                _login.SocSecNb = SocSecBox.Text;
                _validLogin = true;

                _dataGui.Enabled = true;

                Hide();
            }
            else
            {
                MessageBox.Show("Ugyldigt login");
            }
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_validLogin)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void PwBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
