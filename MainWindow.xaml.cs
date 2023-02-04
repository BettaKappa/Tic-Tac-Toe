using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
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
    public partial class MainWindow : Window
    {
        private bool isitx = false;

        public MainWindow()
        {
            InitializeComponent();

            List<Button> bt = new () { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (var button in bt)
            {
                button.IsEnabled = false;
            }

            Start.IsEnabled = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (var button in bt)
            {
                button.Content = "";
                button.IsEnabled = true;
            }

            if (isitx)
            {
                isitx = false;
                // Robo();
            }
            else
            {
                isitx = true;
            }
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }


        private void C1_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void A2_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void B2_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void C2_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void A3_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            //Robo();
        }

        private void C3_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = (isitx) ? "X" : "O";
            // Robo();
        }

        /*private static void Robo(List<Button> bt)
        {
            // После каждого хода игрока составляется/обновляется список кнопок с пустым содержимым и оттуда рандомно выбирается одна, в которой робот и совершает ход.

            List<Button> free = new List<Button> {};

            foreach (var button in bt)             
            {
                if (button.Content == "")
                {
                    free.Add(button);
                }
            }

            Random rnd = new Random();
            int randIndex = rnd.Next(free.Count);
            Button freeButton = free[randIndex];
        }*/
    }
}
