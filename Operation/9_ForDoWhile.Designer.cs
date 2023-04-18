namespace Operation
{
    partial class callForm9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labresult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result:";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(108, 24);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(80, 25);
            this.txtnumber.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "輸入的數為奇數或偶數?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labresult
            // 
            this.labresult.AutoSize = true;
            this.labresult.BackColor = System.Drawing.SystemColors.Info;
            this.labresult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labresult.Location = new System.Drawing.Point(44, 405);
            this.labresult.Name = "labresult";
            this.labresult.Size = new System.Drawing.Size(49, 20);
            this.labresult.TabIndex = 4;
            this.labresult.Text = "結果";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "陣列arr0711[]最大/小值";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // callForm9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labresult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "callForm9";
            this.Text = "My Homework_0711_Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labresult;
        private System.Windows.Forms.Button button2;
    }
}