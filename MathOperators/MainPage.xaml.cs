using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathOperators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
            }

            catch 
            {
                expression.Text = $"{ leftOperand.Text} + { rightOperand.Text}";
                result.Text = "Invalid Input";

            }
        }
            private void addValues()
            {
                int leftValue = int.Parse(leftOperand.Text);
                int rightValue = int.Parse(rightOperand.Text);
                int outcome = 0;
               
                outcome = leftValue + rightValue;
                expression.Text = $"{leftOperand.Text} + {rightOperand.Text}";
                result.Text = outcome.ToString();
            }

            private void subtractValues()
            {
                int leftValue = int.Parse(leftOperand.Text);
                int rightValue = int.Parse(rightOperand.Text);
                int outcome = 0;
                outcome = leftValue - rightValue;
                expression.Text = $"{leftOperand.Text} - {rightOperand.Text}";
                result.Text = outcome.ToString();
            }

            private void multiplyValues()
            {
                int leftValue = int.Parse(leftOperand.Text);
                int rightValue = int.Parse(rightOperand.Text);
                int outcome = 0;
                outcome = leftValue * rightValue;
                expression.Text = $"{leftOperand.Text} * {rightOperand.Text}";
                result.Text = outcome.ToString();
            }

            private void divideValues()
            {
                int leftValue = int.Parse(leftOperand.Text);
                int rightValue = int.Parse(rightOperand.Text);
                int outcome = 0;
                outcome = leftValue / rightValue;
                expression.Text = $"{leftOperand.Text} / {rightOperand.Text}";
                result.Text = outcome.ToString();
            }

            private void remainderValues()
            {
                int leftValue = int.Parse(leftOperand.Text);
                int rightValue = int.Parse(rightOperand.Text);
                int outcome = 0;
                outcome = leftValue % rightValue;
                expression.Text = $"{leftOperand.Text} % {rightOperand.Text}";
                result.Text = outcome.ToString();
            }

    }
}
