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

namespace WpfApp8
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int number = 0;
            bool check = int.TryParse(tb_1.Text, out number);
            if (check == true)
            {
                int i = Convert.ToInt32(tb_1.Text);
                if (rb1.IsChecked == true)
                {
                    tb_2.Text = Convert.ToString(i, 2);
                }
                else if (rb2.IsChecked == true)
                {
                    tb_2.Text = Convert.ToString(i, 16);
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
            

        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            int number = 0;
            bool check = int.TryParse(tb_1.Text, out number);
            if (check == true)
            {
                int i = Convert.ToInt32(tb_1.Text);
                tb_2.Text = Convert.ToString(i, 2);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            int number = 0;
            bool check = int.TryParse(tb_1.Text, out number);
            if (check == true)
            {
                int i = Convert.ToInt32(tb_1.Text);
                tb_2.Text = Convert.ToString(i, 16);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}