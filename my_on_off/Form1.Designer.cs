
namespace my_pid
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_controller = new System.Windows.Forms.Timer(this.components);
            this.chart_pid = new ScottPlot.FormsPlot();
            this.num_gain = new System.Windows.Forms.NumericUpDown();
            this.gbox_p = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtxt_output = new System.Windows.Forms.Label();
            this.stxt_output = new System.Windows.Forms.Label();
            this.tmr_display = new System.Windows.Forms.Timer(this.components);
            this.tbar_interval_ms = new System.Windows.Forms.TrackBar();
            this.gbox_interval = new System.Windows.Forms.GroupBox();
            this.gbox_setpoint = new System.Windows.Forms.GroupBox();
            this.tbar_setpoint = new System.Windows.Forms.TrackBar();
            this.tmr_plant_sim = new System.Windows.Forms.Timer(this.components);
            this.ckbox_stop_controller = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_gain)).BeginInit();
            this.gbox_p.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).BeginInit();
            this.gbox_interval.SuspendLayout();
            this.gbox_setpoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_controller
            // 
            this.tmr_controller.Enabled = true;
            this.tmr_controller.Tick += new System.EventHandler(this.tmr_controller_Tick);
            // 
            // chart_pid
            // 
            this.chart_pid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_pid.Location = new System.Drawing.Point(278, 30);
            this.chart_pid.Name = "chart_pid";
            this.chart_pid.Size = new System.Drawing.Size(408, 317);
            this.chart_pid.TabIndex = 1;
            this.chart_pid.Load += new System.EventHandler(this.chart_pid_Load);
            // 
            // num_gain
            // 
            this.num_gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_gain.DecimalPlaces = 5;
            this.num_gain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_gain.Location = new System.Drawing.Point(3, 7);
            this.num_gain.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_gain.Name = "num_gain";
            this.num_gain.Size = new System.Drawing.Size(64, 22);
            this.num_gain.TabIndex = 2;
            this.num_gain.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.num_gain.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gbox_p
            // 
            this.gbox_p.Controls.Add(this.tableLayoutPanel1);
            this.gbox_p.Location = new System.Drawing.Point(12, 58);
            this.gbox_p.Name = "gbox_p";
            this.gbox_p.Size = new System.Drawing.Size(260, 58);
            this.gbox_p.TabIndex = 3;
            this.gbox_p.TabStop = false;
            this.gbox_p.Text = "Gain";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.dtxt_output, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.stxt_output, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_gain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtxt_output
            // 
            this.dtxt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtxt_output.AutoSize = true;
            this.dtxt_output.Location = new System.Drawing.Point(143, 12);
            this.dtxt_output.Name = "dtxt_output";
            this.dtxt_output.Size = new System.Drawing.Size(108, 12);
            this.dtxt_output.TabIndex = 4;
            this.dtxt_output.Text = "---";
            // 
            // stxt_output
            // 
            this.stxt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stxt_output.AutoSize = true;
            this.stxt_output.Location = new System.Drawing.Point(73, 12);
            this.stxt_output.Name = "stxt_output";
            this.stxt_output.Size = new System.Drawing.Size(64, 12);
            this.stxt_output.TabIndex = 3;
            this.stxt_output.Text = "Output";
            // 
            // tmr_display
            // 
            this.tmr_display.Enabled = true;
            this.tmr_display.Interval = 30;
            this.tmr_display.Tick += new System.EventHandler(this.tmr_display_Tick);
            // 
            // tbar_interval_ms
            // 
            this.tbar_interval_ms.AutoSize = false;
            this.tbar_interval_ms.Location = new System.Drawing.Point(6, 21);
            this.tbar_interval_ms.Maximum = 1000;
            this.tbar_interval_ms.Minimum = 1;
            this.tbar_interval_ms.Name = "tbar_interval_ms";
            this.tbar_interval_ms.Size = new System.Drawing.Size(248, 15);
            this.tbar_interval_ms.TabIndex = 8;
            this.tbar_interval_ms.TickFrequency = 50;
            this.tbar_interval_ms.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_interval_ms.Value = 100;
            this.tbar_interval_ms.Scroll += new System.EventHandler(this.tbar_interval_ms_Scroll);
            // 
            // gbox_interval
            // 
            this.gbox_interval.Controls.Add(this.tbar_interval_ms);
            this.gbox_interval.Location = new System.Drawing.Point(12, 248);
            this.gbox_interval.Name = "gbox_interval";
            this.gbox_interval.Size = new System.Drawing.Size(260, 48);
            this.gbox_interval.TabIndex = 9;
            this.gbox_interval.TabStop = false;
            this.gbox_interval.Text = "Interval 100ms";
            // 
            // gbox_setpoint
            // 
            this.gbox_setpoint.Controls.Add(this.tbar_setpoint);
            this.gbox_setpoint.Location = new System.Drawing.Point(12, 204);
            this.gbox_setpoint.Name = "gbox_setpoint";
            this.gbox_setpoint.Size = new System.Drawing.Size(260, 42);
            this.gbox_setpoint.TabIndex = 10;
            this.gbox_setpoint.TabStop = false;
            this.gbox_setpoint.Text = "setpoint 0";
            // 
            // tbar_setpoint
            // 
            this.tbar_setpoint.AutoSize = false;
            this.tbar_setpoint.LargeChange = 100;
            this.tbar_setpoint.Location = new System.Drawing.Point(6, 21);
            this.tbar_setpoint.Maximum = 1000;
            this.tbar_setpoint.Minimum = -1000;
            this.tbar_setpoint.Name = "tbar_setpoint";
            this.tbar_setpoint.Size = new System.Drawing.Size(248, 15);
            this.tbar_setpoint.SmallChange = 10;
            this.tbar_setpoint.TabIndex = 8;
            this.tbar_setpoint.TickFrequency = 50;
            this.tbar_setpoint.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_setpoint.Scroll += new System.EventHandler(this.tbar_setpoint_Scroll);
            // 
            // tmr_plant_sim
            // 
            this.tmr_plant_sim.Enabled = true;
            this.tmr_plant_sim.Interval = 1;
            this.tmr_plant_sim.Tick += new System.EventHandler(this.tmr_plant_sim_Tick);
            // 
            // ckbox_stop_controller
            // 
            this.ckbox_stop_controller.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbox_stop_controller.AutoSize = true;
            this.ckbox_stop_controller.Location = new System.Drawing.Point(278, 2);
            this.ckbox_stop_controller.Name = "ckbox_stop_controller";
            this.ckbox_stop_controller.Size = new System.Drawing.Size(73, 22);
            this.ckbox_stop_controller.TabIndex = 11;
            this.ckbox_stop_controller.Text = "Stop Process";
            this.ckbox_stop_controller.UseVisualStyleBackColor = true;
            this.ckbox_stop_controller.CheckedChanged += new System.EventHandler(this.ckbox_stop_controller_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.ckbox_stop_controller);
            this.Controls.Add(this.gbox_interval);
            this.Controls.Add(this.gbox_setpoint);
            this.Controls.Add(this.gbox_p);
            this.Controls.Add(this.chart_pid);
            this.MinimumSize = new System.Drawing.Size(530, 340);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_gain)).EndInit();
            this.gbox_p.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).EndInit();
            this.gbox_interval.ResumeLayout(false);
            this.gbox_setpoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr_controller;
        private ScottPlot.FormsPlot chart_pid;
        private System.Windows.Forms.NumericUpDown num_gain;
        private System.Windows.Forms.GroupBox gbox_p;
        private System.Windows.Forms.Label stxt_output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dtxt_output;
        private System.Windows.Forms.Timer tmr_display;
        private System.Windows.Forms.TrackBar tbar_interval_ms;
        private System.Windows.Forms.GroupBox gbox_interval;
        private System.Windows.Forms.GroupBox gbox_setpoint;
        private System.Windows.Forms.TrackBar tbar_setpoint;
        private System.Windows.Forms.Timer tmr_plant_sim;
        private System.Windows.Forms.CheckBox ckbox_stop_controller;
    }
}

