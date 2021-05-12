using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        #region Clearing


        //Clears the user input text
        private void CEbutton_Click_1(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            FocusInputText();
        }

        //Clears one sign to the right
        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();
            FocusInputText();
        }

        #endregion

        #region Functions

        private void CommaButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(",");
            FocusInputText();
        }

        private void EqualityButton_Click(object sender, EventArgs e)
        {
            Calculate();
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void MultipleButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("√");
            FocusInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        #endregion

        #region Numbers

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }
        #endregion

        #region Private Helpers

        private void Calculate()
        {
            this.CalculationResultText.Text = ParseOperation();
            FocusInputText();
        }

        //Calculates result
        private string ParseOperation()
        {
            try
            {
                //Get the users input
                var Input = this.UserInputText.Text;
                //remove all spaces
                Input = Input.Replace(" ","");



                //create new top level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through every sign in input
                for (int i= 0; i < Input.Length; i++)
                {
                    //todo ; handle priority
                    //Check if the current character is number

                    if ("0123456789.,".Any(c => Input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, Input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, Input[i]);
                    }
                    //If it is operator set to operator type
                    else if ("+-*/".Any(c => Input[i] == c))
                    {
                        if(!leftSide)
                        {
                            //get the operator type
                            var OperationType = GetOperationType(Input[i]);

                            //check if we have a right side number
                            if(operation.RightSide.Length == 0)
                            {
                                if(OperationType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -)");

                                operation.RightSide += Input[i];
                            }
                            else
                            {
                                //calculate previous equation and set to the left side
                                operation.LeftSide = CalcualteOperation(operation);

                                //set new operator
                                operation.OperationType = OperationType;

                                //clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            //get the operator type
                            var OperationType = GetOperationType(Input[i]);

                            //check if we have a left side number
                            if(operation.LeftSide.Length == 0)
                            {
                                //check the operator is not a minus
                                if (OperationType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -)");

                                //if we got here the operator type is minus and there is no left currently so add minus to the number
                                operation.LeftSide += Input[i];

                            }
                            else
                            {
                                //if we get here we have a left number and now an operator so we want to move to the right side

                                //set the operation type
                                operation.OperationType = OperationType;

                                //move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                //if we are done parsing and there were no exceptions
                //calculate the current operation
                return CalcualteOperation(operation);

            }
            catch (Exception ex)
            {
                return $"Invalid equalition. { ex.Message}";
            }
        }


        /// <summary>
        ///     Calculates a<see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">the operation to calcualte</param>
        private string CalcualteOperation(Operation operation)
        {
            //store the number values of the string representations
            double left = 0;
            double right = 0;

            //check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of operation was not a number. {operation.LeftSide}");

            //check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of operation was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:throw new InvalidOperationException($"Unknow operator type when calculating operation.{operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation{operation.LeftSide}{operation.OperationType}{operation.RightSide} . {ex.Message}");
            }
        }


        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">the character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch(character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }


        //Attemps to add a new character to current number, checking for valid characters as it goes
        private string AddNumberPart(string currentNumber, char currentCharacter)
        {
            //check if there is already a . in the number
            if (currentCharacter == '.' && currentNumber.Contains("."))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + currentCharacter;
        }

        //Focuses input textbox
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        //inserts text in chosen place
        private void InsertTextValue(string value)
        {
            //Remember SelectionStart
            var selectionStart = this.UserInputText.SelectionStart;
            //Sets new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
            //Restore SelectionStart
            this.UserInputText.SelectionStart = selectionStart + value.Length;
            //Sets SelectionLength to zero
            this.UserInputText.SelectionLength = 0;
        }

        //Deletes text in chosen place
        private void DeleteTextValue()
        {
            //if nothing to delete return;
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            //Remember SelectionStart
            var selectionStart = this.UserInputText.SelectionStart;
            //Deletes text
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            //Restore SelectionStart
            this.UserInputText.SelectionStart = selectionStart;
            //Sets SelectionLength to zero
            this.UserInputText.SelectionLength = 0;
        }
        #endregion

        private void ButtonBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
