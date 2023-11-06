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

namespace Lab2_Ivan_WPF
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

        private void btnPrice2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GeneralBook generalBook = new GeneralBook(tbName.Text, int.Parse(tbLength.Text), double.Parse(tbK.Text), tbMat.Text);
                MessageBox.Show("Результат: " + generalBook.GetPrince());   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Помилка! " + ex.Message);  
            }
        }

        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Notebook notebook = new Notebook(tbName.Text, int.Parse(tbLength.Text), double.Parse(tbK.Text));
                MessageBox.Show("Результат: " + notebook.GetPrince());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! " + ex.Message);
            }
        }
    }
}
