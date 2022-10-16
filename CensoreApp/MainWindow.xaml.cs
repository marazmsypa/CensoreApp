using CensoreLibrary;
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

namespace CensoreApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CensoreString obj = new CensoreString();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CensoreButton_Click(object sender, RoutedEventArgs e)
        {
            CensoredString.Text = obj.CensoreWithEntry(TextString.Text, TextStringToCensore.Text);
        }
    }
}
