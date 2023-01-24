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

namespace tehtäviä
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ajoneuvo> ajoneuvot = new List<ajoneuvo>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ajoneuvo uusiajoneuvo = new ajoneuvo();

            uusiajoneuvo.Model = txt_1_input.Text;
            uusiajoneuvo.Tyres = int.Parse(txt_2_input.Text);
            uusiajoneuvo.Speed = int.Parse(txt_3_input.Text);

            txt_1.Text = "";
            txt_2.Text = "";
            txt__3.Text = "";

            txt_auto.Text = "uusi ajoneuvo tiedoilla:" + uusiajoneuvo.Haetiedot();
            ajoneuvot.Add(uusiajoneuvo);

        }
    }
}
