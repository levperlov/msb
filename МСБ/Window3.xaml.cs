using Microsoft.Office.Interop.Excel;
using System;
using System.Windows;

namespace МСБ
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : System.Windows.Window
    {
        private Microsoft.Office.Interop.Excel.Application application;
        private Workbook workBook;
        private Worksheet worksheet;
        private readonly exel exel = new exel();
        private bool flag;
        private int i = 0;
        private string a;
        private string b;
        private bool fla;
        private string c;
        private string d;
        private bool fl = false;

        public Window3()
        {
            InitializeComponent();
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            application = new Microsoft.Office.Interop.Excel.Application
            {
                DisplayAlerts = false
            };
            const string template = "template.xlsm";
            workBook = application.Workbooks.Open(System.IO.Path.Combine(Environment.CurrentDirectory, template));
            worksheet = workBook.ActiveSheet as Worksheet;
            exel.writeme(worksheet);
            exel.metod(worksheet);

            application.Visible = true;

            MessageBox.Show("Продолжить работу");


        }




        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            text.Visibility = Visibility.Visible;

            label.Content = exel.Work(sender, 1);

            text.Text = "Введите ID";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            text.Visibility = Visibility.Visible;

            label.Content = exel.Work();

            text.Text = "Введите ID";

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            text.Visibility = Visibility.Visible;
            flag = true;
            text.Text = "ID";

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                if (i == 0)
                {
                    a = text.Text;

                    text.Text = "ФИО";


                }
                if (i == 1)
                {

                    b = text.Text;

                    text.Text = "Заработная плата";


                }
                if (i == 2)
                {
                    c = text.Text;
                    text.Text = "ИНН";


                }
                if (i == 3)
                {
                    d = text.Text;
                    exel.ins(a, b, c, d);
                    text.Text = "";

                    i = -1;
                    flag = false;
                    button.Visibility = Visibility.Hidden;
                    label.Visibility = Visibility.Hidden;
                    text.Visibility = Visibility.Hidden;
                }
                i++;
            }
            else if (fl)
            {
                b = text.Text;
                fla = true;
                fl = false;
            }
            else if (fla)
            {
                fla = false;
                exel.update(a, b);
            }
            else if (exel.Dellite(text.Text))
            {
                a = text.Text;
                text.Text = "Значение";
                fl = true;
            }

            else
            {




                button.Visibility = Visibility.Hidden;
                label.Visibility = Visibility.Hidden;
                text.Visibility = Visibility.Hidden;
            }
        }
    }
}
