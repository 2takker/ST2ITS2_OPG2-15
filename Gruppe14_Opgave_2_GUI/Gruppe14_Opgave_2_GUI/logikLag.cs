using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logik
{
    class logikLag
    {
        DataLag db = new DataLag();

        public double udregnBMI(string cpr)
        {
            double result = 0;
            double hoejde = db.getHoejde(cpr);
            double vaegt = db.getVaegt(cpr);

            result = (vaegt / Math.Pow(hoejde,2));

            return result;
        }


    }
}
