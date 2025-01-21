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

using System.Security.Cryptography.X509Certificates;

namespace _522_Sokolov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double Sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }

        public string Funk(double x, double b, int i)
        {
            string ans;
            if (i == 1)
            {
                if (1 < x * b && x * b < 10)
                {
                    ans = Convert.ToString(Math.Pow(Math.E, Sh(x)));
                }
                else if (12 <  x * b && x * b < 40)
                {
                    ans = Convert.ToString(Math.Sqrt(Math.Abs(Sh(x) + 4 * b)));
                }
                else
                {
                    ans = Convert.ToString(b * Math.Pow(Sh(x), 2));
                }
            }
            else if (i == 2)
            {
                if (1 < x * b && x * b < 10)
                {
                    ans = Convert.ToString(Math.Pow(Math.E, Math.Pow(x, 2)));
                }
                else if (12 < x * b && x * b < 40)
                {
                    ans = Convert.ToString(Math.Sqrt(Math.Abs(Math.Pow(x, 2) + 4 * b)));
                }
                else
                {
                    ans = Convert.ToString(b * Math.Pow(x, 4));
                }
            }
            else
            {
                if (1 < x * b && x * b < 10)
                {
                    ans = Convert.ToString(Math.Pow(Math.E, Math.Pow(Math.E, x)));
                }
                else if (12 < x * b && x * b < 40)
                {
                    ans = Convert.ToString(Math.Sqrt(Math.Abs(Math.Pow(Math.E, x) + 4 * b)));
                }
                else
                {
                    ans = Convert.ToString(b * Math.Pow(Math.Pow(Math.E, x), 2));
                }

            }
            return ans;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            radioButton3.IsChecked = false;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true; 
            }
            if (e.Text == "," && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; 
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && (radioButton1.IsChecked == true || radioButton2.IsChecked == true || radioButton3.IsChecked == true))
            {
                double x = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                if (radioButton1.IsChecked == true)
                {
                    textBox3.Text = Funk(x, b, 1);
                }
                else if (radioButton2.IsChecked == true)
                {
                    textBox3.Text = Funk(x, b, 2);
                }
                else if (radioButton3.IsChecked == true)
                {
                    textBox3.Text = Funk(x, b, 3);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
