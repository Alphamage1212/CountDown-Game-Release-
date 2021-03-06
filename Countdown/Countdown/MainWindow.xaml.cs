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

namespace Countdown
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ps4click(object sender, RoutedEventArgs e)
        {
            Game.Content = new ps4gamelist();
        }

        private void xboxclick(object sender, RoutedEventArgs e)
        {
            Game.Content = new xboxgamelist();
        }

        private void switchclick(object sender, RoutedEventArgs e)
        {
            Game.Content = new switchgamelist();
        }

        private void pcclick(object sender, RoutedEventArgs e)
        {
            Game.Content = new pcgamelist();
        }
    }
}
