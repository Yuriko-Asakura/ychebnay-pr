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
        elementTableAdapter el = new elementTableAdapter();
        classTableAdapter cl = new classTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ycheb.ItemsSource = charactes.GetData();
            t1.ItemsSource = name.GetData();
            t1.DisplayMemberPath = "Namee_id";
            t2.ItemsSource = el.GetData();
            t2.DisplayMemberPath = "element_id";
            t3.ItemsSource = cl.GetData();
            t3.DisplayMemberPath = "class_id";
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
            object sel = (t1.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(sel.ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            charactes.InsertQuery(Convert.ToInt32(t1.Text), Convert.ToInt32(t1.Text), Convert.ToInt32(t1.Text));// Convert.ToInt32(t2.Text), Convert.ToInt32(t3.Text));
            ycheb.ItemsSource = charactes.GetData();
        }
    }
}
