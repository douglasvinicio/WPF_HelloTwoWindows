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

namespace SandwichMaker
{    
    public partial class IngredientsWindow : Window
    {
        public event Action<string, string, string> AssignResult;
        public IngredientsWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string breadType = cmbBread.Text;
            string meat = "";

            List<string> selectedVeggies = new List<string>();
            if (chboxCucumber.IsChecked == true)
            {
                selectedVeggies.Add("Cucumber");
            }
            if (chboxLettuce.IsChecked == true)
            {
                selectedVeggies.Add("Lettuce");
            }
            if (chboxTomato.IsChecked == true)
            {
                selectedVeggies.Add("Tomatos");
            }

            if (rbtnChicken.IsChecked == true)
            {
                meat = "Chicken";
            }
            else if (rbtnTurkey.IsChecked == true)
            {
                meat = "Turkey";
            }
            else if (rbtnCow.IsChecked == true)
            {
                meat = "Cow";
            }
            

            AssignResult?.Invoke(breadType, string.Join("," , selectedVeggies), meat);
            DialogResult = true;

        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

