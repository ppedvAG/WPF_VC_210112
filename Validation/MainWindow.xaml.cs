using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Validation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDataErrorInfo
    {
        public MainWindow()
        {
            InitializeComponent();

            Spl_Test.DataContext = this;
        }
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case (nameof(TestText_1)):
                        if (TestText_1 == String.Empty) return "Text1 Darf nicht leer sein";
                        break;
                    case (nameof(TestText_2)):
                        if (TestText_1 == String.Empty) return "Text1 Darf nicht leer sein";
                        if (TestText_2 != TestText_1) return "Text1 und Text2 müssen gleich sein";
                        break;
                    default:
                        break;
                }
                return null;
            }
        }

        public string TestText_1 { get; set; }
        public string TestText_2 { get; set; }

        public string Error => null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this[nameof(TestText_1)] != null) MessageBox.Show(this[nameof(TestText_1)]);
            else if (this[nameof(TestText_2)] != null) MessageBox.Show(this[nameof(TestText_2)]);
            else MessageBox.Show("Alles okay");
        }
    }
}
