using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logik;
using DTO;

namespace Gruppe14_Opgave_2_GUI
{
    public partial class formBS : Form
    {
        LogikStub ls1;
        List<BS_DTO> BSliste;


        public formBS(DateTime startDato, DateTime slutDato)
        {
            InitializeComponent();
            ls1 = new LogikStub();
            BSliste = ls1.getBS("Ligegyldig string...");

            foreach (var ele in BSliste)
            {
                if (ele.getDateTime() >= startDato && ele.getDateTime() <= slutDato)
                {
                    chartBS.Series["Blodsukker"].Points.AddXY(ele.getDateTime(), ele.getBloodSugar());
                }
            }
        }


    }
}
