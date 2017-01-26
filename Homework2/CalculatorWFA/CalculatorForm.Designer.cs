using System;

namespace Problem1.c_Calculator
{
    partial class CalculatorForm
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnRational1X = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.numbersPanel.SuspendLayout();
            this.operationsPanel.SuspendLayout();
            this.functionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(12, 16);
            this.inputField.Name = "inputField";
            this.inputField.ReadOnly = true;
            this.inputField.Size = new System.Drawing.Size(356, 20);
            this.inputField.TabIndex = 0;
            this.inputField.Text = "0";
            this.inputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numbersPanel
            // 
            this.numbersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numbersPanel.Controls.Add(this.btn00);
            this.numbersPanel.Controls.Add(this.btn0);
            this.numbersPanel.Controls.Add(this.btn9);
            this.numbersPanel.Controls.Add(this.btn8);
            this.numbersPanel.Controls.Add(this.btn7);
            this.numbersPanel.Controls.Add(this.btn6);
            this.numbersPanel.Controls.Add(this.btn5);
            this.numbersPanel.Controls.Add(this.btn4);
            this.numbersPanel.Controls.Add(this.btn3);
            this.numbersPanel.Controls.Add(this.btn2);
            this.numbersPanel.Controls.Add(this.btn1);
            this.numbersPanel.Location = new System.Drawing.Point(12, 48);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(88, 122);
            this.numbersPanel.TabIndex = 1;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(33, 90);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(51, 24);
            this.btn00.TabIndex = 10;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 91);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(24, 24);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(60, 63);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(24, 24);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(33, 63);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(24, 24);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 63);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(24, 24);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(60, 33);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(24, 24);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(33, 33);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(24, 24);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 33);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(24, 24);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(60, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(24, 24);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(33, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(24, 24);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(24, 24);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operationsPanel
            // 
            this.operationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.operationsPanel.Controls.Add(this.btnAdd);
            this.operationsPanel.Controls.Add(this.btnPoint);
            this.operationsPanel.Controls.Add(this.btnEquals);
            this.operationsPanel.Controls.Add(this.btnDevide);
            this.operationsPanel.Controls.Add(this.btnMultiply);
            this.operationsPanel.Controls.Add(this.btnSubstract);
            this.operationsPanel.Location = new System.Drawing.Point(106, 48);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(66, 122);
            this.operationsPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 83);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(3, 91);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(24, 24);
            this.btnPoint.TabIndex = 5;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(33, 91);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(24, 24);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Location = new System.Drawing.Point(33, 63);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(24, 24);
            this.btnDevide.TabIndex = 3;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(33, 33);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(24, 24);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(33, 3);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(24, 24);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.button11_Click);
            // 
            // functionsPanel
            // 
            this.functionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionsPanel.Controls.Add(this.btnClearAll);
            this.functionsPanel.Controls.Add(this.btnClear);
            this.functionsPanel.Location = new System.Drawing.Point(309, 48);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.Size = new System.Drawing.Size(59, 97);
            this.functionsPanel.TabIndex = 3;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(6, 52);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(45, 35);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "C/A";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 42);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(178, 149);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(190, 21);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSqrt);
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.btnRational1X);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnSin);
            this.panel1.Location = new System.Drawing.Point(178, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 97);
            this.panel1.TabIndex = 5;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(63, 33);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(54, 24);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(3, 33);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(54, 24);
            this.btnExp.TabIndex = 13;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(63, 4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(54, 24);
            this.btnCos.TabIndex = 12;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnRational1X
            // 
            this.btnRational1X.Location = new System.Drawing.Point(63, 63);
            this.btnRational1X.Name = "btnRational1X";
            this.btnRational1X.Size = new System.Drawing.Size(54, 24);
            this.btnRational1X.TabIndex = 11;
            this.btnRational1X.Text = "1/X";
            this.btnRational1X.UseVisualStyleBackColor = true;
            this.btnRational1X.Click += new System.EventHandler(this.btnRational1X_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(3, 63);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(54, 24);
            this.btnLog.TabIndex = 10;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(3, 3);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(54, 24);
            this.btnSin.TabIndex = 6;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 177);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.functionsPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.numbersPanel);
            this.Controls.Add(this.inputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.numbersPanel.ResumeLayout(false);
            this.operationsPanel.ResumeLayout(false);
            this.functionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Panel numbersPanel;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnRational1X;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSin;
    }
}

