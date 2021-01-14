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
using System.Windows.Shapes;

namespace HelloTwoWindows
{
    /// <summary>
    /// Interaction logic for HelloWindow.xaml
    /// </summary>
    public partial class HelloWindow : Window
    {
        public event Action<int, string> AssignResult;
        public HelloWindow(string name)
        {
            InitializeComponent();
            lblMessage.Content = $"Hello {name}, nice to meet you!";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            /*
            if (AssignResult != null)
            {
                AssignResult.Invoke(age);
            }
            */
            AssignResult?.Invoke(age, txtCity.Text);
            DialogResult = true;           
        }
    }
}
