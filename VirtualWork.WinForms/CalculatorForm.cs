using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using LanguageService.Windows.Forms;

namespace VirtualWork.WinForms
{
	public partial class CalculatorForm : Form
	{
		public CalculatorForm()
		{
			InitializeComponent();
			Translator.Translate(this);
		}

		private static Tuple<decimal, decimal> GetOperands(Stack<decimal> numbers)
		{
			return new Tuple<decimal, decimal>(numbers.Pop(), numbers.Pop());
		}

		private void BtnEqual_Click(object sender, EventArgs e)
		{
			tbResult.Text = Calculate(tbResult.Text);
		}

		private static string Calculate(string expression)
		{
			var numbers = new Stack<decimal>();
			var operators = new Stack<char>();

			var currentNumber = new StringBuilder();

			for (int i = 0; i < expression.Length; i++)
			{
				if (Char.IsDigit(expression[i]) || expression[i] == '.')
				{
					currentNumber.Append(expression[i]);
				}
				else
				{
					if (currentNumber.Length > 0)
					{
						var number = Decimal.Parse(currentNumber.ToString());
						numbers.Push(number);
						currentNumber = new StringBuilder();
					}

					operators.Push(expression[i]);
				}
			}

			if (currentNumber.Length > 0)
			{
				var number = Decimal.Parse(currentNumber.ToString());
				numbers.Push(number);
				currentNumber = new StringBuilder();
			}
			while (operators.Count > 0)
			{
				var operands = GetOperands(numbers);
				var op = operators.Pop();
				switch (op)
				{
					case '+':
						numbers.Push(operands.Item1 + operands.Item2);
						break;
					case '-':
						numbers.Push(operands.Item1 - operands.Item2);
						break;
					case '*':
						numbers.Push(operands.Item1 * operands.Item2);
						break;
					case '/':
						numbers.Push(operands.Item1 / operands.Item2);
						break;
					case '%':
						numbers.Push(operands.Item1 % operands.Item2);
						break;
					case '^':
						numbers.Push((long)operands.Item1 ^ (long)operands.Item2);
						break;
				}
			}

			if (numbers.Count > 0)
			{
				return numbers.Pop().ToString();
			}

			return "Syntax error";
		}

		private Decimal C(StringBuilder currentNumber)
		{
			if (currentNumber.Length > 0)
			{
				return Decimal.Parse(currentNumber.ToString());
			}

			return Decimal.MinValue;
		}

		private void BtnAppend_Click(object sender, EventArgs e)
		{
			var buttonText = ((Button)sender).Text;
			if (tbResult.Text == "0")
			{
				tbResult.Text = buttonText;
			}
			else
			{
				tbResult.Text += buttonText;
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
