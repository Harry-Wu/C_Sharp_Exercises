namespace ex1_1_DY_定时器
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSettime = new System.Windows.Forms.Label();
            this.lbllefttime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cboxTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(284, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始计时";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSettime
            // 
            this.lblSettime.AutoSize = true;
            this.lblSettime.Location = new System.Drawing.Point(38, 29);
            this.lblSettime.Name = "lblSettime";
            this.lblSettime.Size = new System.Drawing.Size(53, 12);
            this.lblSettime.TabIndex = 1;
            this.lblSettime.Text = "定时时间";
            // 
            // lbllefttime
            // 
            this.lbllefttime.AutoSize = true;
            this.lbllefttime.Location = new System.Drawing.Point(40, 65);
            this.lbllefttime.Name = "lbllefttime";
            this.lbllefttime.Size = new System.Drawing.Size(53, 12);
            this.lbllefttime.TabIndex = 2;
            this.lbllefttime.Text = "剩余时间";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // cboxTime
            // 
            this.cboxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTime.FormattingEnabled = true;
            this.cboxTime.Location = new System.Drawing.Point(127, 29);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(121, 20);
            this.cboxTime.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(160, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(23, 12);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "0秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 138);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cboxTime);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbllefttime);
            this.Controls.Add(this.lblSettime);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "倒计时器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSettime;
        private System.Windows.Forms.Label lbllefttime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cboxTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

