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
    }
}