namespace Water_Bill_Analysis
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFourWaterBills = new System.Windows.Forms.Label();
            this.txtFourWaterBills = new System.Windows.Forms.TextBox();
            this.txtWaterBillAverage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(196, 210);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblFourWaterBills
            // 
            this.lblFourWaterBills.Location = new System.Drawing.Point(68, 56);
            this.lblFourWaterBills.Name = "lblFourWaterBills";
            this.lblFourWaterBills.Size = new System.Drawing.Size(153, 23);
            this.lblFourWaterBills.TabIndex = 1;
            this.lblFourWaterBills.Text = " Four water bills";
            this.lblFourWaterBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFourWaterBills
            // 
            this.txtFourWaterBills.Location = new System.Drawing.Point(266, 57);
            this.txtFourWaterBills.Name = "txtFourWaterBills";
            this.txtFourWaterBills.Size = new System.Drawing.Size(100, 22);
            this.txtFourWaterBills.TabIndex = 0;
            // 
            // txtWaterBillAverage
            // 
            this.txtWaterBillAverage.Location = new System.Drawing.Point(266, 129);
            this.txtWaterBillAverage.Name = "txtWaterBillAverage";
            this.txtWaterBillAverage.Size = new System.Drawing.Size(100, 22);
            this.txtWaterBillAverage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(92, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Water bill average";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWaterBillAverage);
            this.Controls.Add(this.txtFourWaterBills);
            this.Controls.Add(this.lblFourWaterBills);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "WaterBillAnalysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFourWaterBills;
        private System.Windows.Forms.TextBox txtFourWaterBills;
        private System.Windows.Forms.TextBox txtWaterBillAverage;
        private System.Windows.Forms.Label label2;
    }
}

