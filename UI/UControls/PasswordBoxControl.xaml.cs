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

namespace ScramblerApp.UI.UControls
{
    /// <summary>
    /// Логика взаимодействия для PasswordBoxControl.xaml
    /// </summary>
    public partial class PasswordBoxControl : UserControl
    {
        public string GetPassword()
        {
            string result;
            if (PswBox.Visibility == Visibility.Visible)
            {
                result = PswBox.Password;
            }
            else
                result = TxtBox.Text;
            return result;
        }
        public PasswordBoxControl()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = PswBox.Password;
            PswBox.Visibility = Visibility.Collapsed;
            TxtBox.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PswBox.Password = TxtBox.Text;
            PswBox.Visibility = Visibility.Visible;
            TxtBox.Visibility = Visibility.Collapsed;
        }
    }
}
