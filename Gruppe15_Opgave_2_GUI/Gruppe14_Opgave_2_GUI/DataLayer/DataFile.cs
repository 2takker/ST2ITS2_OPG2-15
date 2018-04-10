using System;
using System.Collections.Generic;
using System.IO;
using DTO;

namespace Data
{
    class DataFile : IData
    {
        private FileStream input;
        private StreamReader reader;
        private string _fileLocation;

        public DataFile()
        {
            _fileLocation = @"...\...\...\...\";
        }
        
        public List<DTO_BPressure> getBPressureData(String SocSecNb)
        {
            input = new FileStream(_fileLocation + "Blood Pressure Data.txt", FileMode.Open);
            reader = new StreamReader(input);

            List<DTO_BPressure> bPressures = new List<DTO_BPressure>();

            while(!reader.EndOfStream)
            {
                string[] strings = reader.ReadLine()?.Split(';');

                if (strings != null && strings[0] == SocSecNb)
                {
                    int systolic = Convert.ToInt32(strings[1]);
                    int diastolic = Convert.ToInt32(strings[2]);
                    DateTime date = Convert.ToDateTime(strings[3]);

                    DTO_BPressure bPressure = new DTO_BPressure(systolic,diastolic,date);

                    bPressures.Add(bPressure);
                }
            }
            reader.Close();

            return bPressures;
        }

        public List<DTO_BSugar> getBSugarData(String SocSecNb)
        {
            input = new FileStream(_fileLocation +"Blood Sugar Data.txt", FileMode.Open);
            reader = new StreamReader(input);

            List<DTO_BSugar> bSugars = new List<DTO_BSugar>();

            while(!reader.EndOfStream)
            {
                string[] strings = reader.ReadLine()?.Split(';');

                if (strings != null && strings[0] == SocSecNb)
                {
                    double bloodSugar = Convert.ToDouble(strings[1]);
                    DateTime date = Convert.ToDateTime(strings[2]);

                    DTO_BSugar bSugar = new DTO_BSugar(bloodSugar, date);

                    bSugars.Add(bSugar);
                }
            }
            reader.Close();

            return bSugars;
        }

        public int getHeight(String SocSecNb)
        {
            input = new FileStream(_fileLocation +"Registered Users.txt", FileMode.Open);
            reader = new StreamReader(input);

            int height = -1;

            while(!reader.EndOfStream)
            {
                string[] strings = reader.ReadLine()?.Split(';');

                if (SocSecNb != null && strings[0] == SocSecNb)
                {
                    height = Convert.ToInt32(strings[2]);
                }
            }
            reader.Close();

            return height;
        }

        public List<DTO_Weight> getWeightData(String SocSecNb)
        {
            input = new FileStream(_fileLocation + "Weight Data.txt", FileMode.Open);
            reader = new StreamReader(input);

            List<DTO_Weight> weights = new List<DTO_Weight>();

            while(!reader.EndOfStream)
            {
                string[] strings = reader.ReadLine()?.Split(';');

                if (strings != null && SocSecNb == strings[0])
                {
                    double weight = Convert.ToDouble(strings[1]);
                    DateTime date = Convert.ToDateTime(strings[2]);

                    DTO_Weight dtoWeight = new DTO_Weight(weight, -1, date);

                    weights.Add(dtoWeight);
                }
            }
            reader.Close();

            return weights;
        }

        public bool isUserRegistered(String socSecNb, String pw)
        {
            input = new FileStream(_fileLocation + "Registered Users.txt", FileMode.Open);
            reader = new StreamReader(input);

            bool userRegistered = false;

            while(!reader.EndOfStream)
            {
                string[] strings = reader.ReadLine()?.Split(';');

                if (strings != null && (strings[0] == socSecNb && strings[1] == pw))
                {
                    userRegistered = true;
                }
            }
            reader.Close();

            return userRegistered;
        }
    }
}