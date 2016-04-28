/****
Christopher Dack
Basic Calculator
Class Assignment, Introduction to C#
Abstract: This class contains methods for performing calculations and returning the results
to Form1.cs.
****/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcOperations
    {
        // Member variables
        decimal scratch;
        decimal result;

        // Default constructor
        public CalcOperations()
        {
            scratch = 0m;
            result = 0m;
        }

        // Accessor methods
        public decimal GetResult()
        {
            return result;
        }

        // Performs four basic calculations and returns result
        public decimal CalcResult(decimal scratchFromForm, string Operator, decimal resultFromForm)
        {
            scratch = scratchFromForm;
            result = resultFromForm;
            switch(Operator)
            {
                case("+"):
                    result += scratch;
                    break;
                case("-"):
                    result -= scratch;
                    break;
                case("*"):
                    result *= scratch;
                    break;
                case("/"):
                    result /= scratch;
                    break;
            }
            return result;
        }
        
        // Square Root method
        public  decimal CalcSquareRoot(decimal scratchFromForm)
        {
            double square = Convert.ToDouble(scratchFromForm);
            double sqrt = Math.Sqrt(square);
            result = Convert.ToDecimal(sqrt);
            return result;
        }

        // Reciprocal method
        public decimal CalcReciprocal(decimal scratchFromForm)
        {
            result = 1 / scratchFromForm;
            return result;
        }

        // Clear method
        public void Clear()
        {
            scratch = 0m;
            result = 0m;
        }
    }
}
