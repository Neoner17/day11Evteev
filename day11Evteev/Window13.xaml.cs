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
using System.Windows.Shapes;

namespace day11Evteev
{
    /// <summary>
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {

        public Window13()
        {
            InitializeComponent();
        }

        private void ButtonR_Click(object sender, RoutedEventArgs e)
        {
            Window14 otherWindow = new Window14();
            otherWindow.Show();
            this.Close();
        }

        private void ButtonE_Click(object sender, RoutedEventArgs e)
        {
            Window15 otherWindow = new Window15();
            otherWindow.Show();
            this.Close();
        }

    }
}
