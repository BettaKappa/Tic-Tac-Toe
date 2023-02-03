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
    public partial class MainWindow : Window
    {
        private bool isitx = false;

        public MainWindow()
        {
            InitializeComponent();

            List<Button> bt = new List<Button>
            {
                A1, A2, A3, B1, B2, B3, C1, C2, C3
            };

            foreach (var button in bt)
            {
                button.IsEnabled = false;
            }

            Start.IsEnabled = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            List<Button> bt = new List<Button>  // опять прописываю то же самое, тк пока туплю с передачей из метода в метод баттонов
            {
                A1, A2, A3, B1, B2, B3, C1, C2, C3
            };

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


            // Тут тоже траблы с передачей bt, потом разберусь (ха-ха)

            List<Button> free = new List<Button>
            {

            };
            // foreach (var button in bt)             
            // {
            //     if (button.Content == "")
            //     {
            //         free.Add(button);
            //     }
            // }
        }


    }
}
