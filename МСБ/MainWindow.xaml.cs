using System.Windows;


namespace МСБ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            Window3 update = new Window3();
            update.ShowDialog();
            Close();
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*Window1 update = new Window1();
            update.ShowDialog();*/
            // MessageBox.Show("Временно не работает");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lk-ofd.taxcom.ru");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sbi.sberbank.ru:9443/ic/dcb");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pfrf.ru/");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nalog.ru/");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fss.ru/");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.fss.ru/");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://educenter.taxcom.ru/lk");
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wildberries.ru/");
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com/");
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://service.nalog.ru/nbo/");
            System.Windows.Application.Current.Shutdown();
        }
    }
}
