using System;
using System.Windows.Forms;

namespace DataCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dtp1.Value;
            DateTime dt2 = dtp2.Value;

            TimeSpan sub = (dt2 - dt1);
            if (rbPlus.Checked)
            {
                dt1 = dt1.AddYears((int)(nudYear.Value));
                dt1 = dt1.AddMonths((int)(nudMonth.Value));
                dt1 = dt1.AddDays((int)(nudDay.Value));

                dt2 = dt2.AddYears((int)(nudYear.Value));
                dt2 = dt2.AddMonths((int)(nudMonth.Value));
                dt2 = dt2.AddDays((int)(nudDay.Value));


            }
            else
            {
                dt1 = dt1.AddYears(-(int)(nudYear.Value));
                dt1 = dt1.AddMonths(-(int)(nudMonth.Value));
                dt1 = dt1.AddDays(-(int)(nudDay.Value));

                dt2 = dt2.AddYears(-(int)(nudYear.Value));
                dt2 = dt2.AddMonths(-(int)(nudMonth.Value));
                dt2 = dt2.AddDays(-(int)(nudDay.Value));
            }

            lblResult1.Text = dt1.ToString("yyyy年MM月dd日");
            lblResult2.Text = dt2.ToString("yyyy年MM月dd日");

            lblResultSub.Text = "两者相差： " + sub.TotalDays.ToString("N0")+" 天";
        }
    }
}
