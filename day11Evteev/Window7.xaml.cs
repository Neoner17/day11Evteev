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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {

        public Window7()
        {
            InitializeComponent();
        }

        private void ButtonZ_Click(object sender, RoutedEventArgs e)
        {
            Window8 otherWindow = new Window8();
            otherWindow.Show();
            this.Close();
        }
        
    }
}