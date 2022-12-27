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
using AutoPark.PageMain;

namespace AutoPark.User
{
    /// <summary>
    /// Логика взаимодействия для PageChoose.xaml
    /// </summary>
    public partial class PageChoose : Page
    {
        public PageChoose()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditPage_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageArenda());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
