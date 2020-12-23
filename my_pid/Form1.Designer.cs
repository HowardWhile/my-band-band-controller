
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
            this.tmr_pid_controller = new System.Windows.Forms.Timer(this.components);
            this.chart_pid = new ScottPlot.FormsPlot();
            this.num_kp = new System.Windows.Forms.NumericUpDown();
            this.gbox_p = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtxt_error = new System.Windows.Forms.Label();
            this.stxt_error = new System.Windows.Forms.Label();
            this.gbox_i = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtxt_integral = new System.Windows.Forms.Label();
            this.stxt_integral = new System.Windows.Forms.Label();
            this.num_ki = new System.Windows.Forms.NumericUpDown();
            this.gbox_d = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtxt_derivative = new System.Windows.Forms.Label();
            this.stxt_derivative = new System.Windows.Forms.Label();
            this.num_kd = new System.Windows.Forms.NumericUpDown();
            this.tmr_display = new System.Windows.Forms.Timer(this.components);
            this.tbar_interval_ms = new System.Windows.Forms.TrackBar();
            this.gbox_interval = new System.Windows.Forms.GroupBox();
            this.gbox_setpoint = new System.Windows.Forms.GroupBox();
            this.tbar_setpoint = new System.Windows.Forms.TrackBar();
            this.tmr_plant_sim = new System.Windows.Forms.Timer(this.components);
            this.ckbox_stop_controller = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_kp)).BeginInit();
            this.gbox_p.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbox_i.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ki)).BeginInit();
            this.gbox_d.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).BeginInit();
            this.gbox_interval.SuspendLayout();
            this.gbox_setpoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_pid_controller
            // 
            this.tmr_pid_controller.Enabled = true;
            this.tmr_pid_controller.Tick += new System.EventHandler(this.tmr_pid_controller_Tick);
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
            // num_kp
            // 
            this.num_kp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_kp.DecimalPlaces = 5;
            this.num_kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_kp.Location = new System.Drawing.Point(3, 7);
            this.num_kp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_kp.Name = "num_kp";
            this.num_kp.Size = new System.Drawing.Size(64, 22);
            this.num_kp.TabIndex = 2;
            this.num_kp.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.num_kp.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gbox_p
            // 
            this.gbox_p.Controls.Add(this.tableLayoutPanel1);
            this.gbox_p.Location = new System.Drawing.Point(12, 12);
            this.gbox_p.Name = "gbox_p";
            this.gbox_p.Size = new System.Drawing.Size(260, 58);
            this.gbox_p.TabIndex = 3;
            this.gbox_p.TabStop = false;
            this.gbox_p.Text = "P gain";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.dtxt_error, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.stxt_error, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_kp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtxt_error
            // 
            this.dtxt_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtxt_error.AutoSize = true;
            this.dtxt_error.Location = new System.Drawing.Point(143, 12);
            this.dtxt_error.Name = "dtxt_error";
            this.dtxt_error.Size = new System.Drawing.Size(108, 12);
            this.dtxt_error.TabIndex = 4;
            this.dtxt_error.Text = "---";
            // 
            // stxt_error
            // 
            this.stxt_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stxt_error.AutoSize = true;
            this.stxt_error.Location = new System.Drawing.Point(73, 12);
            this.stxt_error.Name = "stxt_error";
            this.stxt_error.Size = new System.Drawing.Size(64, 12);
            this.stxt_error.TabIndex = 3;
            this.stxt_error.Text = "Error";
            // 
            // gbox_i
            // 
            this.gbox_i.Controls.Add(this.tableLayoutPanel2);
            this.gbox_i.Location = new System.Drawing.Point(12, 76);
            this.gbox_i.Name = "gbox_i";
            this.gbox_i.Size = new System.Drawing.Size(260, 58);
            this.gbox_i.TabIndex = 4;
            this.gbox_i.TabStop = false;
            this.gbox_i.Text = "I gain";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.dtxt_integral, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.stxt_integral, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.num_ki, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dtxt_integral
            // 
            this.dtxt_integral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtxt_integral.AutoSize = true;
            this.dtxt_integral.Location = new System.Drawing.Point(143, 12);
            this.dtxt_integral.Name = "dtxt_integral";
            this.dtxt_integral.Size = new System.Drawing.Size(108, 12);
            this.dtxt_integral.TabIndex = 4;
            this.dtxt_integral.Text = "---";
            // 
            // stxt_integral
            // 
            this.stxt_integral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stxt_integral.AutoSize = true;
            this.stxt_integral.Location = new System.Drawing.Point(73, 12);
            this.stxt_integral.Name = "stxt_integral";
            this.stxt_integral.Size = new System.Drawing.Size(64, 12);
            this.stxt_integral.TabIndex = 3;
            this.stxt_integral.Text = "Integral";
            // 
            // num_ki
            // 
            this.num_ki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ki.DecimalPlaces = 5;
            this.num_ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_ki.Location = new System.Drawing.Point(3, 7);
            this.num_ki.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_ki.Name = "num_ki";
            this.num_ki.Size = new System.Drawing.Size(64, 22);
            this.num_ki.TabIndex = 2;
            this.num_ki.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.num_ki.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gbox_d
            // 
            this.gbox_d.Controls.Add(this.tableLayoutPanel3);
            this.gbox_d.Location = new System.Drawing.Point(12, 140);
            this.gbox_d.Name = "gbox_d";
            this.gbox_d.Size = new System.Drawing.Size(260, 58);
            this.gbox_d.TabIndex = 5;
            this.gbox_d.TabStop = false;
            this.gbox_d.Text = "D gain";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel3.Controls.Add(this.dtxt_derivative, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.stxt_derivative, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.num_kd, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 37);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dtxt_derivative
            // 
            this.dtxt_derivative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtxt_derivative.AutoSize = true;
            this.dtxt_derivative.Location = new System.Drawing.Point(143, 12);
            this.dtxt_derivative.Name = "dtxt_derivative";
            this.dtxt_derivative.Size = new System.Drawing.Size(108, 12);
            this.dtxt_derivative.TabIndex = 4;
            this.dtxt_derivative.Text = "---";
            // 
            // stxt_derivative
            // 
            this.stxt_derivative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stxt_derivative.AutoSize = true;
            this.stxt_derivative.Location = new System.Drawing.Point(73, 12);
            this.stxt_derivative.Name = "stxt_derivative";
            this.stxt_derivative.Size = new System.Drawing.Size(64, 12);
            this.stxt_derivative.TabIndex = 3;
            this.stxt_derivative.Text = "Derivative";
            // 
            // num_kd
            // 
            this.num_kd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_kd.DecimalPlaces = 5;
            this.num_kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_kd.Location = new System.Drawing.Point(3, 7);
            this.num_kd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_kd.Name = "num_kd";
            this.num_kd.Size = new System.Drawing.Size(64, 22);
            this.num_kd.TabIndex = 2;
            this.num_kd.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.num_kd.ValueChanged += new System.EventHandler(this.num_ValueChanged);
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
            this.Controls.Add(this.gbox_d);
            this.Controls.Add(this.gbox_i);
            this.Controls.Add(this.gbox_p);
            this.Controls.Add(this.chart_pid);
            this.MinimumSize = new System.Drawing.Size(530, 340);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_kp)).EndInit();
            this.gbox_p.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbox_i.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ki)).EndInit();
            this.gbox_d.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_interval_ms)).EndInit();
            this.gbox_interval.ResumeLayout(false);
            this.gbox_setpoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_setpoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr_pid_controller;
        private ScottPlot.FormsPlot chart_pid;
        private System.Windows.Forms.NumericUpDown num_kp;
        private System.Windows.Forms.GroupBox gbox_p;
        private System.Windows.Forms.Label stxt_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dtxt_error;
        private System.Windows.Forms.GroupBox gbox_i;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dtxt_integral;
        private System.Windows.Forms.Label stxt_integral;
        private System.Windows.Forms.NumericUpDown num_ki;
        private System.Windows.Forms.GroupBox gbox_d;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label dtxt_derivative;
        private System.Windows.Forms.Label stxt_derivative;
        private System.Windows.Forms.NumericUpDown num_kd;
        private System.Windows.Forms.Timer tmr_display;
        private System.Windows.Forms.TrackBar tbar_interval_ms;
        private System.Windows.Forms.GroupBox gbox_interval;
        private System.Windows.Forms.GroupBox gbox_setpoint;
        private System.Windows.Forms.TrackBar tbar_setpoint;
        private System.Windows.Forms.Timer tmr_plant_sim;
        private System.Windows.Forms.CheckBox ckbox_stop_controller;
    }
}

