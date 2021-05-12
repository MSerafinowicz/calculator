namespace WindowsFormsApp1
{
    partial class BasicCalculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonBox = new System.Windows.Forms.TableLayoutPanel();
            this.CEbutton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultipleButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.CommaButton = new System.Windows.Forms.Button();
            this.EqualityButton = new System.Windows.Forms.Button();
            this.ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(209, 21);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculationResultText.Location = new System.Drawing.Point(12, 35);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(208, 37);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "=...";
            this.CalculationResultText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonBox
            // 
            this.ButtonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBox.ColumnCount = 4;
            this.ButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonBox.Controls.Add(this.CEbutton, 0, 0);
            this.ButtonBox.Controls.Add(this.SqrtButton, 1, 0);
            this.ButtonBox.Controls.Add(this.DelButton, 2, 0);
            this.ButtonBox.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonBox.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonBox.Controls.Add(this.EightButton, 1, 1);
            this.ButtonBox.Controls.Add(this.NineButton, 2, 1);
            this.ButtonBox.Controls.Add(this.MultipleButton, 3, 1);
            this.ButtonBox.Controls.Add(this.FourButton, 0, 2);
            this.ButtonBox.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonBox.Controls.Add(this.SixButton, 2, 2);
            this.ButtonBox.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonBox.Controls.Add(this.OneButton, 0, 3);
            this.ButtonBox.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonBox.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonBox.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonBox.Controls.Add(this.button15, 0, 4);
            this.ButtonBox.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonBox.Controls.Add(this.CommaButton, 2, 4);
            this.ButtonBox.Controls.Add(this.EqualityButton, 3, 4);
            this.ButtonBox.Location = new System.Drawing.Point(12, 75);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.RowCount = 5;
            this.ButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonBox.Size = new System.Drawing.Size(210, 144);
            this.ButtonBox.TabIndex = 2;
            this.ButtonBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonBox_Paint);
            // 
            // CEbutton
            // 
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(46, 22);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click_1);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqrtButton.Location = new System.Drawing.Point(55, 3);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(46, 22);
            this.SqrtButton.TabIndex = 3;
            this.SqrtButton.Text = "√";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(107, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(46, 22);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(159, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(48, 22);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "/";
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 31);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(46, 22);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(55, 31);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(46, 22);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(107, 31);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(46, 22);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // MultipleButton
            // 
            this.MultipleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultipleButton.Location = new System.Drawing.Point(159, 31);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(48, 22);
            this.MultipleButton.TabIndex = 9;
            this.MultipleButton.Text = "X";
            this.MultipleButton.UseVisualStyleBackColor = true;
            this.MultipleButton.Click += new System.EventHandler(this.MultipleButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 59);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(46, 22);
            this.FourButton.TabIndex = 10;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(55, 59);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(46, 22);
            this.FiveButton.TabIndex = 11;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(107, 59);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(46, 22);
            this.SixButton.TabIndex = 12;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(159, 59);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(48, 22);
            this.MinusButton.TabIndex = 13;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 87);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(46, 22);
            this.OneButton.TabIndex = 14;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(55, 87);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(46, 22);
            this.TwoButton.TabIndex = 15;
            this.TwoButton.Text = "2";
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(107, 87);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(46, 22);
            this.ThreeButton.TabIndex = 16;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(159, 87);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(48, 22);
            this.PlusButton.TabIndex = 17;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(3, 115);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 26);
            this.button15.TabIndex = 18;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(55, 115);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(46, 26);
            this.ZeroButton.TabIndex = 19;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // CommaButton
            // 
            this.CommaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommaButton.Location = new System.Drawing.Point(107, 115);
            this.CommaButton.Name = "CommaButton";
            this.CommaButton.Size = new System.Drawing.Size(46, 26);
            this.CommaButton.TabIndex = 20;
            this.CommaButton.Text = ".";
            this.CommaButton.UseVisualStyleBackColor = true;
            this.CommaButton.Click += new System.EventHandler(this.CommaButton_Click);
            // 
            // EqualityButton
            // 
            this.EqualityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualityButton.Location = new System.Drawing.Point(159, 115);
            this.EqualityButton.Name = "EqualityButton";
            this.EqualityButton.Size = new System.Drawing.Size(48, 26);
            this.EqualityButton.TabIndex = 21;
            this.EqualityButton.Text = "=";
            this.EqualityButton.UseVisualStyleBackColor = true;
            this.EqualityButton.Click += new System.EventHandler(this.EqualityButton_Click);
            // 
            // BasicCalculator
            // 
            this.AcceptButton = this.EqualityButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(234, 231);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(250, 270);
            this.Name = "BasicCalculator";
            this.Text = "BasicCalculator";
            this.ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonBox;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button MultipleButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button CommaButton;
        private System.Windows.Forms.Button EqualityButton;
    }
}

