using System;
using System.Collections.Generic;
using DTO;

namespace Data
{
    public interface IData
    {
        List<DTO_BPressure> getBPressureData(String SocSecNb);
        List<DTO_BSugar> getBSugarData(String SocSecNb);
        int getHeight(String socSecNb);
        List<DTO_Weight> getWeightData(String SocSecNb);
        bool isUserRegistered(String socSecNb, String pw);
    }
}