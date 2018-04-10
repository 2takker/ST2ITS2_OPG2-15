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
    public partial class formBS : Form
    {
        public formBS(List<DTO_BSugar> bSugars)
        {
            InitializeComponent();

            foreach (var e in bSugars)
            {
                chartBS.Series["Blodsukker"].Points.AddXY(e.Date_, e.BloodSugar_);
            }
        }
    }
}
