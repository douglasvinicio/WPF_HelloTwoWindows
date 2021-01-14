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

namespace SandwichMaker
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

        private void btnMakeSandwich_Click(object sender, RoutedEventArgs e)
        {

            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            ingredientsWindow.Owner = this;

            ingredientsWindow.AssignResult += IngredientsWindow_AssignResult;

            bool? result = ingredientsWindow.ShowDialog();
            
        }

        private void IngredientsWindow_AssignResult(string arg1, string arg2, string arg3)
        {
            lblBread.Content = arg1;
            lblVeggies.Content = arg2;
            lblMeat.Content = arg3;
        }
    }
}
