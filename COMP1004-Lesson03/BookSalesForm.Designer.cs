﻿namespace COMP1004_Lesson03
{
    partial class BookSaleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSaleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.discountedPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.extendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.averageDiscountTextBox = new System.Windows.Forms.TextBox();
            this.discountedAmountSumTextBox = new System.Windows.Forms.TextBox();
            this.discountSumTextBox = new System.Windows.Forms.TextBox();
            this.quantitySumTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.byLabel = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.printForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Sales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(60, 73);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(60, 49);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(295, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(60, 25);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.discountedPriceTextBox);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.extendedPriceTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Value";
            // 
            // discountedPriceTextBox
            // 
            this.discountedPriceTextBox.Location = new System.Drawing.Point(255, 65);
            this.discountedPriceTextBox.Name = "discountedPriceTextBox";
            this.discountedPriceTextBox.ReadOnly = true;
            this.discountedPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountedPriceTextBox.TabIndex = 8;
            this.discountedPriceTextBox.TabStop = false;
            this.discountedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(255, 39);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 7;
            this.discountTextBox.TabStop = false;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // extendedPriceTextBox
            // 
            this.extendedPriceTextBox.Location = new System.Drawing.Point(255, 13);
            this.extendedPriceTextBox.Name = "extendedPriceTextBox";
            this.extendedPriceTextBox.ReadOnly = true;
            this.extendedPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.extendedPriceTextBox.TabIndex = 6;
            this.extendedPriceTextBox.TabStop = false;
            this.extendedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Discounted Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "15% Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Extended Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.averageDiscountTextBox);
            this.groupBox3.Controls.Add(this.discountedAmountSumTextBox);
            this.groupBox3.Controls.Add(this.discountSumTextBox);
            this.groupBox3.Controls.Add(this.quantitySumTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // averageDiscountTextBox
            // 
            this.averageDiscountTextBox.Location = new System.Drawing.Point(255, 101);
            this.averageDiscountTextBox.Name = "averageDiscountTextBox";
            this.averageDiscountTextBox.ReadOnly = true;
            this.averageDiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageDiscountTextBox.TabIndex = 12;
            this.averageDiscountTextBox.TabStop = false;
            this.averageDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountedAmountSumTextBox
            // 
            this.discountedAmountSumTextBox.Location = new System.Drawing.Point(255, 74);
            this.discountedAmountSumTextBox.Name = "discountedAmountSumTextBox";
            this.discountedAmountSumTextBox.ReadOnly = true;
            this.discountedAmountSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountedAmountSumTextBox.TabIndex = 11;
            this.discountedAmountSumTextBox.TabStop = false;
            this.discountedAmountSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountSumTextBox
            // 
            this.discountSumTextBox.Location = new System.Drawing.Point(255, 47);
            this.discountSumTextBox.Name = "discountSumTextBox";
            this.discountSumTextBox.ReadOnly = true;
            this.discountSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountSumTextBox.TabIndex = 10;
            this.discountSumTextBox.TabStop = false;
            this.discountSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantitySumTextBox
            // 
            this.quantitySumTextBox.Location = new System.Drawing.Point(255, 20);
            this.quantitySumTextBox.Name = "quantitySumTextBox";
            this.quantitySumTextBox.ReadOnly = true;
            this.quantitySumTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantitySumTextBox.TabIndex = 9;
            this.quantitySumTextBox.TabStop = false;
            this.quantitySumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Average Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Discounted Amounts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Discounts Given";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Number of Books";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(110, 388);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(207, 389);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear &Sale";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(304, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLabel.Location = new System.Drawing.Point(274, 428);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(106, 13);
            this.byLabel.TabIndex = 8;
            this.byLabel.Text = "By. Luis Acevedo";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // printForm
            // 
            this.printForm.Location = new System.Drawing.Point(12, 389);
            this.printForm.Name = "printForm";
            this.printForm.Size = new System.Drawing.Size(75, 23);
            this.printForm.TabIndex = 1;
            this.printForm.Text = "Print &Form";
            this.printForm.UseVisualStyleBackColor = true;
            this.printForm.Click += new System.EventHandler(this.printForm_Click);
            // 
            // BookSaleForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.printForm);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R n\' R for Reading and Refreshments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox discountedPriceTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox extendedPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox averageDiscountTextBox;
        private System.Windows.Forms.TextBox discountedAmountSumTextBox;
        private System.Windows.Forms.TextBox discountSumTextBox;
        private System.Windows.Forms.TextBox quantitySumTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label byLabel;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button printForm;
    }
}

