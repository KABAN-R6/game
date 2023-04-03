using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<player> players;
        List<questions> quuestions;
        string a;
        int v;
        
        public MainWindow()
        {
            InitializeComponent();
            players = new List<player>()
            {
                new player("Костя", 10),
                new player("Данил", 0),
                new player("Валера", 0),

            };
            Update();
            quuestions = new List<questions>()
            {
                new questions("Что такое этикет?","правила поведения", 100),
                new questions("Как переводится с французского языка слово «этикет»?","ярлык", 200),
                new questions("Что значит слово «вежливость»?","быть вежливым", 300),
                new questions("Кто должен пройти первым: входящий в магазин или выходящий в это же время из него?","входящий должен пропустить выходящего", 400),
                new questions("Какие существуют виды этикета?","Деловой, дипломатический, военный, педагогический, врачебный, поведениев общественных местах", 500),

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


            if (tx2.Text == null || tx1.Text == "")
            {
               
            }
            else
            {
                players.Add(new player(tx2.Text, 0));
                Update();
            }
            


        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[0].question;
            a = quuestions[0].answer;
            v = quuestions[0].Point;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b2.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[1].question;
            a = quuestions[1].answer;
            v = quuestions[1].Point;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            b3.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[2].question;
            a = quuestions[2].answer;
            v = quuestions[2].Point;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            b4.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[3].question;
            a = quuestions[3].answer;
            v = quuestions[3].Point;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[4].question;
            a = quuestions[4].answer;
            v = quuestions[4].Point;
        }

        private void vpr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (otv.Text == a)
            {
                if (list2.SelectedItem == null)
                {
                    MessageBox.Show("Выберети пользователя");
                }
                int d = 0;
                int c = v;
                var b = players.FindIndex(u => u == list2.SelectedItem);
                players[b].Point = d+c  ;
                d=d + c;
                Update();


            }
            vpr.Text = "";
            otv.Text = "";
            Update();
        }
    }
}
