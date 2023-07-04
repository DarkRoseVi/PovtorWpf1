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
using VolonterWpf.Pages;
using VolonterWpf.Models;

namespace VolonterWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void VxodBtn_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordTb.Text.Trim();
            string login = LoginTb.Text.Trim();
            if(login.Length>0 && password.Length > 0) 
            {
                var user = App.db.User.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null && user.RoleId == 2)
                {
                    App.AutoUser = user;
                    NavigationService.Navigate(new RequestPage());
                }
                else MessageBox.Show("no");
            }
        }
    }
}
