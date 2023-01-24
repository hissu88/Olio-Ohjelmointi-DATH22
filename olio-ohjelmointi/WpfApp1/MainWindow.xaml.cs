using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

       

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BTN_lMuunnaKilometriksi_Click(object sender, RoutedEventArgs e)
        {
            float maili = int.Parse(txb_1.Text) * 1.621f;
            txt_eka.Text = "mailit kilometreinä on " + maili;
            txb_1.Text = "";

        }

        private void BTN_maili_Click(object sender, RoutedEventArgs e)
        {
            float Km = int.Parse(txb_1.Text) * 0.621f;
            txt_2.Text = "mailit kilometreinä on " + Km;
            txb_1.Text = "";


        }

        private void txb_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
