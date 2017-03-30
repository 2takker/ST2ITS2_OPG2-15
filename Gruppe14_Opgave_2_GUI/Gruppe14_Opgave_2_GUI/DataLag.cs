using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace Data
{
    class DataLag
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string db = "F17ST2ITS2201500391";
        private List<Vaegt_DTO> patientVaegt;
        private List<BS_DTO> patientBS;
        private List<BT_DTO> patientBT;


        public DataLag()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + db +
                ";Persist Security Info=True; User ID=" + db + ";Password=" + db + "");
        }

        public List<Vaegt_DTO> getPatientVaegt(string cpr)
        {
            patientVaegt = new List<Vaegt_DTO>();
            DateTime dateResult = DateTime.Now;
            double vaegtResult = 0.0;
            double hoejdeResult = 0.0;

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Vaegt WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                vaegtResult = Convert.ToDouble(rdr["Vaegt"]);
                dateResult = Convert.ToDateTime(rdr["maaleTidspunkt"]);

                patientVaegt.Add(new Vaegt_DTO(vaegtResult, dateResult));
            }

            conn.Close();

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            if(rdr.Read())
            {
                hoejdeResult = Convert.ToDouble(rdr["Hoejde"]);
                foreach(var ele in patientVaegt)
                {
                    ele.setHoejde(hoejdeResult);
                }
            }

            conn.Close();

            return patientVaegt;
        }

      
        public List<BS_DTO> getPatientBS(string cpr)
        {
            patientBS = new List<BS_DTO>();
            DateTime date = DateTime.Now;
            double resultBS = 0.0;

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_BS WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                resultBS = Convert.ToDouble(rdr["BS"]);
                date = Convert.ToDateTime(rdr["maaleTidspunkt"]);

                patientBS.Add(new BS_DTO(resultBS, date));
            }
            
            conn.Close();

            return patientBS;
        }

        public List<BT_DTO> getPatientBT(string cpr)
        {
            patientBT = new List<BT_DTO>();
            DateTime date = DateTime.Now;
            int sBT = 0;
            int dBT = 0;

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_BT WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                sBT = Convert.ToInt32(rdr["sBT"]);
                dBT = Convert.ToInt32(rdr["dBT"]);
                date = Convert.ToDateTime(rdr["maaleTidspunkt"]);

                patientBT.Add(new BT_DTO(sBT, dBT, date));
            }

            conn.Close();

            return patientBT;
        }



        //private double getHoejde(string cpr)
        //{
        //    double result = 0.0;

        //    cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + cpr + "'", conn);

        //    conn.Open();

        //    rdr = cmd.ExecuteReader();

        //    if(rdr.Read())
        //    {
        //        result = Convert.ToDouble(rdr["Hoejde"]);
        //    }

        //    conn.Close();

        //    return result;
        //}

        //private double getVaegt(string cpr)
        //{
        //    double result = 0.0;

        //    cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Vaegt WHERE cpr='" + cpr + "'", conn);

        //    conn.Open();

        //    rdr = cmd.ExecuteReader();

        //    if(rdr.Read())
        //    {
        //        result = Convert.ToDouble(rdr["Vaegt"]);
        //    }

        //    conn.Close();

        //    return result;
        //}



        //public int cprValid(string cpr)
        //{
        //    int result = 0;

        //    cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + cpr + "'", conn);

        //    conn.Open();

        //    rdr = cmd.ExecuteReader();

        //    while (rdr.Read())
        //    {
        //        if (Convert.ToBoolean(rdr["CPR"]))
        //        {
        //            result = 1;
        //        }
        //        else
        //        {
        //            result = 2;
        //        }
        //    }
        //    conn.Close();

        //    return result;
        //}
    }
}
