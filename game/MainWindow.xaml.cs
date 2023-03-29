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
                new player("1", 0),
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
            
            list1.ItemsSource = players;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
                players.Add(new player(txt1.Text, 0));
                Update();
            
            
        }
    }
}
