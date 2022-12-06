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
    /// Логика взаимодействия для MenedgerWindow.xaml
    /// </summary>
    public partial class MenedgerWindow : Window
    {
        static public Boolean HelpOpened = false; //Переменная для определения состояния окна справки
        public MenedgerWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод обработки события нажатия на кнопку Закрыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод запускающий заглушку для неназначенных кнопок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEmpty_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "Упс!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Метод обработки события нажатия на кнопку Справка 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            if (!HelpOpened)
            {
                HelpWindow helpWindow = new HelpWindow();
                helpWindow.Show();
                HelpOpened = true;
            }
        }

        /// <summary>
        /// Метод обработки события нажатия на кнопку Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}
