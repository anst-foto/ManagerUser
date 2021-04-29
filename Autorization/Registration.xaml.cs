using System.Windows;
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
    }
}