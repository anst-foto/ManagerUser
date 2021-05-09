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

namespace Autorization
{
    /// <summary>
    /// Логика взаимодействия для Restore.xaml
    /// </summary>
    public partial class Restore : Window
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClear_Click_1(object sender, RoutedEventArgs e)
        {
            InputEmail.Clear();

            LabelShow.Text = string.Empty;
            ButtonRestore.IsEnabled = false;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            var auth = new MainWindow();
            auth.Show();

            Close();
        }

        private void HyperSignIn_Click(object sender, RoutedEventArgs e)
        {
            var auth = new MainWindow();
            auth.Show();

            Close();
        }
        private void CheckEmpty()
        {
           
          
            var emailIsEmpty =  string.Empty;

            if (emailIsEmpty != InputEmail.Text)
            {
                ButtonRestore.IsEnabled = true;
            }
            else
            {
                ButtonRestore.IsEnabled = false;
            }
        }

        private void InputEmail_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckEmpty();
        }

        private void InputEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonRestore.IsEnabled = true;
        }

        private void ButtonRestore_Click(object sender, RoutedEventArgs e)
        {
            LabelShow.Text = "На вашу почту была отправлена ссылка для \n восстановления пароля";
        }
    }
}
