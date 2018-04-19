/** 
 * Author: Simranjit Singh Sandhu
 * Date  : March 25, 2018
 * Class : MainScreen.cs
 * */

///
///  this is auto generated class
///
namespace Assignment4
{
    partial class MainScreen
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
            this.btnDisplaySort = new System.Windows.Forms.Button();
            this.btnInsertDel = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRecords = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplaySort
            // 
            this.btnDisplaySort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySort.Location = new System.Drawing.Point(112, 99);
            this.btnDisplaySort.Name = "btnDisplaySort";
            this.btnDisplaySort.Size = new System.Drawing.Size(219, 56);
            this.btnDisplaySort.TabIndex = 0;
            this.btnDisplaySort.Text = "Display and Sort Records";
            this.btnDisplaySort.UseVisualStyleBackColor = true;
            this.btnDisplaySort.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertDel
            // 
            this.btnInsertDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertDel.Location = new System.Drawing.Point(361, 99);
            this.btnInsertDel.Name = "btnInsertDel";
            this.btnInsertDel.Size = new System.Drawing.Size(154, 56);
            this.btnInsertDel.TabIndex = 0;
            this.btnInsertDel.Text = "CRUD";
            this.btnInsertDel.UseVisualStyleBackColor = true;
            this.btnInsertDel.Click += new System.EventHandler(this.btnInsertDel_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(548, 99);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(154, 56);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "Marks Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "View number of records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtRecords
            // 
            this.txtRecords.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecords.Location = new System.Drawing.Point(441, 214);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(232, 29);
            this.txtRecords.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(112, 289);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(561, 76);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Click here to print records from csv file into console";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 405);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtRecords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnInsertDel);
            this.Controls.Add(this.btnDisplaySort);
            this.Name = "MainScreen";
            this.Text = "Program by: Simranjit Singh Sandhu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplaySort;
        private System.Windows.Forms.Button btnInsertDel;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRecords;
        private System.Windows.Forms.Button btnPrint;
    }
}