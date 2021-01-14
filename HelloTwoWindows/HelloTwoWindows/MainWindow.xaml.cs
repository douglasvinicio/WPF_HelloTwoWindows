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

namespace HelloTwoWindows
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

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            // Open a new window / Instatiate 
            string name = txtName.Text;
            string cityName = "";
            int age = 0;

            HelloWindow helloWindow = new HelloWindow(name);
            
            // Very important - First 
            helloWindow.AssignResult += (a,c) => { age = a; cityName = c; };

            
            bool? result = helloWindow.ShowDialog();

            if (result == true)
            {
                lblResult.Content = $"Age : {age} and city {cityName}";
            }
        }
    }
}
