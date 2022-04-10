using Microsoft.Office.Interop.Excel;

namespace МСБ
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : System.Windows.Window
    {
#pragma warning disable CS0169 // Поле "Window2.application" никогда не используется.
        private readonly Microsoft.Office.Interop.Excel.Application application;
#pragma warning restore CS0169 // Поле "Window2.application" никогда не используется.
#pragma warning disable CS0169 // Поле "Window2.workBook" никогда не используется.
        private readonly Workbook workBook;
#pragma warning restore CS0169 // Поле "Window2.workBook" никогда не используется.
#pragma warning disable CS0169 // Поле "Window2.worksheet" никогда не используется.
        private readonly Worksheet worksheet;
#pragma warning restore CS0169 // Поле "Window2.worksheet" никогда не используется.
        private readonly exel exel = new exel();
        public Window2()
        {

            InitializeComponent();
        }


    }
}
