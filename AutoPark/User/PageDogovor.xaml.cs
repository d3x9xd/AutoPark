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

namespace AutoPark.User
{
    /// <summary>
    /// Логика взаимодействия для PageDogovor.xaml
    /// </summary>
    public partial class PageDogovor : Page
    {
        public PageDogovor()
        {
            InitializeComponent();
        }

        private void createdog_Click(object sender, RoutedEventArgs e)
        {

            if (ODBConnectionHelper.entObj.Dogovor.Count(x => x.FIO == FIO.Text && x.Age == Age.Text && x.DriverLicense == DriverLicense.Text
            && x.Passport == Passport.Text && x.Phone == Phone.Text && x.DateVidachi == DateVidachi.Text && x.DateVozvrat == DateVozvrat.Text && x.Count == Count.Text && x.Zalog == Zalog.Text) < 1)
            {

                DataBase.Dogovor dogovor = new DataBase.Dogovor
                {
                    FIO = FIO.Text,
                    Age = Age.Text,
                    DriverLicense = DriverLicense.Text,
                    Passport = Passport.Text,
                    Phone = Phone.Text,
                    DateVidachi = DateVidachi.Text,
                    DateVozvrat = DateVozvrat.Text,
                    Count = Count.Text,
                    Zalog = Zalog.Text
                };
                ODBConnectionHelper.entObj.Dogovor.Add(dogovor);
                ODBConnectionHelper.entObj.SaveChanges();
                FrameApp.frmObj.GoBack();
                MessageBox.Show("Договор отправлен на проверку");
            }
        
            else
            {
                MessageBox.Show("Такой договор уже есть");
            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
