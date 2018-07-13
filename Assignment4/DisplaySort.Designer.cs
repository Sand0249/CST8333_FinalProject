
/** 
 * Author: Simranjit Singh Sandhu
 * Date  : March 25, 2018
 * Class : DisplaySort.cs
**/

///
///  this is auto generated class
///

namespace Assignment4
{
    partial class DisplaySort
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
            this.btnAscDate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.btnDescDate = new System.Windows.Forms.Button();
            this.btnAscCoordinate = new System.Windows.Forms.Button();
            this.btnDescCoordinate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAscDate
            // 
            this.btnAscDate.BackColor = System.Drawing.Color.Blue;
            this.btnAscDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscDate.ForeColor = System.Drawing.Color.Red;
            this.btnAscDate.Location = new System.Drawing.Point(145, 439);
            this.btnAscDate.Name = "btnAscDate";
            this.btnAscDate.Size = new System.Drawing.Size(154, 50);
            this.btnAscDate.TabIndex = 1;
            this.btnAscDate.Text = "Ascending order - ref_date";
            this.btnAscDate.UseVisualStyleBackColor = false;
            this.btnAscDate.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(70, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(770, 339);
            this.dataGridView.TabIndex = 2;
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.BackColor = System.Drawing.Color.Blue;
            this.btnLoadRecords.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecords.ForeColor = System.Drawing.Color.Red;
            this.btnLoadRecords.Location = new System.Drawing.Point(12, 438);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(116, 51);
            this.btnLoadRecords.TabIndex = 3;
            this.btnLoadRecords.Text = "Load records";
            this.btnLoadRecords.UseVisualStyleBackColor = false;
            this.btnLoadRecords.Click += new System.EventHandler(this.btnLoadRecords_Click);
            // 
            // btnDescDate
            // 
            this.btnDescDate.BackColor = System.Drawing.Color.Blue;
            this.btnDescDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescDate.ForeColor = System.Drawing.Color.Red;
            this.btnDescDate.Location = new System.Drawing.Point(317, 439);
            this.btnDescDate.Name = "btnDescDate";
            this.btnDescDate.Size = new System.Drawing.Size(189, 51);
            this.btnDescDate.TabIndex = 4;
            this.btnDescDate.Text = "Descending - ref_date";
            this.btnDescDate.UseVisualStyleBackColor = false;
            this.btnDescDate.Click += new System.EventHandler(this.btnDescDate_Click);
            // 
            // btnAscCoordinate
            // 
            this.btnAscCoordinate.BackColor = System.Drawing.Color.Blue;
            this.btnAscCoordinate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscCoordinate.ForeColor = System.Drawing.Color.Red;
            this.btnAscCoordinate.Location = new System.Drawing.Point(523, 439);
            this.btnAscCoordinate.Name = "btnAscCoordinate";
            this.btnAscCoordinate.Size = new System.Drawing.Size(189, 51);
            this.btnAscCoordinate.TabIndex = 4;
            this.btnAscCoordinate.Text = "Ascending - Coordinate";
            this.btnAscCoordinate.UseVisualStyleBackColor = false;
            this.btnAscCoordinate.Click += new System.EventHandler(this.btnAscCoordinate_Click);
            // 
            // btnDescCoordinate
            // 
            this.btnDescCoordinate.BackColor = System.Drawing.Color.Blue;
            this.btnDescCoordinate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescCoordinate.ForeColor = System.Drawing.Color.Red;
            this.btnDescCoordinate.Location = new System.Drawing.Point(732, 438);
            this.btnDescCoordinate.Name = "btnDescCoordinate";
            this.btnDescCoordinate.Size = new System.Drawing.Size(189, 51);
            this.btnDescCoordinate.TabIndex = 4;
            this.btnDescCoordinate.Text = "Descending - coordiate";
            this.btnDescCoordinate.UseVisualStyleBackColor = false;
            this.btnDescCoordinate.Click += new System.EventHandler(this.btnDescCoordinate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort records";
            // 
            // DisplaySort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescCoordinate);
            this.Controls.Add(this.btnAscCoordinate);
            this.Controls.Add(this.btnDescDate);
            this.Controls.Add(this.btnLoadRecords);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAscDate);
            this.Name = "DisplaySort";
            this.Text = "Program by: Simranjit Singh Sandhu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAscDate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Button btnDescDate;
        private System.Windows.Forms.Button btnAscCoordinate;
        private System.Windows.Forms.Button btnDescCoordinate;
        private System.Windows.Forms.Label label1;
    }
}