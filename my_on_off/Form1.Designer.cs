﻿
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
            this.gbox_mode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbox_mode = new System.Windows.Forms.ComboBox();
            this.gbox_hysteresis = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.num_hysteresis = new System.Windows.Forms.NumericUpDown();
            this.gbox_deadband = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.num_deadband = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_gain)).BeginInit();
            this.gbox_p.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).BeginInit();
            this.gbox_interval.SuspendLayout();
            this.gbox_setpoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).BeginInit();
            this.gbox_mode.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbox_hysteresis.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hysteresis)).BeginInit();
            this.gbox_deadband.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_deadband)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_controller
            // 
            this.tmr_controller.Enabled = true;
            this.tmr_controller.Interval = 50;
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
            this.num_gain.Size = new System.Drawing.Size(69, 22);
            this.num_gain.TabIndex = 2;
            this.num_gain.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_gain.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gbox_p
            // 
            this.gbox_p.Controls.Add(this.tableLayoutPanel1);
            this.gbox_p.Location = new System.Drawing.Point(6, 76);
            this.gbox_p.Name = "gbox_p";
            this.gbox_p.Size = new System.Drawing.Size(81, 58);
            this.gbox_p.TabIndex = 3;
            this.gbox_p.TabStop = false;
            this.gbox_p.Text = "Gain";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.num_gain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(75, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtxt_output
            // 
            this.dtxt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtxt_output.AutoSize = true;
            this.dtxt_output.Location = new System.Drawing.Point(94, 151);
            this.dtxt_output.Name = "dtxt_output";
            this.dtxt_output.Size = new System.Drawing.Size(17, 12);
            this.dtxt_output.TabIndex = 4;
            this.dtxt_output.Text = "---";
            // 
            // stxt_output
            // 
            this.stxt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stxt_output.AutoSize = true;
            this.stxt_output.Location = new System.Drawing.Point(10, 151);
            this.stxt_output.Name = "stxt_output";
            this.stxt_output.Size = new System.Drawing.Size(37, 12);
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
            this.tbar_interval_ms.Value = 50;
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
            this.gbox_interval.Text = "Interval 100 ms";
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
            // gbox_mode
            // 
            this.gbox_mode.Controls.Add(this.tableLayoutPanel2);
            this.gbox_mode.Location = new System.Drawing.Point(3, 12);
            this.gbox_mode.Name = "gbox_mode";
            this.gbox_mode.Size = new System.Drawing.Size(136, 58);
            this.gbox_mode.TabIndex = 4;
            this.gbox_mode.TabStop = false;
            this.gbox_mode.Text = "Mode";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.cbox_mode, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbox_mode
            // 
            this.cbox_mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_mode.FormattingEnabled = true;
            this.cbox_mode.Items.AddRange(new object[] {
            "General",
            "Hysteresis",
            "Deadband",
            "Deadband + Hysteresis"});
            this.cbox_mode.Location = new System.Drawing.Point(3, 8);
            this.cbox_mode.Name = "cbox_mode";
            this.cbox_mode.Size = new System.Drawing.Size(124, 20);
            this.cbox_mode.TabIndex = 0;
            this.cbox_mode.SelectedIndexChanged += new System.EventHandler(this.cbox_mode_SelectedIndexChanged);
            // 
            // gbox_hysteresis
            // 
            this.gbox_hysteresis.Controls.Add(this.tableLayoutPanel3);
            this.gbox_hysteresis.Location = new System.Drawing.Point(93, 76);
            this.gbox_hysteresis.Name = "gbox_hysteresis";
            this.gbox_hysteresis.Size = new System.Drawing.Size(81, 58);
            this.gbox_hysteresis.TabIndex = 3;
            this.gbox_hysteresis.TabStop = false;
            this.gbox_hysteresis.Text = "Hysteresis";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.num_hysteresis, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(75, 37);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // num_hysteresis
            // 
            this.num_hysteresis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_hysteresis.DecimalPlaces = 5;
            this.num_hysteresis.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_hysteresis.Location = new System.Drawing.Point(3, 7);
            this.num_hysteresis.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_hysteresis.Name = "num_hysteresis";
            this.num_hysteresis.Size = new System.Drawing.Size(69, 22);
            this.num_hysteresis.TabIndex = 2;
            this.num_hysteresis.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_hysteresis.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gbox_deadband
            // 
            this.gbox_deadband.Controls.Add(this.tableLayoutPanel4);
            this.gbox_deadband.Location = new System.Drawing.Point(180, 76);
            this.gbox_deadband.Name = "gbox_deadband";
            this.gbox_deadband.Size = new System.Drawing.Size(81, 58);
            this.gbox_deadband.TabIndex = 3;
            this.gbox_deadband.TabStop = false;
            this.gbox_deadband.Text = "Deadband";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.num_deadband, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(75, 37);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // num_deadband
            // 
            this.num_deadband.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_deadband.DecimalPlaces = 5;
            this.num_deadband.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_deadband.Location = new System.Drawing.Point(3, 7);
            this.num_deadband.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_deadband.Name = "num_deadband";
            this.num_deadband.Size = new System.Drawing.Size(69, 22);
            this.num_deadband.TabIndex = 2;
            this.num_deadband.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_deadband.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.gbox_mode);
            this.Controls.Add(this.dtxt_output);
            this.Controls.Add(this.ckbox_stop_controller);
            this.Controls.Add(this.stxt_output);
            this.Controls.Add(this.gbox_interval);
            this.Controls.Add(this.gbox_setpoint);
            this.Controls.Add(this.gbox_deadband);
            this.Controls.Add(this.gbox_hysteresis);
            this.Controls.Add(this.gbox_p);
            this.Controls.Add(this.chart_pid);
            this.MinimumSize = new System.Drawing.Size(530, 340);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_gain)).EndInit();
            this.gbox_p.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).EndInit();
            this.gbox_interval.ResumeLayout(false);
            this.gbox_setpoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).EndInit();
            this.gbox_mode.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbox_hysteresis.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_hysteresis)).EndInit();
            this.gbox_deadband.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_deadband)).EndInit();
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
        private System.Windows.Forms.GroupBox gbox_mode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbox_mode;
        private System.Windows.Forms.GroupBox gbox_hysteresis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown num_hysteresis;
        private System.Windows.Forms.GroupBox gbox_deadband;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown num_deadband;
    }
}

