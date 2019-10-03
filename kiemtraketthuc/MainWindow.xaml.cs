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
using kiemtraketthucmon;

namespace kiemtraketthucmon
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

      
private void BtnMeo_Click(object sender, RoutedEventArgs e)
        {
            meo meo = new meo();
            meo.MauLong = "vang";
            MessageBox.Show(meo.keu());
        }
    

    private void TnCho_Click(object sender, RoutedEventArgs e)
        {
            CHO cho = new CHO();
            cho.MauLong = "den";
            MessageBox.Show(cho.keu());

        }
    }
}