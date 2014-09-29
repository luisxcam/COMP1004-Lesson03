/*
 * Name: Luis Acevedo
 * Version 2014/Sept/22
 * Purpose: This application calculates the discount on book sales for an amount of books.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Lesson03
{
    public partial class BookSaleForm : Form
    {
        //variable definition
        private int salesCountInteger, quantitySumInteger;
        private decimal discountSumDecimal, discountedPriceSumDecimal;

        //Methods
        public BookSaleForm()
        {
            InitializeComponent();
        }

        /*
         * It calculates the sale price, discount, and the extended price
         * It also maintains the summary information
         * Displays all the information
         */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //local variables
            int quantityInteger;
            decimal priceDecimal, discountDecimal, extendedPriceDecimal, discountedPriceDecimal, averageDiscountDecimal;

            const decimal DISCOUNT_RATE_DECIMAL = 0.15m;
            //option 2 const decimal DISCOUNT_RATE_DECIMAL = (decimal) 0.15;
            if (titleTextBox.Text != "")
            {
                try
                {
                    quantityInteger = int.Parse(quantityTextBox.Text);

                    if (quantityInteger > 0)
                    {
                        try
                        {
                            priceDecimal = decimal.Parse(priceTextBox.Text);

                            if (priceDecimal > 0)
                            {
                                //proceed with the calculations
                                extendedPriceDecimal = quantityInteger * priceDecimal;
                                discountDecimal = extendedPriceDecimal * DISCOUNT_RATE_DECIMAL;
                                discountedPriceDecimal = extendedPriceDecimal - discountDecimal;

                                //summary
                                salesCountInteger++;
                                quantitySumInteger += quantityInteger;
                                discountSumDecimal += discountDecimal;
                                discountedPriceSumDecimal += discountedPriceDecimal;
                                averageDiscountDecimal = discountSumDecimal / salesCountInteger;

                                //display the information
                                extendedPriceTextBox.Text = extendedPriceDecimal.ToString("c");
                                discountTextBox.Text = discountDecimal.ToString("c");
                                discountedPriceTextBox.Text = discountedPriceDecimal.ToString("c");

                                quantitySumTextBox.Text = quantitySumInteger.ToString("d");
                                discountSumTextBox.Text = discountSumDecimal.ToString("c");
                                discountedAmountSumTextBox.Text = discountedPriceSumDecimal.ToString("c");
                                averageDiscountTextBox.Text = averageDiscountDecimal.ToString("c");
                            }
                            else
                            {
                                MessageBox.Show("Price must be greater than Zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (FormatException priceException)
                        {
                            MessageBox.Show("Price must be a numeric number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            priceTextBox.SelectAll();
                            priceTextBox.Focus();
                        }
                        catch (Exception exceptionMessage2)
                        {
                            MessageBox.Show(exceptionMessage2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input a value greater than Zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException quantityException)
                {
                    MessageBox.Show("Quantity must be a whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    quantityTextBox.SelectAll();
                    quantityTextBox.Focus();
                }
                catch (Exception exceptionMessage)
                {
                    MessageBox.Show(exceptionMessage.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please input the name of the book", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         * clear the input information and the current sale information
         * set focus quantity
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all the boxes
            quantityTextBox.Clear();
            titleTextBox.Clear();
            priceTextBox.Clear();

            extendedPriceTextBox.Clear();
            discountTextBox.Clear();
            discountedPriceTextBox.Clear();

            //Set the cursor to the established variable
            quantityTextBox.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
        private void printForm_Click(object sender, EventArgs e)
        {
            //Prints the form with book sale information.
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
