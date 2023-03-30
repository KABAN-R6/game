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

        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        public void Update()
        {
            players = players.ToList();
            list1.ItemsSource = players;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (tx1.Text == "" || tx1.Text == null)
            {

            }
            players.Add(new player(tx1.Text, 0));
            Update();


        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new 
        }
    }
}
