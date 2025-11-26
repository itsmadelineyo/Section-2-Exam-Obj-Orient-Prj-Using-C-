namespace Section2Exam
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
            lblOperand1 = new Label();
            lblOperand2 = new Label();
            lblMessage = new Label();
            txtOperand1 = new TextBox();
            txtOperand2 = new TextBox();
            btnShowMod = new Button();
            btnShowFact = new Button();
            btnShowFib = new Button();
            btnDoMod = new Button();
            btnDoFact = new Button();
            btnDoFib = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblOperand1
            // 
            lblOperand1.BackColor = Color.CornflowerBlue;
            lblOperand1.Location = new Point(132, 136);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(150, 38);
            lblOperand1.TabIndex = 0;
            lblOperand1.Text = "Operand 1:";
            lblOperand1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOperand2
            // 
            lblOperand2.BackColor = Color.CornflowerBlue;
            lblOperand2.Location = new Point(680, 136);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(150, 38);
            lblOperand2.TabIndex = 1;
            lblOperand2.Text = "Operand 2:";
            lblOperand2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.CornflowerBlue;
            lblMessage.Location = new Point(339, 136);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(278, 163);
            lblMessage.TabIndex = 2;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOperand1
            // 
            txtOperand1.BackColor = Color.LightBlue;
            txtOperand1.Location = new Point(132, 199);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(150, 31);
            txtOperand1.TabIndex = 3;
            // 
            // txtOperand2
            // 
            txtOperand2.BackColor = Color.LightBlue;
            txtOperand2.Location = new Point(680, 199);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(150, 31);
            txtOperand2.TabIndex = 4;
            // 
            // btnShowMod
            // 
            btnShowMod.BackColor = Color.PowderBlue;
            btnShowMod.Location = new Point(132, 346);
            btnShowMod.Name = "btnShowMod";
            btnShowMod.Size = new Size(150, 34);
            btnShowMod.TabIndex = 5;
            btnShowMod.Text = "Show Modulus";
            btnShowMod.UseVisualStyleBackColor = false;
            btnShowMod.Click += BtnShowMod_Click;
            // 
            // btnShowFact
            // 
            btnShowFact.BackColor = Color.LightBlue;
            btnShowFact.Location = new Point(403, 346);
            btnShowFact.Name = "btnShowFact";
            btnShowFact.Size = new Size(150, 34);
            btnShowFact.TabIndex = 6;
            btnShowFact.Text = "Show Factorial";
            btnShowFact.UseVisualStyleBackColor = false;
            btnShowFact.Click += BtnShowFact_Click;
            // 
            // btnShowFib
            // 
            btnShowFib.BackColor = Color.LightBlue;
            btnShowFib.Location = new Point(680, 346);
            btnShowFib.Name = "btnShowFib";
            btnShowFib.Size = new Size(150, 34);
            btnShowFib.TabIndex = 7;
            btnShowFib.Text = "Show Fibonacci";
            btnShowFib.UseVisualStyleBackColor = false;
            btnShowFib.Click += BtnShowFib_Click;
            // 
            // btnDoMod
            // 
            btnDoMod.BackColor = Color.LightBlue;
            btnDoMod.Location = new Point(132, 451);
            btnDoMod.Name = "btnDoMod";
            btnDoMod.Size = new Size(150, 34);
            btnDoMod.TabIndex = 8;
            btnDoMod.Text = "&Do Modulus";
            btnDoMod.UseVisualStyleBackColor = false;
            btnDoMod.Click += BtnDoMod_Click;
            // 
            // btnDoFact
            // 
            btnDoFact.BackColor = Color.LightBlue;
            btnDoFact.Location = new Point(403, 451);
            btnDoFact.Name = "btnDoFact";
            btnDoFact.Size = new Size(150, 34);
            btnDoFact.TabIndex = 9;
            btnDoFact.Text = "D&o Factorial";
            btnDoFact.UseVisualStyleBackColor = false;
            btnDoFact.Click += BtnDoFact_Click;
            // 
            // btnDoFib
            // 
            btnDoFib.BackColor = Color.LightBlue;
            btnDoFib.Location = new Point(680, 451);
            btnDoFib.Name = "btnDoFib";
            btnDoFib.Size = new Size(150, 34);
            btnDoFib.TabIndex = 10;
            btnDoFib.Text = "Do &Fibonacci";
            btnDoFib.UseVisualStyleBackColor = false;
            btnDoFib.Click += BtnDoFib_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightBlue;
            btnClear.Location = new Point(285, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightBlue;
            btnExit.Location = new Point(571, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(988, 628);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDoFib);
            Controls.Add(btnDoFact);
            Controls.Add(btnDoMod);
            Controls.Add(btnShowFib);
            Controls.Add(btnShowFact);
            Controls.Add(btnShowMod);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperand1);
            Controls.Add(lblMessage);
            Controls.Add(lblOperand2);
            Controls.Add(lblOperand1);
            Name = "Form1";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperand1;
        private Label lblOperand2;
        private Label lblMessage;
        private TextBox txtOperand1;
        private TextBox txtOperand2;
        private Button btnShowMod;
        private Button btnShowFact;
        private Button btnShowFib;
        private Button btnDoMod;
        private Button btnDoFact;
        private Button btnDoFib;
        private Button btnClear;
        private Button btnExit;
        }
    }
