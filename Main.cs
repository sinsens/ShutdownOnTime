using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownOnTime
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        bool is_start = false;
        TimeSpan elapsedSpan;
        DateTime centuryBegin;
        DateTime currentDate;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
               DateTime dt = Convert.ToDateTime(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("输入的时间格式不正确，应该为\"00:00:00\"格式");
                return;
            }
            
            var ts = (textBox1.Text.Split(':'));
            DateTime t = dateTimePicker1.Value;
            centuryBegin = new DateTime(t.Year, t.Month, t.Day, Convert.ToInt16(ts[0]), Convert.ToInt16(ts[1]), Convert.ToInt16(ts[2]));
            long elapsedTicks = centuryBegin.Ticks - currentDate.Ticks;
            if (elapsedTicks/1000 < 60) {
                MessageBox.Show("定期时间应至少大于当前时间60秒");
                return;
            }
            is_start = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "当前系统时间："+DateTime.Now.ToLongTimeString();
            if (is_start)
            {
                currentDate = DateTime.Now;
                long elapsedTicks = centuryBegin.Ticks - currentDate.Ticks;
                elapsedSpan = new TimeSpan(elapsedTicks);

                if (elapsedSpan.Seconds < 0)
                {
                    System.Diagnostics.Process bootProcess = new System.Diagnostics.Process();
                    bootProcess.StartInfo.FileName = "shutdown";
                    bootProcess.StartInfo.Arguments = "/s";
                    if (checkBox1.Checked)
                        bootProcess.StartInfo.Arguments += " /p /f";
                    bootProcess.Start();
                    is_start = false;
                    lbTip.Text = "时间到，系统将会在1分钟后关机";
                }
                else {
                    lbTip.Text = "剩余时间："+elapsedSpan.Days+"天" + elapsedSpan.Hours + "小时" + elapsedSpan.Minutes + "分" + elapsedSpan.Seconds + "秒";
                }
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process bootProcess = new System.Diagnostics.Process();
            bootProcess.StartInfo.FileName = "shutdown";
            bootProcess.StartInfo.Arguments = "/a";
            bootProcess.Start();
            init();
            MessageBox.Show("已终止关机");
        }
        private void init() {
            is_start = false;
            textBox1.Text = DateTime.Now.ToLongTimeString();
            lbTip.Text = "剩余时间：";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
