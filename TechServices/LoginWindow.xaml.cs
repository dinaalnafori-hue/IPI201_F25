using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TechServices
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            ErrorText.Visibility = Visibility.Collapsed;
            if (string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text=("أدخل اسم المستخدم");
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordInput.Password))
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text=("أدخل كلمة السر");
                return;
            }

            if (RoleBox.SelectedItem == null)
            {
                ErrorText.Visibility = Visibility.Visible;
                ErrorText.Text=("اختر نوع الحساب");
                return;
            }

            ComboBoxItem? selectedRole = RoleBox.SelectedItem as ComboBoxItem;

            if (selectedRole == null)
            {
                MessageBox.Show("اختر نوع الحساب");
                return;
            }

            string role = selectedRole.Tag?.ToString() ?? "";

            switch (role)
            {
                case "Admin":
                    new AdminWindow().Show();
                    break;

                case "Employee":
                    new EmployeeWindow().Show();
                    break;

                case "Technician":
                    new TechnicianWindow().Show();
                    break;

                case "Customer":
                    new CustomerWindow().Show();
                    break;
            }

            this.Close();
        }
        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomerAccountWindow registerWindow = new CreateCustomerAccountWindow();
            registerWindow.Owner = this;
            registerWindow.Show();
            this.Hide();
        }
    }

        
    }
