namespace ex2_2_Choose_Student
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCandidate = new System.Windows.Forms.ListBox();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.listChoose = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCandidate
            // 
            this.listCandidate.FormattingEnabled = true;
            this.listCandidate.ItemHeight = 12;
            this.listCandidate.Items.AddRange(new object[] {
            "张三",
            "李四",
            "王五",
            "赵六",
            "田七"});
            this.listCandidate.Location = new System.Drawing.Point(25, 47);
            this.listCandidate.Name = "listCandidate";
            this.listCandidate.Size = new System.Drawing.Size(120, 88);
            this.listCandidate.TabIndex = 0;
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.Location = new System.Drawing.Point(25, 29);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(77, 12);
            this.lblCandidate.TabIndex = 1;
            this.lblCandidate.Text = "优秀学员候选";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(151, 58);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(51, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = ">>";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(219, 29);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(53, 12);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "优秀学员";
            // 
            // listChoose
            // 
            this.listChoose.FormattingEnabled = true;
            this.listChoose.ItemHeight = 12;
            this.listChoose.Location = new System.Drawing.Point(219, 47);
            this.listChoose.Name = "listChoose";
            this.listChoose.Size = new System.Drawing.Size(120, 88);
            this.listChoose.TabIndex = 3;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(233, 171);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(106, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "显示结果";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(25, 171);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(106, 23);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "更改姓名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(151, 96);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(51, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.listChoose);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lblCandidate);
            this.Controls.Add(this.listCandidate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCandidate;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ListBox listChoose;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnRemove;
    }
}

