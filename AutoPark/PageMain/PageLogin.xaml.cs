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
using AutoPark.User;

namespace AutoPark.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = ODBConnectionHelper.entObj.User.FirstOrDefault(
                x => x.Login == TxbLogin.Text && x.Password ==
                PsbPassword.Password && x.FIO == FIO.Text
                ) ;
                if (userObj == null)
                {
                    MessageBox.Show("Такой пользователь не найден.",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                    FrameApp.frmObj.Navigate(new PageRegistration());

                }
                else
                {
                    switch (userObj.Id_Role)
                    {
                        case 2:
                            FrameApp.frmObj.Navigate(new PageChoose());
                            break;

                        case 1:
                            FrameApp.frmObj.Navigate(new PageChoose());
                            break;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения: " +
                ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageRegistration());
        }
    }
}
