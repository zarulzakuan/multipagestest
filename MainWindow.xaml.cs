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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mulipagesTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
 

    public partial class MainWindow : Window
    {

        public static Frame PagesFrame; 
        public MainWindow()
        {
            InitializeComponent();
            // make MainFrame accessible from other classes
            PagesFrame = this.MainFrame;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            PagesFrame.Content = new Menus();
        }


    }
}
