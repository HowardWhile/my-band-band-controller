using AIM.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_pid
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            controller_init();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbox_mode.SelectedIndex = 0;
        }

        #region Controller_And_Plant

        ON_OFF_Controller_general generl_ctrl;
        ON_OFF_Controller_hysteresis hysteresis_ctrl;
        ON_OFF_Controller_deadband deadband_ctrl;
        private void controller_init()
        {
            this.gain = (double)this.num_gain.Value;

            this.generl_ctrl = new ON_OFF_Controller_general();
            this.hysteresis_ctrl = new ON_OFF_Controller_hysteresis((double)this.num_hysteresis.Value);
            this.deadband_ctrl = new ON_OFF_Controller_deadband((double)this.num_deadband.Value);

        }

        double controller_output = 0.0;
        double plant_feedback = 0.0;
        double gain;
        int OnOff;
        private void tmr_controller_Tick(object sender, EventArgs e)
        {
            if (this.cbox_mode.SelectedIndex == 0)
            {
                this.OnOff = this.generl_ctrl.Update_Once(this.tbar_setpoint.Value, this.plant_feedback);

                if (this.OnOff == 1)
                    this.controller_output += this.gain;
                if (this.OnOff == 0)
                    this.controller_output -= this.gain;
            }
            else if (this.cbox_mode.SelectedIndex == 1)
            {
                this.OnOff = this.hysteresis_ctrl.Update_Once(this.tbar_setpoint.Value, this.plant_feedback);

                if (this.OnOff == 1)
                    this.controller_output += this.gain;
                if (this.OnOff == 0)
                    this.controller_output -= this.gain;
            }
            else if (this.cbox_mode.SelectedIndex == 2)
            {
                this.deadband_ctrl.DB2H = 1.0;

                this.OnOff = this.deadband_ctrl.Update_Once(this.tbar_setpoint.Value, this.plant_feedback);
                if (this.OnOff == 1)
                    this.controller_output += this.gain; // FWD
                if (this.OnOff == 0)
                {
                    // IDLE
                }
                if (this.OnOff == -1)
                    this.controller_output -= this.gain; // BWD

            }
            else if (this.cbox_mode.SelectedIndex == 3)
            {
                this.deadband_ctrl.Hysteresis = (double)this.num_hysteresis.Value;

                this.OnOff = this.deadband_ctrl.Update_Once(this.tbar_setpoint.Value, this.plant_feedback);
                if (this.OnOff == 1)
                    this.controller_output += this.gain; // FWD
                if (this.OnOff == 0)
                {
                    // IDLE
                }
                if (this.OnOff == -1)
                    this.controller_output -= this.gain; // BWD
            }
        }

        private void tmr_plant_sim_Tick(object sender, EventArgs e)
        {
            double PV = this.plant_feedback;

            PV = PV + (this.controller_output * 0.20) - (PV * 0.10);

            this.clamp(ref PV, -1000.1, 1000);

            this.plant_feedback = PV;

            this.update_chart_data();

        }

        private void ckbox_stop_controller_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = !this.ckbox_stop_controller.Checked;
            this.tmr_display.Enabled = enable;
            this.tmr_plant_sim.Enabled = enable;
            this.tmr_controller.Enabled = enable;
        }
        public void clamp(ref double io_value, double i_min, double i_max)
        {
            if (io_value < i_min)
                io_value = i_min;

            if (io_value > i_max)
                io_value = i_max;
        }

        #endregion

        #region Controller_Parameter
        private void num_ValueChanged(object sender, EventArgs e)
        {
            this.gain = (double)this.num_gain.Value;
            this.hysteresis_ctrl.Hysteresis = (double)this.num_hysteresis.Value;
            this.deadband_ctrl.DeadBand = (double)this.num_deadband.Value;            
        }

        private void tbar_interval_ms_Scroll(object sender, EventArgs e)
        {
            int ms = tbar_interval_ms.Value;
            this.tmr_controller.Interval = ms;
            this.gbox_interval.Text = $"Interval = {ms}ms";
        }

        private void tbar_setpoint_Scroll(object sender, EventArgs e)
        {
            this.gbox_setpoint.Text = $"Setpoint = {this.tbar_setpoint.Value}";
        }

        #endregion

        #region chart
        private List<double> data_setpoint = new List<double>();
        private double[] plt_data_setpoint = new double[1000];
        private ScottPlot.PlottableSignal plt_setpoint;

        private List<double> data_feedback = new List<double>();
        private double[] plt_data_feedback = new double[1000];
        private ScottPlot.PlottableSignal plt_feedback;

        private void chart_pid_Load(object sender, EventArgs e)
        {
            this.plt_setpoint = this.chart_pid.plt.PlotSignal(this.plt_data_setpoint, label: "Setpoint");
            this.plt_feedback = this.chart_pid.plt.PlotSignal(this.plt_data_feedback, label: "Feedback");
            this.plt_setpoint.maxRenderIndex = 0;
            this.plt_feedback.maxRenderIndex = 0;

            this.chart_pid.plt.XLabel("Step (times)");
            this.chart_pid.plt.YLabel("Process Value");
            this.chart_pid.plt.Legend(location: ScottPlot.legendLocation.lowerLeft);
        }

        int shift_index = 0;
        private void update_chart_data()
        {
            this.data_setpoint.Add(this.tbar_setpoint.Value);
            this.data_feedback.Add(this.plant_feedback);

            if (this.data_setpoint.Count > this.plt_data_setpoint.Length)
            {
                this.data_setpoint.RemoveAt(0);
                this.data_feedback.RemoveAt(0);
                this.shift_index++;
            }

            this.data_setpoint.CopyTo(this.plt_data_setpoint, 0);
            this.data_feedback.CopyTo(this.plt_data_feedback, 0);

            this.plt_setpoint.maxRenderIndex = this.data_setpoint.Count - 1;
            this.plt_feedback.maxRenderIndex = this.data_feedback.Count - 1;

            this.plt_setpoint.xOffset = this.shift_index;
            this.plt_feedback.xOffset = this.shift_index;

            this.chart_pid.plt.AxisBounds(minX: this.shift_index);

        }
        #endregion

        private void tmr_display_Tick(object sender, EventArgs e)
        {
            this.chart_pid.plt.AxisAuto();
            this.chart_pid.Render();
            this.dtxt_output.Text = $"{this.controller_output:0.0000}";
            this.stxt_output.Text = $"Output {this.OnOff}";
        }

        private void cbox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbox_mode.SelectedIndex;

            switch (idx)
            {
                case 0:
                    this.gbox_hysteresis.Enabled = false;
                    this.gbox_deadband.Enabled = false;
                    break;
                case 1:
                    this.gbox_hysteresis.Enabled = true;
                    this.gbox_deadband.Enabled = false;
                    break;
                case 2:
                    this.gbox_hysteresis.Enabled = false;
                    this.gbox_deadband.Enabled = true;
                    break;
                case 3:
                    this.gbox_hysteresis.Enabled = true;
                    this.gbox_deadband.Enabled = true;
                    break;
                default:
                    break;
            }

        }
    }
}
