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
    public partial class Window8 : Window
    {

        public Window8()
        {
            InitializeComponent();
        }

        private void ButtonU_Click(object sender, RoutedEventArgs e)
        {
            Window9 otherWindow = new Window9();
            otherWindow.Show();
            this.Close();
        }

        private void ButtonQ_Click(object sender, RoutedEventArgs e)
        {
            Window10 otherWindow = new Window10();
            otherWindow.Show();
            this.Close();
        }

    }
}