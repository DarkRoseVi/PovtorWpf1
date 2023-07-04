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
using VolonterWpf.Models;
using VolonterWpf.Pages;

namespace VolonterWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        public RequestPage()
        {
            InitializeComponent();
            RequestLw.ItemsSource = App.db.ReqiesrUser.Where(x => x.UserId == App.AutoUser.Id).ToList();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as ReqiesrUser;
            var users2 = App.AutoUser;
            var users = App.db.ReqiesrUser.FirstOrDefault(x => x.Id == req.Id && x.UserId == users2.Id);
            users.StatusId = 2;
            App.db.SaveChanges();
        }

        private void OtBtn_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as ReqiesrUser;
            var users2 = App.AutoUser;
            var users = App.db.ReqiesrUser.FirstOrDefault(x => x.Id == req.Id && x.UserId == users2.Id );
            users.StatusId = 3;
            users.User.StatusUserId = 2;
            App.db.SaveChanges();
        }
    }
}
