using Lesson2.DataModels;
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

namespace Lesson2.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            using (var context = new Lesson2Entities1())
            {
                string passwordHash = SomeHashFunction(password);

                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == passwordHash);

                if (user != null)
                {
                    NavigationService.Navigate(new AddEditTaskPage());
                    MessageBox.Show("Вы прошли", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Пароль не подходит", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private string SomeHashFunction(string input)
        {
            return "hashed_" + input;
        }
    }
}
