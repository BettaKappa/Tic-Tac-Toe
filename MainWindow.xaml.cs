using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
                Robo(bt);
            }
            else
            {
                isitx = true;
            }
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void C1_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void A2_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void B2_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void C2_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void A3_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void C3_Click_1(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ((Button)sender).Content = (isitx) ? "X" : "O";
            Robo(bt);
        }

        private void Robo(List<Button> bt)
        {
            List<Button> free = new List<Button> {};

            foreach (var button in bt)             
            {
                if (button is { Content: "" })
                {
                    free.Add(button);
                }
            }

            if (free.Count != 0)
            {
                Random rnd = new Random();
                int randIndex = rnd.Next(free.Count);
                Button freeButton = free[randIndex];

                ((Button)freeButton).Content = (isitx) ? "O" : "X";
            }
        }
    }
}
