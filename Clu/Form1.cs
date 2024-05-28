using System;
using System.Windows.Forms;

namespace Clu
{
	public partial class frmMain : Form
	{

		double primaryVariable = 0;
		char opFlag = '\0';
		bool dotFlag = false;

		public frmMain()
		{
			InitializeComponent();
		}




		private void NumbersClick(object sender, EventArgs e)
		{
			if (txtScreen.Text == "0")
				txtScreen.Text = ((Button)sender).Text;
			else if (!dotFlag && ((Button)sender).Text.Equals("."))
			{
				txtScreen.Text = txtScreen.Text += ((Button)sender).Text;
				dotFlag = true;
			}
			else if (((Button)sender).Text != ".")
				txtScreen.Text = txtScreen.Text += ((Button)sender).Text;
			btnEqual.Focus();
		}


		private void btnClear_Click(object sender, EventArgs e)
		{
			txtScreen.Text = "0";
		}

		private void OperationClick(object sender, EventArgs e)
		{
			primaryVariable = double.Parse(txtScreen.Text);
			opFlag = Convert.ToChar(((Button)sender).Text);
			txtScreen.Text = "0";
			dotFlag = false;
		}


		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{

				txtScreen.Text = txtScreen.Text.Equals("0") ? e.KeyChar.ToString() : txtScreen.Text + e.KeyChar;
			}
			else
			{
				switch (e.KeyChar)
				{
					case '\b':
						BackSpace_Click(null, null);
						break;
					case '.':
						NumbersClick(btnPoint, null);
						break;
					case '/':
						OperationClick(btnDivide, null);
						break;
					case '*':
						OperationClick(btnMultiple, null);
						break;
					case '-':
						OperationClick(btnSubtract, null);
						break;
					case '+':
						OperationClick(btnPlus, null);
						break;
				}
			}
			btnEqual.Focus();
		}



		private void Result(object sender, EventArgs e)
		{
			double temp = double.Parse(txtScreen.Text);
			switch (opFlag)
			{
				case '+':
					primaryVariable = primaryVariable + temp;
					break;
				case '-':
					primaryVariable = primaryVariable - temp;
					break;
				case '*':
					primaryVariable = primaryVariable * temp;
					break;
				case '/':
					primaryVariable = primaryVariable / temp;
					break;
			}
			if (opFlag != '\0')
				txtScreen.Text = primaryVariable.ToString();

			opFlag = '\0';
		}



		private void BackSpace_Click(object sender, EventArgs e)
		{
			if (txtScreen.Text.EndsWith("."))
				dotFlag = false;
			txtScreen.Text = txtScreen.Text.Length.Equals(1) ? "0" : txtScreen.Text.Remove(txtScreen.Text.Length - 1);
		}


		private void SingleOperational(object sender, EventArgs e)
		{
			double temp = double.Parse(txtScreen.Text);
			switch ((sender as Button).Text)
			{
				case "±":
					txtScreen.Text = (temp * -1).ToString();
					break;
				case "√":
					txtScreen.Text = Math.Sqrt(temp).ToString();
					break;
				case "%":
					txtScreen.Text = (temp / 100).ToString("0.0#");
					break;
				case "1/x":
					txtScreen.Text = (1 / temp).ToString();
					break;
			}
		}

		private void btnCE_Click(object sender, EventArgs e)
		{
			opFlag = '\0';
			dotFlag = false;
			txtScreen.Text = "0";
			primaryVariable = 0;
		}
	}
}
