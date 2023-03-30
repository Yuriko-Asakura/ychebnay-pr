﻿using System;
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
using ychebpr1.yc1DataSetTableAdapters;

namespace ychebpr1
{
    /// <summary>
    /// Логика взаимодействия для element.xaml
    /// </summary>
    public partial class element : Window
    {

        elementTableAdapter elements = new elementTableAdapter();
        public element()
        {
            InitializeComponent();
            ycheb.ItemsSource = elements.GetData();
        }
    }
}
