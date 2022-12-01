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
    /// Логика взаимодействия для HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        
        public HelpWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод обработки события нажатия на кнопку Ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод обработки события закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.HelpOpened = false;
        }
    }
}
