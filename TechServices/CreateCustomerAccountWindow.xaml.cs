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

namespace TechServices
{
    /// <summary>
    /// Interaction logic for CreateCustomerAccountWindow.xaml
    /// </summary>
    public partial class CreateCustomerAccountWindow : Window
    {
        public CreateCustomerAccountWindow()
        {
            InitializeComponent();
        }

        private void ShowPassword_Changed(object sender, RoutedEventArgs e)
        {
            if (chkShowPassword.IsChecked == true)
            {
                PasswordInputVisible.Text = PasswordInput.Password;
                PasswordInputVisible.Visibility = Visibility.Visible;
                PasswordInput.Visibility = Visibility.Collapsed;
            }
            else
            {
                PasswordInput.Password = PasswordInputVisible.Text;
                PasswordInput.Visibility = Visibility.Visible;
                PasswordInputVisible.Visibility = Visibility.Collapsed;
            }
        }

        private void ShowConfirmPassword_Changed(object sender, RoutedEventArgs e)
        {
            if (chkShowConfirmPassword.IsChecked == true)
            {
                ConfirmPasswordInputVisible.Text = ConfirmPassword.Password;
                ConfirmPasswordInputVisible.Visibility = Visibility.Visible;
                ConfirmPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                ConfirmPassword.Password = ConfirmPasswordInputVisible.Text;
                ConfirmPassword.Visibility = Visibility.Visible;
                ConfirmPasswordInputVisible.Visibility = Visibility.Collapsed;
            }
        }
        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            ErrorText.Visibility = Visibility.Collapsed;
            if (string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل اسم المستخدم");
                return;
            }

            if (string.IsNullOrWhiteSpace(Phone.Text))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل رقم الهاتف");
                return;
            }

            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل البريد الالكتروني");
                return;
            }

            if (string.IsNullOrWhiteSpace(Address.Text))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل العنوان");
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordInput.Password))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل كلمة السر");
                return;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPassword.Password))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("أدخل كلمة المرور مرة اخرى");
                return;
            }
            if (PasswordInput.Password != ConfirmPassword.Password)
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text = ("كلمة المرور وتأكيدها غير متطابقين");
                return;
            }

           if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();

        }
    }
}

