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

namespace AutoPark.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ODBConnectionHelper.entObj.User.Count(x => x.Login == TxbLogin.Text && x.FIO == FIO.Text) < 1)
            {
                if (PsbPassword.Password == ansPassword.Password)
                {
                    DataBase.User user = new DataBase.User
                    {   
                        FIO = FIO.Text,
                        Login = TxbLogin.Text,
                        Password = ansPassword.Password,
                        Id_Role = 1
                    };
                    ODBConnectionHelper.entObj.User.Add(user);
                    ODBConnectionHelper.entObj.SaveChanges();
                    FrameApp.frmObj.GoBack();
                    MessageBox.Show("Урааа, вы создали аккаунт");
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
        }

        private void ansPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

            if (PsbPassword.Password == ansPassword.Password)
            {
                btncreate.IsEnabled = true;
                ansPassword.Background = Brushes.LightGreen;
                ansPassword.BorderBrush = Brushes.Green;

            }
            else
            {
                btncreate.IsEnabled = false;
                ansPassword.Background = Brushes.LightCoral;
                ansPassword.BorderBrush = Brushes.Red;

            }
        }
    }
}
