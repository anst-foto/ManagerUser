using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Autorization
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void HyperSignIn_OnClick(object sender, RoutedEventArgs e)
        {
            var auth = new MainWindow();
            auth.Show();
            
            Close();
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CheckEmpty()
        {
            var loginIsEmpty = InputLogin.Text != string.Empty;
            var password_1_IsEmpty = InputPassword1.Password != string.Empty;
            var password_2_IsEmpty = InputPassword2.Password != string.Empty;
            var emailIsEmpty = InputEmail.Text != string.Empty;
            
            if (loginIsEmpty && password_1_IsEmpty && password_2_IsEmpty && emailIsEmpty && InputPassword1.Password == InputPassword2.Password)
            {
                ButtonRegistration.IsEnabled = true;
            }
            else
            {
                ButtonRegistration.IsEnabled = false;
            }
        }

        private void InputLogin_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckEmpty();
        }

        private void InputPassword1_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckEmpty();
        }

        private void InputPassword2_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckEmpty();
        }

        private void InputEmail_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckEmpty();
        }
    }
}