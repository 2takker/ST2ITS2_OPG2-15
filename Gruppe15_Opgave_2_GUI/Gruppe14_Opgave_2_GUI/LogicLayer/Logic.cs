using System;
using System.Collections.Generic;
using DTO;
using Data;

namespace Logic_tier
{
    class Logic : ILogic
    {
        private IData _dataObject;

        public Logic(IData dataObject)
        {
            _dataObject = dataObject;
        }


        public bool checkLogin(String SocSecNb, String pw)
        {
            return _dataObject.isUserRegistered(SocSecNb, pw);
        }

        public List<DTO_BPressure> getBPressureData(String SocSecNb)
        {
            return _dataObject.getBPressureData(SocSecNb);
        }

        public List<DTO_BSugar> getBSugarData(String SocSecNb)
        {
            return _dataObject.getBSugarData(SocSecNb);
        }

        public List<DTO_Weight> getWeightAndBMIData(String SocSecNb)
        {
            double height = Convert.ToDouble(_dataObject.getHeight(SocSecNb)) / 100.0;

            List<DTO_Weight> weights = _dataObject.getWeightData(SocSecNb);

            foreach (var weight in weights)
            {
                weight.BMI_ = Convert.ToInt32(weight.Weight_ / Math.Pow(height, 2));
            }

            return weights;
        }
    }
}