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
    public partial class Window15 : Window
    {

        public Window15()
        {
            InitializeComponent();
        }

        private void ButtonH_Click(object sender, RoutedEventArgs e)
        {
            Window16 otherWindow = new Window16();
            otherWindow.Show();
            this.Close();
        }
    }
}