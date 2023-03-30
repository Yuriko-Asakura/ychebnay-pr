using System;
using System.Collections.Generic;
using System.Data;
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
using ychebpr1.yc1DataSetTableAdapters;
namespace ychebpr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharactesTableAdapter charactes = new CharactesTableAdapter();
        NameeTableAdapter name = new NameeTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ycheb.ItemsSource = charactes.GetData();
            Combo.ItemsSource = name.GetData();
            Combo.DisplayMemberPath = "namee";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Charactes charactes = new Charactes();
            charactes.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            classs classs = new classs();
            classs.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            element element = new element();
            element.Show();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object sel = (Combo.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(sel.ToString());
        }
    }
}
