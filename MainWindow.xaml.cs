using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isitx = false;

        public MainWindow()
        {
            InitializeComponent();

            Button[] bt = new Button[9];
            bt[0] = A1;
            bt[1] = B1;
            bt[2] = C1;
            bt[3] = A2;
            bt[4] = B2;
            bt[5] = C2;
            bt[6] = A3;
            bt[7] = B3;
            bt[8] = C3;

            foreach (var button in bt)
            {
                button.IsEnabled = false;
            }

            Start.IsEnabled = true;

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Button[] bt = new Button[9];
            bt[0] = A1;
            bt[1] = B1;
            bt[2] = C1;
            bt[3] = A2;
            bt[4] = B2;
            bt[5] = C2;
            bt[6] = A3;
            bt[7] = B3;
            bt[8] = C3;

            foreach (var button in bt)
            {
                button.Content = "";
                button.IsEnabled = true;
            }
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            IsItx();
            Robo();
        }

        private static void IsItx()
        {
            // if (isitx)
            // {
            //     ((Button)sender).Content = "X";
            // }
            // else
            // {
            //     ((Button)sender).Content = "O";
            // }
        }
        private static void Robo()
        {
            // Ещё есть такая идея для "робота":
            // После каждого хода игрока составляется/обновляется список кнопок с пустым содержимым и оттуда рандомно выбирается одна, в которой робот и совершает ход.
            // Я хз как это реализовать, а в тупую миллирад ифов прописывать не хочу.
        }
    }
}
