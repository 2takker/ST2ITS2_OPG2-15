using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace Logik
{
    class logikLag
    {
        DataLag db = new DataLag();

        List<Vaegt_DTO> logikPatientVaegt = new List<Vaegt_DTO>();
        List<BS_DTO> logikPatientBS = new List<BS_DTO>();
        List<BT_DTO> logikPatientBT = new List<BT_DTO>();


        public List<Vaegt_DTO> udregnBMI(string cpr)
        {
            logikPatientVaegt = db.getPatientVaegt(cpr);
            double result = 0;

            foreach (var ele in logikPatientVaegt)
            {
                double hoejde = ele.getHoejde();
                double vaegt = ele.getVaegt();

                result = (vaegt / Math.Pow(hoejde, 2));

                ele.setBMI(result);
            }      
            
            return logikPatientVaegt;
        }

        public List<BS_DTO> getPatientBS(string cpr)
        {
            logikPatientBS = db.getPatientBS(cpr);

            return logikPatientBS;
        }

        public List<BT_DTO> getPatientBT(string cpr)
        {
            logikPatientBT = db.getPatientBT(cpr);

            return logikPatientBT;
        }

    }
}
