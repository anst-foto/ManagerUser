using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Autorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
        {
            InputLogin.Clear();
            InputPassword.Clear();
            ButtonAuthorization.IsEnabled = false;
            
            LabelShow.Text = string.Empty;
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InputLogin_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckEmptyLoginPassword();
        }

        private void InputPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckEmptyLoginPassword();
        }

        private void CheckEmptyLoginPassword()
        {
            if (InputLogin.Text != string.Empty && InputPassword.Password != string.Empty)
            {
                ButtonAuthorization.IsEnabled = true;
            }
        }

        private void ButtonAuthorization_OnClick(object sender, RoutedEventArgs e)
        {
            var inputLogin = InputLogin.Text;
            var inputPassword = InputPassword.Password;

            var login = "123"; // Временное значение
            var password = "123"; // Временное значение

            if (inputLogin == login && inputPassword == password)
            {
                LabelShow.Foreground = Brushes.Green;
                LabelShow.Text = "Вы успешно авторизовались";
            }
            else
            {
                LabelShow.Foreground = Brushes.DarkRed;
                LabelShow.Text = "Неверный логин или пароль";
            }
        }

        private void HyperSignUp_OnClick(object sender, RoutedEventArgs e)
        {
            var reg = new Registration();
            reg.Show();
            Close();
        }
    }
}