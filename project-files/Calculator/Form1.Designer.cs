namespace Calculator
{
    partial class Calculator
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPositiveNegative = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AccessibleDescription = "Display Area for operands, results, etc.";
            this.lblDisplay.AccessibleName = "Display area";
            this.lblDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(25, 27);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(353, 36);
            this.lblDisplay.TabIndex = 50;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn7
            // 
            this.btn7.AccessibleDescription = "7 Button";
            this.btn7.AccessibleName = "7 Button";
            this.btn7.BackColor = System.Drawing.Color.Gray;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(25, 157);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 51);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleDescription = "8 Button";
            this.btn8.AccessibleName = "8 Button";
            this.btn8.BackColor = System.Drawing.Color.Gray;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(100, 157);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 51);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleDescription = "9 Button";
            this.btn9.AccessibleName = "9 Button";
            this.btn9.BackColor = System.Drawing.Color.Gray;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(175, 157);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 51);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AccessibleDescription = "Divide Button";
            this.btnDivide.AccessibleName = "Divide Button";
            this.btnDivide.BackColor = System.Drawing.Color.Gray;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivide.Location = new System.Drawing.Point(250, 157);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(53, 51);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleDescription = "4 Button";
            this.btn4.AccessibleName = "4 Button";
            this.btn4.BackColor = System.Drawing.Color.Gray;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(25, 233);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 51);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleDescription = "1 Button";
            this.btn1.AccessibleName = "1 Button";
            this.btn1.BackColor = System.Drawing.Color.Gray;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(25, 309);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 51);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleDescription = "Zero button";
            this.btn0.AccessibleName = "Zero button";
            this.btn0.BackColor = System.Drawing.Color.Gray;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(25, 385);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 51);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Back button";
            this.btnBack.AccessibleName = "Back button";
            this.btnBack.BackColor = System.Drawing.Color.Sienna;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(25, 82);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "Clear Button";
            this.btnClear.AccessibleName = "Clear Button";
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(175, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(203, 51);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleDescription = "5 Button";
            this.btn5.AccessibleName = "5 Button";
            this.btn5.BackColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(100, 233);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 51);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleDescription = "6 Button";
            this.btn6.AccessibleName = "6 Button";
            this.btn6.BackColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(175, 233);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 51);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AccessibleDescription = "Multiply Button";
            this.btnMultiply.AccessibleName = "Multiply Button";
            this.btnMultiply.BackColor = System.Drawing.Color.Gray;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMultiply.Location = new System.Drawing.Point(250, 233);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(53, 51);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleDescription = "2 Button";
            this.btn2.AccessibleName = "2 Button";
            this.btn2.BackColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(100, 309);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 51);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleDescription = "3 Button";
            this.btn3.AccessibleName = "3 Button";
            this.btn3.BackColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(175, 309);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 51);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.DigitEntry_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.AccessibleDescription = "Subtract Button";
            this.btnSubtract.AccessibleName = "Subtract Button";
            this.btnSubtract.BackColor = System.Drawing.Color.Gray;
            this.btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubtract.Location = new System.Drawing.Point(250, 309);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(53, 51);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.AccessibleDescription = "Equals Button";
            this.btnEquals.AccessibleName = "Equals Button";
            this.btnEquals.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquals.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(325, 309);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(53, 127);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPositiveNegative
            // 
            this.btnPositiveNegative.AccessibleDescription = "Positive / Negative Button";
            this.btnPositiveNegative.AccessibleName = "Positive / Negative Button";
            this.btnPositiveNegative.BackColor = System.Drawing.Color.Gray;
            this.btnPositiveNegative.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPositiveNegative.FlatAppearance.BorderSize = 0;
            this.btnPositiveNegative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPositiveNegative.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositiveNegative.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPositiveNegative.Location = new System.Drawing.Point(100, 385);
            this.btnPositiveNegative.Name = "btnPositiveNegative";
            this.btnPositiveNegative.Size = new System.Drawing.Size(53, 51);
            this.btnPositiveNegative.TabIndex = 18;
            this.btnPositiveNegative.Text = "+ / -";
            this.btnPositiveNegative.UseVisualStyleBackColor = false;
            this.btnPositiveNegative.Click += new System.EventHandler(this.btnPositiveNegative_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.AccessibleDescription = "Decimal Point Button";
            this.btnDecimalPoint.AccessibleName = "Decimal Point Button";
            this.btnDecimalPoint.BackColor = System.Drawing.Color.Gray;
            this.btnDecimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDecimalPoint.FlatAppearance.BorderSize = 0;
            this.btnDecimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecimalPoint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDecimalPoint.Location = new System.Drawing.Point(175, 385);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(53, 51);
            this.btnDecimalPoint.TabIndex = 19;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnDecimalPoint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Add Button";
            this.btnAdd.AccessibleName = "Add Button";
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(250, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 51);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.AccessibleDescription = "Square Root Button";
            this.btnSquareRoot.AccessibleName = "Square Root Button";
            this.btnSquareRoot.BackColor = System.Drawing.Color.Gray;
            this.btnSquareRoot.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSquareRoot.FlatAppearance.BorderSize = 0;
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquareRoot.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSquareRoot.Location = new System.Drawing.Point(325, 157);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(53, 51);
            this.btnSquareRoot.TabIndex = 7;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.AccessibleDescription = "Reciprocal Button";
            this.btnReciprocal.AccessibleName = "Reciprocal Button";
            this.btnReciprocal.BackColor = System.Drawing.Color.Gray;
            this.btnReciprocal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReciprocal.FlatAppearance.BorderSize = 0;
            this.btnReciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReciprocal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReciprocal.Location = new System.Drawing.Point(325, 233);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(53, 51);
            this.btnReciprocal.TabIndex = 12;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AccessibleDescription = "Calculator";
            this.AccessibleName = "Calculator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(407, 466);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btnPositiveNegative);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPositiveNegative;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnReciprocal;
    }
}

