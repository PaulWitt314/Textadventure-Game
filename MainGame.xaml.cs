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

namespace Textadventure_Paul_Witt
{
    /// <summary>
    /// Interaktionslogik für MainGame.xaml
    /// </summary>
    public partial class MainGame : Window
    {
        string btn3 = "", btn4 = "";
        public MainGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lebensanzeige Farbe und Tot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HealthChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(HealthPB.Value > 74)
            {
                HealthPB.Foreground = System.Windows.Media.Brushes.Green;
            }
            else if(HealthPB.Value > 24)
            {
                HealthPB.Foreground = System.Windows.Media.Brushes.Yellow;
            }
            else
            {
                HealthPB.Foreground = System.Windows.Media.Brushes.Red;
                if(HealthPB.Value >= 0)
                {
                    Window game = new MainWindow();
                    MessageBox.Show("Du bist Gestorben");
                    this.Close();
                    game.Show();
                }
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Button 4 Schließung des Games,Ausführung,Inventar Gegenstand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(Btn4.Content) == "Schließen")
            {
                this.Close();
            }
        }

        private void InventoryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Buttons in Menü umwandeln
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToString(MenuBtn.Content) == "Menü")
            {
                btn3 = Convert.ToString(Btn3.Content);
                btn4 = Convert.ToString(Btn4.Content);
                Btn1.Visibility = Visibility.Collapsed;
                Btn2.Visibility = Visibility.Collapsed; 
                InventoryBtn.Visibility = Visibility.Collapsed;
                Btn3.Content = "Speichern";
                Btn4.Content = "Schließen";
                MenuBtn.Content = "Zurück";
            }
            else if(Convert.ToString(MenuBtn.Content) == "Zurück")
            {
                Btn1.Visibility = Visibility.Visible;
                Btn2.Visibility = Visibility.Visible;
                InventoryBtn.Visibility = Visibility.Visible;
                Btn3.Content = btn3;
                Btn4.Content = btn4;
                MenuBtn.Content = "Menü";
            }
        }
    }
}
