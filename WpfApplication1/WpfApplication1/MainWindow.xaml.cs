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
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        kutuphane veri = new kutuphane("localhost:60", "3306", "root", "", "test");
        public MainWindow()
        {
            InitializeComponent();
            dg1.ItemsSource = "";
            dg1.ItemsSource = veri.tumverilerioku("kutuphane");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            veri.Kaydet(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text);
            dg1.ItemsSource = "";
            dg1.ItemsSource = veri.tumverilerioku("kutuphane");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedIndex == -1) return;

            DataRowView satir = (DataRowView)dg1.SelectedItem;
            veri.VeriSil(Convert.ToInt32(satir[0]));

            dg1.ItemsSource = "";
            dg1.ItemsSource = veri.tumverilerioku("kutuphane");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
             
        }
    }
}
