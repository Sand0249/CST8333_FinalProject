namespace Assignment4
{
    partial class MarksCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnTotalMarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter marks for english:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter marks for mathematics:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Average marks:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(426, 127);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(229, 29);
            this.txtEnglish.TabIndex = 2;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMath.Location = new System.Drawing.Point(426, 181);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(229, 29);
            this.txtMath.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(426, 237);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(229, 29);
            this.txtTotal.TabIndex = 2;
            // 
            // btnTotalMarks
            // 
            this.btnTotalMarks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalMarks.Location = new System.Drawing.Point(200, 302);
            this.btnTotalMarks.Name = "btnTotalMarks";
            this.btnTotalMarks.Size = new System.Drawing.Size(343, 46);
            this.btnTotalMarks.TabIndex = 3;
            this.btnTotalMarks.Text = "Click here to get average marks";
            this.btnTotalMarks.UseVisualStyleBackColor = true;
            this.btnTotalMarks.Click += new System.EventHandler(this.btnTotalMarks_Click);
            // 
            // MarksCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 397);
            this.Controls.Add(this.btnTotalMarks);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MarksCalculator";
            this.Text = "Program by: Simranjit Singh Sandhu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnTotalMarks;
    }
}