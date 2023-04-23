namespace Operation
{
    partial class _15_guess
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
            this.btnguess = new System.Windows.Forms.Button();
            this.btnanswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnguess
            // 
            this.btnguess.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnguess.Location = new System.Drawing.Point(109, 184);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(75, 41);
            this.btnguess.TabIndex = 0;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // btnanswer
            // 
            this.btnanswer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnanswer.Location = new System.Drawing.Point(279, 184);
            this.btnanswer.Name = "btnanswer";
            this.btnanswer.Size = new System.Drawing.Size(117, 41);
            this.btnanswer.TabIndex = 1;
            this.btnanswer.Text = "Answer";
            this.btnanswer.UseVisualStyleBackColor = true;
            this.btnanswer.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select A Number Between 1 To 100!";
            // 
            // _15_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnanswer);
            this.Controls.Add(this.btnguess);
            this.Name = "_15_guess";
            this.Text = "_15_guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Button btnanswer;
        private System.Windows.Forms.Label label1;
    }
}