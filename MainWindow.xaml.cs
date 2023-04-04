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
using WPF_hashCheck.ControlHandler;

namespace WPF_hashCheck
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
        /*
        <summary>
            This is the check hash button handler.
            It triggers the downloaded file hash computing and comparison with the expected one.
        </summary>
        <param name="sender">button</param>
        <param name="e">click event</param>
        */
        private void ButtonCheckSHA_Click(object sender, RoutedEventArgs e)
        {
            if(! (string.IsNullOrWhiteSpace(filePath.Text) 
                && string.IsNullOrWhiteSpace(expectedHash.Text)))
            {
                ValueTuple<string, string> result = CheckSHA.Check(filePath.Text, expectedHash.Text);
                computedHash.Text = result.Item1;
                checkResult.Text = result.Item2;
            }
        }
    }
}
