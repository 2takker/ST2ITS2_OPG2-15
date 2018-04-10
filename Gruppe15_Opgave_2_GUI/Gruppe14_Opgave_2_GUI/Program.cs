﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Logic_tier;

namespace Gruppe15_Opgave_2_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dataObject = new DataBase();
            var logicObject = new Logic(dataObject);

            Application.Run(new dataGUI(logicObject));            
        }

        
    }
}
