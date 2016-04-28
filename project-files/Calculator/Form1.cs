/****
Christopher Dack
Basic Calculator
Class Assignment, Introduction to C#
Abstract: This form contains controls for a basic calculator and allows user input and interaction.
Math operations are performed by calling methods in the CalcOperations class.
****/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //Initialize global variables for ScratchString, Scratch, Operator, and Result
        string scratchString = "";
        decimal scratch = 0m;
        string op = "";
        decimal result = 0m;

        //Instantiate class
        CalcOperations Calculator1 = new CalcOperations();

        // Accepts an Operator argument from whatever button called it (+, -, *, or /).
        // Processes the user-entered ScratchString, then clears it for the next user entry.
        public void OperatorChange(string newOperator)
        {
            try
            {
                if (scratchString.Length != 0)
                {
                    scratch = Convert.ToDecimal(scratchString.ToString());
                }
                result = scratch;
                op = newOperator;
                scratchString = "";
            }
            catch
            {
                MessageBox.Show("An unknown error occurred. Please start again.", "Error");
            }
        }

        // Processes ScratchString. Calls the CalcResult() method to calculate the result.
        // Displays the result, formatting division operations to 8 decimal places.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (scratchString.Length != 0)
                {
                    scratch = Convert.ToDecimal(scratchString);
                }
                if (op == "/" && scratch == 0)
                {
                    scratchString = "";
                    scratch = 0m;
                    op = "";
                    result = 0m;
                    lblDisplay.Text = "Canot divide by zero";
                }
                else
                {
                    result = Calculator1.CalcResult(scratch, op, result);
                    if (op == "/")
                    {
                        lblDisplay.Text = result.ToString("f8");
                    }
                    else
                    {
                        lblDisplay.Text = result.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error");
            }
        }

        // Verifies that scratchString (user input) is not empty, then calls the SquareRoot method
        // from the CalcOperations class, retrieves the result, and displays it.
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                if (scratchString.Length != 0)
                {
                    scratch = Convert.ToDecimal(scratchString);
                }
                result = Calculator1.CalcSquareRoot(scratch);
                scratchString = result.ToString();
                lblDisplay.Text = result.ToString("f8");

            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error");
            }
        }

        // Verifies that the scratchString (user input) is not blank. Catches any attempt that would result in a divide by zero
        // error. Calls the Reciprocal method from the CalcOperations class, retrieves the result, and displays it.
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                if (scratchString.Length != 0)
                {
                    // If not zero, then shit is in there.  Need to convert to SS to Scratch, send it away, get result back, display it, and CLEAR SS because this is first time thru
                    scratch = Convert.ToDecimal(scratchString);
                    if (scratch == 0)
                    {
                        // Reset all variables
                        lblDisplay.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        result = Calculator1.CalcReciprocal(scratch);
                        scratchString = "";
                        lblDisplay.Text = result.ToString("f8");
                    }
                }
                else
                {
                    scratch = result;
                    result = Calculator1.CalcReciprocal(scratch);
                    lblDisplay.Text = result.ToString("f8");
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error");
            }
        }

        // Removes the last-entered character from the ScratchString being built from user entries
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (scratchString.Length != 0)
                {
                    StringBuilder scratchIntermediate = new StringBuilder(scratchString);
                    scratchIntermediate.Remove(scratchIntermediate.Length - 1, 1);
                    scratchString = scratchIntermediate.ToString();
                    lblDisplay.Text = scratchString;
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error");
            }
         }

        // Resets all variables to initial values and displays zero.
        // Also calls the Clear method in the CalcOperations class to reset those values to defaults.
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                scratchString = "";
                scratch = 0m;
                op = "";
                result = 0m;
                btnClear.Focus();
                lblDisplay.Text = result.ToString();
                Calculator1.Clear();
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error");
            }
        }

        // Calls the OperatorChange method and passes the text of the Operator button pressed as the new Operator
        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            OperatorChange(op);
        }
        
        // Verifies that the scratchString (user input) is not blank.
        // Reverses the positive or negative of the value and displays it.
        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            try
            {
                scratchString = lblDisplay.Text;
                if (scratchString.Length != 0)
                {
                    scratch = Convert.ToDecimal(scratchString.ToString());
                    scratch = scratch * -1;
                    scratchString = scratch.ToString();
                    lblDisplay.Text = scratchString;
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Please start again.", "Error"); 
            }
        }

        private void DigitEntry_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            scratchString += b.Text;
            lblDisplay.Text = scratchString;
        }
        
        // Allows users to add a decmial point to their input
        // Catches attempts to enter multiple decimal points and prevents them.
        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            int DecimalCount = 0;
            foreach (char c in scratchString)
            {
                if (c == '.')
                {
                    DecimalCount++;
                }
            }
            if (DecimalCount == 0)
            {
                scratchString += ".";
                lblDisplay.Text = scratchString;
            }
        }

        private void btnJunk_Click(object sender, EventArgs e)
        {
        }

    }
}
