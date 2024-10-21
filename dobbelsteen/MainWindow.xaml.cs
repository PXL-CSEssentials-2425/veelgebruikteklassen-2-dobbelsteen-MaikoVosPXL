using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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


namespace dobbelsteen
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
        private void sluitenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void opnieuwButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Clear();
            startButton.Focus();
        }
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Clear();

            Random rnd = new Random();
            int dobbelsteenNumber = 0;

            if (dobbelsteenNumber != 6)
            {
                for (int i = 1;dobbelsteenNumber < 6; i++)
                {
                    dobbelsteenNumber = rnd.Next(1, 7);
                    outputTextBox.Text += $"Worp {i} geeft {dobbelsteenNumber}\n" +
                    $"";
                }
            }
           
        }   
    }
}
