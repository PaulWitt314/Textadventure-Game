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
        string btn1content, btn2content,btn3content,btn4content,btn5content;
        int Dmg = 10, DmgFireball= 15;
        int SpellNumber = 2,HealthPotion =5;
        int Armor = 4;
        int DmgEnemie, ArmorEnemie;
        public MainGame()
        {
            InitializeComponent();
            FightSystem("Goblin", 5, 4, 100);
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

        private void HealthEnemieChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (HealtEnemiPB.Value > 74)
            {
                HealtEnemiPB.Foreground = System.Windows.Media.Brushes.Green;
            }
            else if (HealtEnemiPB.Value > 24)
            {
                HealtEnemiPB.Foreground = System.Windows.Media.Brushes.Yellow;
            }
            else if(HealtEnemiPB.Value>0)
            {
                HealtEnemiPB.Foreground = System.Windows.Media.Brushes.Red;
            }
            else
            {
                HealtEnemiPB.Maximum = 100;
                HealtEnemiPB.Value =0;
                EnemieNameLBL.Content = "";
                Btn1.Content = btn1content; 
                Btn2.Content = btn2content;
                Btn3.Content = btn3content;
                Btn4.Content = btn4content;
                Btn5.Content = btn5content;
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToString( Btn1.Content) == "Angriff")
            {
                HealtEnemiPB.Value -= Dmg;
                HealthPB.Value -= DmgEnemie;
            }
        }

        public void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(Btn2.Content) == "Feuerball" && SpellNumber>0)
            {
                HealtEnemiPB.Value -= DmgFireball;
                SpellNumber--;
                HealthPB.Value -= DmgEnemie;
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(Btn3.Content) == "Heiltrank" &&HealthPotion>0)
            {
                HealthPB.Value += 15;
                HealthPotion--;
            }
        }

        /// <summary>
        /// Button 4 Schließung des Games,Ausführung,Rennen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(Btn4.Content) == "Schließen")
            {
                this.Close();
            }
            else if (Convert.ToString(Btn4.Content) == "Information")
            {
                
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(Btn5.Content) == "Rennen")
            {
                
            }
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
                btn3content = Convert.ToString(Btn3.Content);
                btn4content = Convert.ToString(Btn4.Content);
                Btn1.Visibility = Visibility.Collapsed;
                Btn2.Visibility = Visibility.Collapsed;  
                Btn5.Visibility = Visibility.Collapsed;
                Btn3.Content = "Speichern";
                Btn4.Content = "Schließen";
                MenuBtn.Content = "Zurück";
            }
            else if(Convert.ToString(MenuBtn.Content) == "Zurück")
            {
                Btn1.Visibility = Visibility.Visible;
                Btn2.Visibility = Visibility.Visible;
                Btn5.Visibility = Visibility.Visible;
                Btn3.Content = btn3content;
                Btn4.Content = btn4content;
                MenuBtn.Content = "Menü";
            }
        }
        /// <summary>
        /// Fight System
        /// </summary>
        /// <param name="HealthEnemie"></param>
        public void FightSystem(string EnemieName, int DmgEnemie1, int ArmorEnemie1, int HealthEnemie)
        {
            btn1content = Convert.ToString(Btn1.Content);
            btn2content = Convert.ToString(Btn2.Content);
            btn3content = Convert.ToString(Btn3.Content);
            btn4content = Convert.ToString(Btn4.Content);
            btn5content = Convert.ToString(Btn5.Content);
            Btn1.Content = "Angriff";
            Btn2.Content = "Feuerball";
            Btn3.Content = "Heiltrank";
            Btn4.Content = "Information";
            Btn5.Content = "Rennen";
            DmgEnemie = DmgEnemie1;
            ArmorEnemie = ArmorEnemie1;
            HealtEnemiPB.Maximum = HealthEnemie;
            HealtEnemiPB.Value = HealthEnemie;
            EnemieNameLBL.Content = EnemieName;
        }
    }
}
