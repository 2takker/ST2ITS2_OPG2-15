using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace logik
{
    class LogikStub
    {
        private List<BS_DTO> bsList;
        private List<BT_DTO> btList;
        private List<Vægt_DTO> vægtList;

        public LogikStub()
        {
            bsList = new List<BS_DTO>();
            //LoadBSList();
            btList = new List<BT_DTO>();
            //LoadBTList();
            vægtList = new List<Vægt_DTO>();
            //LoadVægtList();
        }

        public List<BS_DTO> getBS(string id)
        {
            return bsList;
        }
        public List<BT_DTO> getBT(string id)
        {
            return btList;
        }
        public List<Vægt_DTO> getVægt(string id)
        {
            return vægtList;
        }

        //private void LoadBSList()
        //{
        //    bsList.Add(new BS_DTO(6.5, new DateTime(2015, 1, 30, 8, 0, 0)));
        //    bsList.Add(new BS_DTO(5.6, new DateTime(2015, 1, 30, 12, 30, 0)));
        //    bsList.Add(new BS_DTO(11.5, new DateTime(2015, 1, 30, 18, 45, 0)));
        //    bsList.Add(new BS_DTO(3.7, new DateTime(2015, 1, 30, 22, 15, 0)));
        //    bsList.Add(new BS_DTO(6.4));
        //    bsList.Add(new BS_DTO(6.0));
        //    bsList.Add(new BS_DTO(7.9));
        //    bsList.Add(new BS_DTO(4.8));
        //    bsList.Add(new BS_DTO(15.3));
        //    bsList.Add(new BS_DTO(6.2));
        //}

        //private void LoadBTList()
        //{
        //    btList.Add(new BT_DTO(120, 80, new DateTime(2015, 1, 30, 8, 0, 0)));
        //    btList.Add(new BT_DTO(110, 75, new DateTime(2015, 1, 31, 8, 0, 0)));
        //    btList.Add(new BT_DTO(140, 95, 68, new DateTime(2015, 2, 10, 18, 37, 0)));
        //    btList.Add(new BT_DTO(145, 105, 72));
        //    btList.Add(new BT_DTO(150, 110));
        //}
        //private void LoadVægtList()
        //{
        //    Vægt_DTO v_dto = new Vægt_DTO(86.5, new DateTime(2015, 1, 30, 8, 0, 0));
        //    vægtList.Add(v_dto);
        //    v_dto = new Vægt_DTO(86.9, new DateTime(2015, 1, 30, 18, 0, 0));
        //    v_dto.setBMI(25.39);
        //    vægtList.Add(v_dto);
        //    vægtList.Add(new Vægt_DTO(87, new DateTime(2015, 1, 31, 8, 0, 0)));
        //    vægtList.Add(new Vægt_DTO(83, new DateTime(2015, 2, 1, 8, 0, 0)));
        //    v_dto = new Vægt_DTO(80.7);
        //    v_dto.setBMI(23.58);
        //    v_dto.setFat(23.7);
        //    vægtList.Add(v_dto);
        //}
    }
}
