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
using PovtorWpf1.Models;


namespace PovtorWpf1.Resoures
{
    /// <summary>
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        public RequestPage()
        {
            InitializeComponent();
            RequestLw.ItemsSource = App.db.Request.ToList();
        }

        private void AppointBtn_Click(object sender, RoutedEventArgs e)
        {
            var requestcontext = (sender as Button).DataContext as Request;
          
                List<User> listusers = App.db.User.Where(x => x.RoleId == 2 ).ToList();
                //App.db.User.FirstOrDefault(x => x.RoleId == 2 && x.StatusUserId == 1).Id;
                var voln = listusers.FindAll(x=> x.StatusUserId == 1);
              //  var ints = App.db.User.FirstOrDefault(x => x.RoleId == 2 && x.StatusUserId == 1);
                //foreach (var item in ints)Ы
                //{

                //}
                // рандомно генерация людей
                Random rn = new Random();
                int index = rn.Next(1, 10);

                Random rn2 = new Random();
                var indexusers = rn2.Next(2, 6);

               for (int i = 0; i <= index; i++)
                {
                    if (voln.Count > 0) 
                    {
                    var uservoln = voln[rn2.Next(0, voln.Count)];
                    uservoln.StatusUserId = 2;
                    App.db.SaveChanges();
                    App.db.ReqiesrUser.Add(
                            new ReqiesrUser
                            {
                                User = uservoln,
                                StatusId = 1,
                                Request = requestcontext
                            }) ;
                    //  var users = App.db.Request.Where(x=> x.Date = DateTime.Now).Select()
                        App.db.SaveChanges();
                    listusers = App.db.User.Where(x => x.RoleId == 2).ToList();
                    voln = listusers.FindAll(x => x.StatusUserId == 1);
          //              MessageBox.Show("yes");
                    }
                    //else MessageBox.Show("nin");
             
                }
            MessageBox.Show("Назначен волонтер");
        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
