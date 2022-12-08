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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassBus;

namespace Varlamov_Lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        Bus _bus1 = new Bus(35, 20, 6);
        Bus _bus2 = new Bus(35, 20, 6);

        private void Make1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(lenghtBus.Text, out int lenght) & int.TryParse(capacityBus.Text, out int capacity) & int.TryParse(countSittingBus.Text, out int count))
            {
                _bus1 = new Bus(lenght, capacity, count);
                bus1.Text = _bus1.ToString();
                drive1.Text = _bus1.Drive(_bus1);
                transportating1.Text = _bus1.Transportating(_bus1);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void Make2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(lenghtBus.Text, out int lenght) & int.TryParse(capacityBus.Text, out int capacity) & int.TryParse(countSittingBus.Text, out int count))
            {
                _bus2 = new Bus(lenght, capacity, count);
                bus2.Text = _bus2.ToString();
                drive2.Text = _bus2.Drive(_bus2);
                transportating2.Text = _bus2.Transportating(_bus2);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void Compare(object sender, RoutedEventArgs e)
        {
            if (_bus1.CompareTo(_bus2) > 0)
                MessageBox.Show("Первый больше");
            else if (_bus1.CompareTo(_bus2) < 0)
                MessageBox.Show("Второй больше");
            else
                MessageBox.Show("Автобусы равны");
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Варламов Артём Александрович. ИСП-34. Задание: создать интерфейсы - автомобиль, пассажирский транспорт." +
                "\r\nСоздать класс автобус. " +
                "\r\nКласс должен включать конструктор, функцию для формирования строки информации об автобусе. " +
                "\r\nСравнение производить по вместимости пассажиров.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
