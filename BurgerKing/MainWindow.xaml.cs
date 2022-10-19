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

namespace BurgerKing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cbcheeseburger_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cbgamburger_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cbcocacola_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CbNagets_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            int x = int.Parse(txbcheese.Text);
            int y = int.Parse(txbgam.Text);
            int z = int.Parse(txbcola.Text);
            int i = int.Parse(txbnag.Text);
            
            lstResult.Items.Add($"Кол-во чизбургеров = {x}");
            lstResult.Items.Add($"Кол-во гамбургеров = {y}");
            lstResult.Items.Add($"Кол-во кока-колы = {z}");
            lstResult.Items.Add($"Кол-во нагетсы = {i}");
            int sum = x * 250 + y * 150 + z * 90 + i * 60;
            lstResult.Items.Add($"Чек: {sum} руб.");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbcheese.Clear();
            txbgam.Clear();
            txbcola.Clear();
            txbnag.Clear();
            lstResult.Items.Clear();

        }
    }
}
