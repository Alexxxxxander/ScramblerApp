using EncrypApp;
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
using System.Windows.Shapes;

namespace ScramblerApp.UI
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Логин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

                if (TxtBoxLogin.Text == "Админ" && PsswrdBoxPassword.GetPassword() == "Админ")
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    TxtBlockError.Text = "Неверно введен логин или пароль";
                }

            if (TxtBoxLogin.Text == "Менеджер" && PsswrdBoxPassword.GetPassword() == "Менеджер")
            {
                MenedgerWindow menedgerWindow = new MenedgerWindow();
                menedgerWindow.Show();
                this.Close();
            }
            else
            {
                TxtBlockError.Text = "Неверно введен логин или пароль";
            }
        }
    }
}
