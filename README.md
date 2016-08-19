# DataCalc

just for Date compare and my date counting
win10 自带计算器不支持日期计算，所以自己写了一个。可以计算某日期增加/减少多少年/月/日后的值

后来又加个倒计时。。。

## 时间差计算说明

> 网上现有的方法

大家基本上都是两个日期相减，然后得到了`TimeSpan`，之后得到了相差的天数，用每年365天，每月30天的粗略计算来实现。。这种效果不太好。计算的太粗略

> 我的方法

首先判断一下大小，然后开始逐年/月/日增加了。。

用这种方式能算出来两个日期之间相间隔的年月日。


     
    private string DateDiff(DateTime dt1, DateTime dt2)
    {
        //比大小
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
        
        //初始化计数器
        int year = 0, month = 0, day = 0;

        //开始分年月日计算
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

        //返回
        return $"{year}年{month}月{day}天";
    }