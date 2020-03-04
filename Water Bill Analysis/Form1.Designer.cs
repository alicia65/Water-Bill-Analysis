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
            this.lblFirstQuarter = new System.Windows.Forms.Label();
            this.lblSecondQuarter = new System.Windows.Forms.Label();
            this.lblThirdQuarter = new System.Windows.Forms.Label();
            this.lblFourthQuarter = new System.Windows.Forms.Label();
            this.txtFirstQuarter = new System.Windows.Forms.TextBox();
            this.txtSecondQuarter = new System.Windows.Forms.TextBox();
            this.txtThirdQuarter = new System.Windows.Forms.TextBox();
            this.txtFourthQuarter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstQuarter
            // 
            this.lblFirstQuarter.Location = new System.Drawing.Point(12, 33);
            this.lblFirstQuarter.Name = "lblFirstQuarter";
            this.lblFirstQuarter.Size = new System.Drawing.Size(100, 23);
            this.lblFirstQuarter.TabIndex = 0;
            this.lblFirstQuarter.Text = "First Quarter";
            this.lblFirstQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondQuarter
            // 
            this.lblSecondQuarter.Location = new System.Drawing.Point(12, 81);
            this.lblSecondQuarter.Name = "lblSecondQuarter";
            this.lblSecondQuarter.Size = new System.Drawing.Size(118, 23);
            this.lblSecondQuarter.TabIndex = 1;
            this.lblSecondQuarter.Text = "Second Quarter";
            this.lblSecondQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdQuarter
            // 
            this.lblThirdQuarter.Location = new System.Drawing.Point(12, 128);
            this.lblThirdQuarter.Name = "lblThirdQuarter";
            this.lblThirdQuarter.Size = new System.Drawing.Size(100, 23);
            this.lblThirdQuarter.TabIndex = 2;
            this.lblThirdQuarter.Text = "Third Quarter";
            this.lblThirdQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThirdQuarter.Click += new System.EventHandler(this.lblThirdQuarter_Click);
            // 
            // lblFourthQuarter
            // 
            this.lblFourthQuarter.Location = new System.Drawing.Point(12, 168);
            this.lblFourthQuarter.Name = "lblFourthQuarter";
            this.lblFourthQuarter.Size = new System.Drawing.Size(118, 23);
            this.lblFourthQuarter.TabIndex = 3;
            this.lblFourthQuarter.Text = "Fourth Quarter";
            this.lblFourthQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstQuarter
            // 
            this.txtFirstQuarter.Location = new System.Drawing.Point(135, 34);
            this.txtFirstQuarter.Name = "txtFirstQuarter";
            this.txtFirstQuarter.Size = new System.Drawing.Size(100, 22);
            this.txtFirstQuarter.TabIndex = 0;
            // 
            // txtSecondQuarter
            // 
            this.txtSecondQuarter.Location = new System.Drawing.Point(135, 82);
            this.txtSecondQuarter.Name = "txtSecondQuarter";
            this.txtSecondQuarter.Size = new System.Drawing.Size(100, 22);
            this.txtSecondQuarter.TabIndex = 1;
            // 
            // txtThirdQuarter
            // 
            this.txtThirdQuarter.Location = new System.Drawing.Point(135, 128);
            this.txtThirdQuarter.Name = "txtThirdQuarter";
            this.txtThirdQuarter.Size = new System.Drawing.Size(100, 22);
            this.txtThirdQuarter.TabIndex = 2;
            // 
            // txtFourthQuarter
            // 
            this.txtFourthQuarter.Location = new System.Drawing.Point(135, 169);
            this.txtFourthQuarter.Name = "txtFourthQuarter";
            this.txtFourthQuarter.Size = new System.Drawing.Size(100, 22);
            this.txtFourthQuarter.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(135, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(409, 139);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(409, 196);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 22);
            this.txtAverage.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(295, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(306, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Average";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFourthQuarter);
            this.Controls.Add(this.txtThirdQuarter);
            this.Controls.Add(this.txtSecondQuarter);
            this.Controls.Add(this.txtFirstQuarter);
            this.Controls.Add(this.lblFourthQuarter);
            this.Controls.Add(this.lblThirdQuarter);
            this.Controls.Add(this.lblSecondQuarter);
            this.Controls.Add(this.lblFirstQuarter);
            this.Name = "Form1";
            this.Text = "Average Quarterly Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstQuarter;
        private System.Windows.Forms.Label lblSecondQuarter;
        private System.Windows.Forms.Label lblThirdQuarter;
        private System.Windows.Forms.Label lblFourthQuarter;
        private System.Windows.Forms.TextBox txtFirstQuarter;
        private System.Windows.Forms.TextBox txtSecondQuarter;
        private System.Windows.Forms.TextBox txtThirdQuarter;
        private System.Windows.Forms.TextBox txtFourthQuarter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
    }
}

