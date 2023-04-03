using System;
using System.Collections;
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

namespace game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<player> players;
        List<questions> quuestions;
        public MainWindow()
        {
            InitializeComponent();
            players= new List<player>()
            {
                new player("1", 10),
                new player("2", 0),
                new player("3", 0),

            };
            Update();
            quuestions = new List<questions>()
            {
                new questions("qfoqfepok[fe[qfe","1", 100),
                

            };
           

        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        public void Update()
        {
            
            players = players.ToList();
            list2.ItemsSource = players;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (tx2.Text == "" || tx2.Text == null)
            {

            }
            players.Add(new player(tx2.Text, 0));
            Update();


        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           b1.Visibility = Visibility.Collapsed;
            vpr.Text = "123123";
           
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b2.Visibility = Visibility.Collapsed;
            vpr.Text = "123123";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            b3.Visibility = Visibility.Collapsed;
            vpr.Text = "123123";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            b4.Visibility = Visibility.Collapsed;
            vpr.Text = "123123";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Collapsed;
            vpr.Text = "123123";
        }

        private void vpr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (otv.Text == "1")
            {
                if (list2.SelectedItem == null)
                {
                    MessageBox.Show("Выберети пользователя");
                }
               
                var b = players.FindIndex(u => u == list2.SelectedItem);
                players[b].Point = 100;

                Update();


            }
            Update();
        }
    }
}
