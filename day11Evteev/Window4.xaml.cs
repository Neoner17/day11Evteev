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
    public partial class Window4 : Window
    {

        public Window4()
        {
            InitializeComponent();
        }

        private void ButtonY_Click(object sender, RoutedEventArgs e)
        {
            Window2 otherWindow = new Window2();
            otherWindow.Show();
            this.Close();
        }
        private void ButtonI_Click(object sender, RoutedEventArgs e)
        {
            Window5 otherWindow = new Window5();
            otherWindow.Show();
            this.Close();
        }
    }
}
