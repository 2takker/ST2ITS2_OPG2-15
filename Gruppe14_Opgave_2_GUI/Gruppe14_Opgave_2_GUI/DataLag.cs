using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    class DataLag
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string db = "F17ST2ITS2201500391";

        public DataLag()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + db +
                ";Persist Security Info=True; User ID=" + db + ";Password=" + db + "");
        }

        public double getHoejde(string cpr)
        {
            double result = 0.0;

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                result = Convert.ToDouble(rdr["Hoejde"]);
            }

            conn.Close();

            return result;
        }

        public double getVaegt(string cpr)
        {
            double result = 0.0;

            cmd = new SqlCommand("SELECT * FROM db_owner.opg2_Vaegt WHERE cpr='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                result = Convert.ToDouble(rdr["Vaegt"]);
            }

            conn.Close();

            return result;
        }



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
