namespace DataCalc
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinuse = new System.Windows.Forms.RadioButton();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy年MM月dd日 HH时mm分ss秒";
            this.dtp1.Location = new System.Drawing.Point(12, 134);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 21);
            this.dtp1.TabIndex = 0;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy年MM月dd日 HH时mm分ss秒";
            this.dtp2.Location = new System.Drawing.Point(12, 173);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(126, 21);
            this.dtp2.TabIndex = 0;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(143, 140);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(41, 12);
            this.lblResult1.TabIndex = 1;
            this.lblResult1.Text = "结果：";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(143, 179);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(41, 12);
            this.lblResult2.TabIndex = 1;
            this.lblResult2.Text = "结果：";
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Checked = true;
            this.rbPlus.Location = new System.Drawing.Point(12, 220);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(47, 16);
            this.rbPlus.TabIndex = 2;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "加上";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinuse
            // 
            this.rbMinuse.AutoSize = true;
            this.rbMinuse.Location = new System.Drawing.Point(12, 242);
            this.rbMinuse.Name = "rbMinuse";
            this.rbMinuse.Size = new System.Drawing.Size(47, 16);
            this.rbMinuse.TabIndex = 2;
            this.rbMinuse.Text = "减去";
            this.rbMinuse.UseVisualStyleBackColor = true;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(71, 229);
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(40, 21);
            this.nudYear.TabIndex = 3;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(145, 229);
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(40, 21);
            this.nudMonth.TabIndex = 3;
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(209, 229);
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(40, 21);
            this.nudDay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "年";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "月";
            // 
            // lblResultSub
            // 
            this.lblResultSub.AutoSize = true;
            this.lblResultSub.Location = new System.Drawing.Point(97, 274);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(41, 12);
            this.lblResultSub.TabIndex = 1;
            this.lblResultSub.Text = "结果：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "倒计时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "出生：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.rbMinuse);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "日期计算";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinuse;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

