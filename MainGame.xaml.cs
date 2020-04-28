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
        /// <summary>
        /// Buttons ins Menü umwandeln
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
