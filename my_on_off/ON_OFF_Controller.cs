using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Modules
{
    // https://x-engineer.org/graduate-engineering/signals-systems/control-systems/on-off-control-system/

    class ON_OFF_Controller_general
    {
        public ON_OFF_Controller_general()
        {

        }        

        // return 1: ON, 0: OFF
        public int Update_Once(double setpoint, double feedback)
        {
            double err = setpoint - feedback;
            if (err > 0)
                return 1;
            else
                return 0;
        }

    }

    class ON_OFF_Controller_hysteresis 
    {
        public ON_OFF_Controller_hysteresis(double iHysteresis)
        {
            this.Hysteresis = iHysteresis;
        }
        public int Update_Once(double setpoint, double feedback)
        {
            double err = feedback - setpoint;
            double H2 = this.Hysteresis / 2;
            if (err > H2)
            {
                this.last_status = 0;
                return 0;
            }
            else if (err < -H2)
            {
                this.last_status = 1;
                return 1;
            }
            else
                return this.last_status;
        }

        public double Hysteresis;

        private int last_status;

    }

    class ON_OFF_Controller_deadband
    {
        public ON_OFF_Controller_deadband(double iDeadBand, double iDB2H_scale = 1.0)
        {
            this.DeadBand = iDeadBand;
            this.Hysteresis = this.DeadBand * iDB2H_scale;
        }

        // return 1: FWD, 0: OFF, -1 BWD
        public int Update_Once(double setpoint, double feedback)
        {
            double err = setpoint - feedback;
            double H2 = this.Hysteresis / 2;
            if (err > H2)
            {
                this.last_status = 1;
                return 1;
            }
            else if (err < -H2)
            {
                this.last_status = -1;
                return -1;
            }
            else
            {
                double DB2 = this.DeadBand / 2;
                if (Math.Abs(err) <= DB2)
                {
                    this.last_status = 0;
                    return 0;
                }
                else
                {
                    return this.last_status;
                }
            }
        }

        public double DeadBand;
        public double Hysteresis;
        private int last_status = 0;

        public double DB2H 
        { 
            get => Hysteresis/DeadBand; 
            set => Hysteresis = DeadBand*value; 
        }
    }
}
