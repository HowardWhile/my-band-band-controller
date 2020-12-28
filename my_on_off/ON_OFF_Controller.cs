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

    }

    class ON_OFF_Controller_deadband
    {
        ON_OFF_Controller_deadband(double iDeadBand, double iDB_Proportion = 0.5, bool iReverse = false)
        {
            this.DeadBand = iDeadBand;
            this.DeadBand_Proportion = iDB_Proportion;
            this.IsOutputReverse = iReverse;
        }

        // return 1: FWD, 0: OFF, -1 BWD
        public int Update_Once(double setpoint, double feedback)
        {
            // ON OFF
            bool enable;
            double err = Math.Abs(setpoint - feedback);
            if (err > this.DeadBand)
            {
                enable = true;
            }
            else
            {
                double accuracy_div = this.DeadBand * this.DeadBand_Proportion;
                if (err < accuracy_div)
                {
                    enable = false; // off
                }
                else
                {
                    enable = this.last_status; // 維持之前狀態
                }
            }
            this.last_status = enable;

            // FWD BWD
            int rValue;
            if (enable)
                rValue = setpoint > feedback ? 1 : -1;
            else
                rValue = 0;

            // Reverse
            if (this.IsOutputReverse)
                rValue = -rValue;

            return rValue;

        }

        public double DeadBand;
        public double DeadBand_Proportion;
        public bool IsOutputReverse;

        private bool last_status = false;

    }
}
