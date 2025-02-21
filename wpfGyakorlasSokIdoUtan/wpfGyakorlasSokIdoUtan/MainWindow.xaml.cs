using Microsoft.VisualBasic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfGyakorlasSokIdoUtan
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

             textBlock.Text = Convert.ToString( Convert.ToInt32( textBox.Text )+ Convert.ToInt32( textBox_Copy.Text));
        }
    }
}