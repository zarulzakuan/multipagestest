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

namespace mulipagesTest
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Menus : Page
    {

        public Page Page_2;
        public Page Page_3;
        public Menus()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Page_2 == null)
            {
                Page_2 = new Page2();
                
            }
            MainWindow.PagesFrame.Content = Page_2;
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {

                Page_3 = new Page3();

            
            MainWindow.PagesFrame.Content = Page_3;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Page_2 = null;
        }
    }
}
