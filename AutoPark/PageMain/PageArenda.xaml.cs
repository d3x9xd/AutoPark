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
using AutoPark.DataBase;
using AutoPark.User;

namespace AutoPark.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageArenda.xaml
    /// </summary>
    public partial class PageArenda : Page
    {
        public PageArenda()
        {
            InitializeComponent();
            MaterialList.ItemsSource = App.db.Cars.Where(x => x.CarBrand.Contains(TxbSearch.Text)).Take(15).ToList();
            ResultTxb.Text = MaterialList.Items.Count + "/" + App.db.Cars.Where(x => x.CarBrand.Contains(TxbSearch.Text)).Count().ToString();
        }

        private void CHX1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Вы уверены в своём выборе?", "Серьезный вопрос", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                MessageBox.Show("Перейдите для заполнения договора");

            }
            else if (dialogResult == MessageBoxResult.No)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageDogovor());
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MaterialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
