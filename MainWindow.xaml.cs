using System.Windows;

namespace WPFEvosFront
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("+998 94 946 22 20");
        }

        private void SignInBtn(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }
        private void SignUpBtn(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
        }
        private void AboutWeBtn(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 3;
        }
        private void BackBoshSahifa(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
        }
        private void SignQaytishBtn(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
        }
    }
}
