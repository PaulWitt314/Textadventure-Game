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

namespace Textadventure_Paul_Witt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitGameBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            Window Game = new MainGame();
            this.Close();
            Game.Show();
        }
    }
}
