using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp2
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
        List<ajoneuvo> ajoneuvot = new List<ajoneuvo>();
        private void txb_1_Click(object sender, RoutedEventArgs e)
        {
         
            ajoneuvo uusiAjoneuvo = new ajoneuvo();
            uusiAjoneuvo.Merkki = input_Malli.Text;
            uusiAjoneuvo.Renkaat = int.Parse(txt_2.Text);
            uusiAjoneuvo.Nopeus = int.Parse(txt_3.Text);


            ajoneuvot.Add(uusiAjoneuvo);

            txt_4.Text = " uusi ajoneuvvo on "+ uusiAjoneuvo;


        }

       
    }
}
