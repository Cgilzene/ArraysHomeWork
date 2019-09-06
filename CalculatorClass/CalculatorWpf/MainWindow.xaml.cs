using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorClass;

namespace CalculatorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calculations cal = new calculations();
            double val1 = int.Parse(Value1_TxtBox.Text);
            double val2 = int.Parse(Value2_TxtBox.Text);
            double result;



            switch (Functions_Combobx.SelectedIndex)
            {
                case 0:
                    result = cal.Add(val1, val2);
                    MessageBox.Show("The Answer is :" + result);
                    break;
                case 1:
                     result = cal.Subtract(val1, val2);
                    MessageBox.Show("The Answer is :" + result);
                    break;
                case 2:
                     result = cal.Multiply(val1, val2);
                    MessageBox.Show("The Answer is :" + result);
                    break;
                case 3:
                     result = cal.Divide(val1, val2);
                    MessageBox.Show("The Answer is :" + result);
                    break;
               
            }
        }

        private void Value1_TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
