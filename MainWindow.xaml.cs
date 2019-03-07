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

namespace _184784_Driving__Adult_
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
        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            
            int aAge;
            int.TryParse(txtAge.Text, out aAge);
            string output = "";
        
            if (aAge >= 16)
            {
                output = "You are allowed to drive";
            }
            if (aAge >= 18)
            {
                output +=",vote";
            }
            if (aAge >= 19)
            {
                output += " and drink";
            }
            MessageBox.Show(output);
        }
    }
}
