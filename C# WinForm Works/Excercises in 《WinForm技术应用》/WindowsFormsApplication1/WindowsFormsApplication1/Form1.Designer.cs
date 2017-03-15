namespace WindowsFormsApplication1
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
            this.textBox1Voltage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1Voltage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1Voltage
            // 
            this.textBox1Voltage.Location = new System.Drawing.Point(90, 49);
            this.textBox1Voltage.Name = "textBox1Voltage";
            this.textBox1Voltage.Size = new System.Drawing.Size(100, 21);
            this.textBox1Voltage.TabIndex = 0;
            this.textBox1Voltage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Display Voltage";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1Voltage
            // 
            this.label1Voltage.AutoSize = true;
            this.label1Voltage.Location = new System.Drawing.Point(31, 52);
            this.label1Voltage.MaximumSize = new System.Drawing.Size(80, 20);
            this.label1Voltage.Name = "label1Voltage";
            this.label1Voltage.Size = new System.Drawing.Size(47, 12);
            this.label1Voltage.TabIndex = 2;
            this.label1Voltage.Text = "Voltage";
            this.label1Voltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1Voltage.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.MaximumSize = new System.Drawing.Size(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWord";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1Voltage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1Voltage);
            this.Name = "Form1";
            this.Text = "My1stWinForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Voltage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1Voltage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

