namespace Operation
{
    partial class callForm4
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.txt_AllScore = new System.Windows.Forms.TextBox();
            this.txtHigh_Low = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(63, 51);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(38, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(103, 87);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(113, 22);
            this.txtChinese.TabIndex = 3;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(63, 98);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(38, 12);
            this.labChinese.TabIndex = 2;
            this.labChinese.Text = "國文 : ";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(103, 137);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(113, 22);
            this.txtEnglish.TabIndex = 5;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(63, 148);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(38, 12);
            this.labEnglish.TabIndex = 4;
            this.labEnglish.Text = "英文 : ";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(103, 187);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(113, 22);
            this.txtMath.TabIndex = 7;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Location = new System.Drawing.Point(63, 198);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(38, 12);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學 : ";
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(65, 241);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(86, 38);
            this.btnStore.TabIndex = 8;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(163, 241);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 38);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHigh_Low);
            this.groupBox1.Controls.Add(this.txt_AllScore);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 306);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(458, 324);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(132, 38);
            this.btnScore.TabIndex = 11;
            this.btnScore.Text = "最高分/最低分科目";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // txt_AllScore
            // 
            this.txt_AllScore.BackColor = System.Drawing.SystemColors.Control;
            this.txt_AllScore.Location = new System.Drawing.Point(7, 21);
            this.txt_AllScore.Multiline = true;
            this.txt_AllScore.Name = "txt_AllScore";
            this.txt_AllScore.Size = new System.Drawing.Size(290, 176);
            this.txt_AllScore.TabIndex = 0;
            // 
            // txtHigh_Low
            // 
            this.txtHigh_Low.BackColor = System.Drawing.SystemColors.Control;
            this.txtHigh_Low.Location = new System.Drawing.Point(7, 203);
            this.txtHigh_Low.Multiline = true;
            this.txtHigh_Low.Name = "txtHigh_Low";
            this.txtHigh_Low.Size = new System.Drawing.Size(290, 97);
            this.txtHigh_Low.TabIndex = 1;
            // 
            // callForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 402);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "callForm4";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHigh_Low;
        private System.Windows.Forms.TextBox txt_AllScore;
        private System.Windows.Forms.Button btnScore;
    }
}