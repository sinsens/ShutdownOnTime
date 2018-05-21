namespace ShutdownOnTime
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbTip = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "时间：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 21);
            this.textBox1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(253, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 192);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(107, 161);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(65, 12);
            this.lbTip.TabIndex = 1;
            this.lbTip.Text = "剩余时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前系统时间：";
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(128, 221);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "终止关机";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "强制关机";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "作者：@Sinsen";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(247, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(27, 192);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 4;
            this.btnShutdown.Text = "关机";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(27, 221);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(75, 23);
            this.btnReboot.TabIndex = 4;
            this.btnReboot.Text = "重启";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(353, 260);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时关机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnReboot;
    }
}

