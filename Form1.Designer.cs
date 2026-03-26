namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            txtProblem = new TextBox();
            txtResult = new TextBox();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDivision = new Button();
            btnTimes = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            // 
            // btnCE
            // 
            btnCE.Font = new Font("맑은 고딕", 12F);
            btnCE.Location = new Point(20, 160);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(65, 44);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("맑은 고딕", 12F);
            btnC.Location = new Point(91, 160);
            btnC.Name = "btnC";
            btnC.Size = new Size(65, 44);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("맑은 고딕", 12F);
            btnDel.Location = new Point(162, 160);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(65, 44);
            btnDel.TabIndex = 3;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn7.ForeColor = Color.RoyalBlue;
            btn7.Location = new Point(20, 213);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 44);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn8.ForeColor = Color.RoyalBlue;
            btn8.Location = new Point(91, 213);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 44);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn9.ForeColor = Color.RoyalBlue;
            btn9.Location = new Point(162, 213);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 44);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(18, 71);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(278, 23);
            txtProblem.TabIndex = 7;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(18, 109);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(278, 23);
            txtResult.TabIndex = 8;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn4.ForeColor = Color.RoyalBlue;
            btn4.Location = new Point(20, 267);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 44);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn5.ForeColor = Color.RoyalBlue;
            btn5.Location = new Point(91, 267);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 44);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn6.ForeColor = Color.RoyalBlue;
            btn6.Location = new Point(162, 267);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 44);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn1.ForeColor = Color.RoyalBlue;
            btn1.Location = new Point(20, 317);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 44);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn2.ForeColor = Color.RoyalBlue;
            btn2.Location = new Point(91, 317);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 44);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn3.ForeColor = Color.RoyalBlue;
            btn3.Location = new Point(162, 317);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 44);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDivision.ForeColor = Color.OrangeRed;
            btnDivision.Location = new Point(233, 160);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(65, 44);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTimes.ForeColor = Color.OrangeRed;
            btnTimes.Location = new Point(233, 213);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(65, 44);
            btnTimes.TabIndex = 16;
            btnTimes.Text = "X";
            btnTimes.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMinus.ForeColor = Color.OrangeRed;
            btnMinus.Location = new Point(233, 267);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 44);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += Operator_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPlus.ForeColor = Color.OrangeRed;
            btnPlus.Location = new Point(233, 317);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(65, 44);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operator_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn0.ForeColor = Color.RoyalBlue;
            btn0.Location = new Point(91, 367);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 41);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 18F);
            btnEqual.Location = new Point(233, 367);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(65, 41);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 455);
            Controls.Add(btnEqual);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnTimes);
            Controls.Add(btnDivision);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(txtResult);
            Controls.Add(txtProblem);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private TextBox txtProblem;
        private TextBox txtResult;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDivision;
        private Button btnTimes;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn0;
        private Button btnEqual;
    }
}
