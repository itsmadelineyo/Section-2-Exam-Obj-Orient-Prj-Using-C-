using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Section2Exam
{
    [DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        private string activeOperation = null;

        public Form1()
        {
            InitializeComponent();
            SetInitialState();
        }

        private string DebuggerDisplay => ToString();

        private void SetInitialState()
        {
            btnShowMod.Enabled = true;
            btnShowFact.Enabled = true;
            btnShowFib.Enabled = true;

            btnDoMod.Enabled = false;
            btnDoFact.Enabled = false;
            btnDoFib.Enabled = false;

            txtOperand1.Visible = false;
            txtOperand2.Visible = false;
            lblOperand1.Visible = false;
            lblOperand2.Visible = false;
            activeOperation = null;
        }

        private void BtnShowMod_Click(object sender, EventArgs e)
        {
            activeOperation = "MOD";
            lblOperand1.Text = "Dividend (integer):";
            lblOperand2.Text = "Divisor (integer):";

            lblOperand1.Visible = true;
            txtOperand1.Visible = true;
            txtOperand2.Visible = true;
            lblOperand2.Visible = true;

            AppendMessage("Enter two numbers (non-negative) for Modulus.");

            btnDoMod.Enabled = true;
            btnDoFact.Enabled = false;
            btnDoFib.Enabled = false;
        }

        private void BtnShowFact_Click(object sender, EventArgs e)
        {
            activeOperation = "FACT";
            lblOperand1.Text = "Number (0..15):";
            lblOperand1.Visible = true;
            txtOperand1.Visible = true;

            lblOperand2.Visible = false;
            txtOperand2.Visible = false;

            AppendMessage("Enter a non-negative number between 0 and 15 for Factorial.");

            btnDoFact.Enabled = true;
            btnDoMod.Enabled = false;
            btnDoFib.Enabled = false;
        }

        private void BtnShowFib_Click(object sender, EventArgs e)
        {
            activeOperation = "FIB";
            lblOperand1.Text = "Term (0..45):";
            lblOperand1.Visible = true;
            txtOperand1.Visible = true;

            lblOperand2.Visible = false;
            txtOperand2.Visible = false;

            AppendMessage("Enter a non-negative number between 0 and 45 for Fibonacci.");

            btnDoFib.Enabled = true;
            btnDoMod.Enabled = false;
            btnDoFact.Enabled = false;
        }

        private void BtnDoMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeOperation != "MOD")
                {
                    AppendMessage("Please click 'Show Modulus' first before performing the operation.");
                    return;
                }

                bool anyError = false;
                if (string.IsNullOrWhiteSpace(txtOperand1.Text) || string.IsNullOrWhiteSpace(txtOperand2.Text))
                {
                    AppendMessage("Error: Both numbers are required for Modulus.");
                    anyError = true;
                }

                if (anyError) return;

                if (!TryParseIntegerOnly(txtOperand1.Text.Trim(), out long dividend, out string err1))
                {
                    AppendMessage(err1);
                    return;
                }
                if (!TryParseIntegerOnly(txtOperand2.Text.Trim(), out long divisor, out string err2))
                {
                    AppendMessage(err2);
                    return;
                }

                if (dividend < 0 || divisor <= 0)
                {
                    AppendMessage("Error: For Modulus this app requires non-negative dividend and positive divisor.");
                    return;
                }

                long quotient = 0;
                long rem = dividend;
                while (rem >= divisor)
                {
                    rem -= divisor;
                    quotient++;
                }

                AppendMessage($"{dividend} divided by {divisor} is {quotient} with a remainder of {rem}.");
            }
            catch (FormatException fex)
            {
                AppendMessage($"Format error: {fex.Message}");
            }
            catch (OverflowException ofx)
            {
                AppendMessage($"Overflow error: {ofx.Message}");
            }
            catch (Exception ex)
            {
                AppendMessage($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void BtnDoFact_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeOperation != "FACT")
                {
                    AppendMessage("Please click 'Show Factorial' first before performing the operation.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                {
                    AppendMessage("Error: Operand is required for Factorial.");
                    return;
                }

                if (!TryParseIntegerOnly(txtOperand1.Text.Trim(), out long val, out string err))
                {
                    AppendMessage(err);
                    return;
                }

                if (val < 0)
                {
                    AppendMessage("Error: Factorial cannot be found for negative numbers.");
                    return;
                }
                if (val > 15)
                {
                    AppendMessage("Error: Factorial input out of range. The maximum allowed is 15.");
                    return;
                }

                long f = 1;
                if (val == 0 || val == 1)
                {
                    f = 1;
                }
                else
                {
                    for (long i = 1; i <= val; i++)
                    {
                        f = f * i;
                    }
                }

                AppendMessage($"The answer to {val}! is {f}.");
            }
            catch (OverflowException ofx)
            {
                AppendMessage($"Overflow error: {ofx.Message}");
            }
            catch (Exception ex)
            {
                AppendMessage($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void BtnDoFib_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeOperation != "FIB")
                {
                    AppendMessage("Please click 'Show Fibonacci' first before performing the operation.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                {
                    AppendMessage("Error: Operand is required for Fibonacci.");
                    return;
                }

                if (!TryParseIntegerOnly(txtOperand1.Text.Trim(), out int n, out string err))
                {
                    AppendMessage(err);
                    return;
                }

                if (n < 0)
                {
                    AppendMessage("Error: Fibonacci cannot be calculated for negative numbers.");
                    return;
                }
                if (n > 45)
                {
                    AppendMessage("Error: Fibonacci term out of range. Maximum allowed is 45.");
                    return;
                }

                if (n == 0)
                {
                    AppendMessage("Fibonacci(0) = 0");
                    return;
                }
                if (n == 1)
                {
                    AppendMessage("Fibonacci(1) = 1");
                    return;
                }

                long a = 0;
                long b = 1;
                for (int i = 2; i <= n; i++)
                {
                    long c = a + b;
                    a = b;
                    b = c;
                }

                AppendMessage($"Fibonacci({n}) = {b}");
            }
            catch (OverflowException ofx)
            {
                AppendMessage($"Overflow error: {ofx.Message}");
            }
            catch (Exception ex)
            {
                AppendMessage($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            AppendMessage("Message area cleared. (Operand textboxes were NOT cleared.)");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var msg = "Thank you for using the Operations application. Goodbye!";
            var caption = "Thanks";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private bool TryParseIntegerOnly(string input, out long value, out string errorMessage)
        {
            errorMessage = null;
            value = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "Error: input is empty.";
                return false;
            }

            if (long.TryParse(input, out value))
            {
                return true;
            }

            if (decimal.TryParse(input, out decimal dec))
            {
                errorMessage = "Decimal values are prohibited. Please enter an number value.";
                return false;
            }

            errorMessage = "Input is not valid, please enter numeric integer values only.";
            return false;
        }

        private bool TryParseIntegerOnly(string input, out int value, out string errorMessage)
        {
            errorMessage = null;
            value = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "Error: input is empty.";
                return false;
            }

            if (int.TryParse(input, out value))
            {
                return true;
            }

            if (decimal.TryParse(input, out decimal dec))
            {
                errorMessage = "Decimal values are prohibited. Please enter an integer value.";
                return false;
            }

            errorMessage = "Input is not valid, please enter numeric integer values only.";
            return false;
        }

        private void AppendMessage(string msg)
        {
            if (string.IsNullOrEmpty(lblMessage.Text))
            {
                lblMessage.Text = msg;
            }
            else
            {
                lblMessage.Text = lblMessage.Text + Environment.NewLine + msg;
            }
        }
    }
}
