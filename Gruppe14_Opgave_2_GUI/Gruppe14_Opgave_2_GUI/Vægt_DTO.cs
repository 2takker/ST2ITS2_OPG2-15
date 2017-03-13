using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Vægt_DTO
    {
        private double weight_;
        private double bmi_;
        private double fat_;
        private DateTime dt_;

        public Vægt_DTO(double weight)
        {
            weight_ = weight;
            bmi_ = 0;
            fat_ = 0;
            dt_ = DateTime.Now;
        }
        public Vægt_DTO(double weight, DateTime dt)
        {
            weight_ = weight;
            bmi_ = 0;
            fat_ = 0;
            dt_ = dt;
        }
        public void setWeight(double weight)
        {
            weight_ = weight;
        }

        public double getWeight()
        {
            return weight_;
        }

        public void setBMI(double bmi)
        {
            bmi_ = bmi;
        }

        public double getBMI()
        {
            return bmi_;
        }

        public void setFat(double fat)
        {
            fat_ = fat;
        }

        public double getFat()
        {
            return fat_;
        }

        public void setDateTime(DateTime dt)
        {
            dt_ = dt;
        }

        public DateTime getDateTime()
        {
            return dt_;
        }

        public override string ToString()
        {
            return dt_+": Vægt: "+weight_+"   \tBMI: "+ bmi_ + "  \tFedt%: "+ fat_;
        }
    }
}
