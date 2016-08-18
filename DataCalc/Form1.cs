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

            lblResultSub.Text = "两者相差： " +DateDiff(dt1, dt2) + "\r\n" + Math.Abs(sub.Days) + " 天";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dtBrith = new DateTime(2016, 6, 23, 1, 23, 0);
            DateTime dtEnd = new DateTime(2017,5,23);
            DateTime dtNow = DateTime.Now;


            lblBirthCount.Text = DateDiff(dtBrith,dtNow) + "\r\n" + Math.Abs((dtNow-dtBrith).Days)+"天";
            lblEndCount.Text = DateDiff(dtEnd,dtNow) + "\r\n" + Math.Abs((dtEnd - dtNow).Days) + "天";
        }


        private string DateDiff(DateTime dt1, DateTime dt2)
        {
            DateTime dtmax, dtmin;
            if (dt1 > dt2)
            {
                dtmax = dt1.Date;
                dtmin = dt2.Date;
            }
            else
            {
                dtmax = dt2.Date;
                dtmin = dt1.Date;
            }

            int days = (dtmax - dtmin).Days;
            
            int year = 0, month = 0, day = 0;
            #region 计算年
            if (days >= 365)
            {
                for (int i = 1; i <= (days / 365) + 1; i++)
                {
                    if (dtmin.AddYears(i) > dtmax)
                    {
                        year = i - 1;
                        break;
                    }
                }
            }
            #endregion

            #region 计算月

            for (int i = 1; i <= 12; i++)
            {
                if (dtmin.AddYears(year).AddMonths(i) > dtmax)
                {
                    month = i - 1;
                    break;
                }
            }
            #endregion

            #region 计算天

            for (int i = 1; i <= 31; i++)
            {
                if (dtmin.AddYears(year).AddMonths(month).AddDays(i) > dtmax)
                {
                    day = i - 1;
                    break;
                }
            }
            #endregion

            
            return $"{year}年{month}月{day}天";
        }

    }
}
