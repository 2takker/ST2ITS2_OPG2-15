using System;
using System.Collections.Generic;
using DTO;

namespace Logic_tier
{
    public interface ILogic
    {
        bool checkLogin(String SocSecNb, String pw);
        List<DTO_BPressure> getBPressureData(String SocSecNb);
        List<DTO_BSugar> getBSugarData(String SocSecNb);
        List<DTO_Weight> getWeightAndBMIData(String SocSecNb);
    }
}