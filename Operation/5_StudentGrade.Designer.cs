namespace Operation
{
    partial class callForm5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.totalScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.chinese,
            this.english,
            this.math,
            this.totalScore,
            this.average,
            this.low,
            this.high});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(158, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "姓名:";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 55;
            // 
            // chinese
            // 
            this.chinese.HeaderText = "國文";
            this.chinese.Name = "chinese";
            this.chinese.ReadOnly = true;
            this.chinese.Width = 52;
            // 
            // english
            // 
            this.english.HeaderText = "英文";
            this.english.Name = "english";
            this.english.ReadOnly = true;
            this.english.Width = 52;
            // 
            // math
            // 
            this.math.HeaderText = "數學";
            this.math.Name = "math";
            this.math.ReadOnly = true;
            this.math.Width = 52;
            // 
            // totalScore
            // 
            this.totalScore.HeaderText = "總分";
            this.totalScore.Name = "totalScore";
            this.totalScore.ReadOnly = true;
            this.totalScore.Width = 52;
            // 
            // average
            // 
            this.average.HeaderText = "平均";
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Width = 52;
            // 
            // low
            // 
            this.low.HeaderText = "最低";
            this.low.Name = "low";
            this.low.ReadOnly = true;
            this.low.Width = 52;
            // 
            // high
            // 
            this.high.HeaderText = "最高";
            this.high.Name = "high";
            this.high.ReadOnly = true;
            this.high.Width = 52;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(59, 172);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(63, 22);
            this.txtMath.TabIndex = 15;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Location = new System.Drawing.Point(19, 183);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(38, 12);
            this.labMath.TabIndex = 14;
            this.labMath.Text = "數學 : ";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(59, 122);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(63, 22);
            this.txtEnglish.TabIndex = 13;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(19, 133);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(38, 12);
            this.labEnglish.TabIndex = 12;
            this.labEnglish.Text = "英文 : ";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(59, 72);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(63, 22);
            this.txtChinese.TabIndex = 11;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(19, 83);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(38, 12);
            this.labChinese.TabIndex = 10;
            this.labChinese.Text = "國文 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(63, 22);
            this.txtName.TabIndex = 9;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(19, 36);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(38, 12);
            this.labName.TabIndex = 8;
            this.labName.Text = "姓名 : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "加入學生資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "隨機儲存資料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "各科統計";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "重設所有資料";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "隨機加入20筆";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalScore2,
            this.average2,
            this.high2,
            this.low2});
            this.dataGridView2.Location = new System.Drawing.Point(158, 262);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(398, 119);
            this.dataGridView2.TabIndex = 21;
            // 
            // totalScore2
            // 
            this.totalScore2.Frozen = true;
            this.totalScore2.HeaderText = "總分";
            this.totalScore2.Name = "totalScore2";
            this.totalScore2.ReadOnly = true;
            this.totalScore2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // average2
            // 
            this.average2.Frozen = true;
            this.average2.HeaderText = "平均";
            this.average2.Name = "average2";
            this.average2.ReadOnly = true;
            // 
            // high2
            // 
            this.high2.Frozen = true;
            this.high2.HeaderText = "最高分";
            this.high2.Name = "high2";
            this.high2.ReadOnly = true;
            // 
            // low2
            // 
            this.low2.Frozen = true;
            this.low2.HeaderText = "最低分";
            this.low2.Name = "low2";
            this.low2.ReadOnly = true;
            // 
            // callForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 398);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "callForm5";
            this.Text = "My Homework_0709";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn english;
        private System.Windows.Forms.DataGridViewTextBoxColumn math;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn average2;
        private System.Windows.Forms.DataGridViewTextBoxColumn high2;
        private System.Windows.Forms.DataGridViewTextBoxColumn low2;
    }
}