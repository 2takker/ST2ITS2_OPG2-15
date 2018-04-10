using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace Data
{
    class DataBase : IData
    {
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        private const String DBLogin = "F17ST2ITS2201500391";
        private List<DTO_Weight> patientVaegt;
        private List<DTO_BSugar> patientBS;
        private List<DTO_BPressure> patientBT;


        public DataBase()
        {
            connection = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + DBLogin +
                ";Persist Security Info=True; User ID=" + DBLogin + ";Password=" + DBLogin + "");
        }

        public bool isUserRegistered(String SocSecNb, String pw)
        {
            command = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + SocSecNb + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (pw != null && (string)reader["password"] == pw)
                {
                    connection.Close();
                    return true;
                }
            }

            connection.Close();

            return false;
        }

        public int getHeight(String SocSecNb)
        {
            int hoejdeResult = -1;

            command = new SqlCommand("SELECT * FROM db_owner.opg2_Patient WHERE cpr='" + SocSecNb + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                hoejdeResult = Convert.ToInt32(reader["Hoejde"]);
            }

            connection.Close();

            return hoejdeResult;
        }

        public List<DTO_Weight> getWeightData(String SocSecNb)
        {
            patientVaegt = new List<DTO_Weight>();
            DateTime dateResult = DateTime.Now;
            double vaegtResult = 0.0;


            command = new SqlCommand("SELECT * FROM db_owner.opg2_Vaegt WHERE cpr='" + SocSecNb + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                vaegtResult = Convert.ToDouble(reader["Vaegt"]);
                dateResult = Convert.ToDateTime(reader["maaleTidspunkt"]);

                patientVaegt.Add(new DTO_Weight(vaegtResult, -1, dateResult));
            }
            connection.Close();

            return patientVaegt;
        }

      
        public List<DTO_BSugar> getBSugarData(String SocSecNb)
        {
            patientBS = new List<DTO_BSugar>();
            DateTime date = DateTime.Now;
            double resultBS = 0.0;

            command = new SqlCommand("SELECT * FROM db_owner.opg2_BS WHERE cpr='" + SocSecNb + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();

            while(reader.Read())
            {
                resultBS = Convert.ToDouble(reader["BS"]);
                date = Convert.ToDateTime(reader["maaleTidspunkt"]);

                patientBS.Add(new DTO_BSugar(resultBS, date));
            }
            
            connection.Close();

            return patientBS;
        }

        public List<DTO_BPressure> getBPressureData(String SocSecNb)
        {
            patientBT = new List<DTO_BPressure>();
            DateTime date = DateTime.Now;
            int sBT = 0;
            int dBT = 0;

            command = new SqlCommand("SELECT * FROM db_owner.opg2_BT WHERE cpr='" + SocSecNb + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();

            while(reader.Read())
            {
                sBT = Convert.ToInt32(reader["sBT"]);
                dBT = Convert.ToInt32(reader["dBT"]);
                date = Convert.ToDateTime(reader["maaleTidspunkt"]);

                patientBT.Add(new DTO_BPressure(sBT, dBT, date));
            }

            connection.Close();

            return patientBT;
        }  
    }
}
