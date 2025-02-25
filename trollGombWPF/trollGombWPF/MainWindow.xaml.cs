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

namespace trollGombWPF
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

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Random szam= new Random();
            int rInt = szam.Next(0, Convert.ToInt32(Width)-(int)button.Width);
            int lInt = szam.Next(0, Convert.ToInt32(Height) - (int)button.Height);
            button.Margin = new Thickness(rInt, lInt, 0, 0);
        }
        string miVoltElobb = "O";
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button b= (Button)sender;
            if (b.Content == "") 
            {
                if (miVoltElobb == "O")
                {
                    b.Foreground = Brushes.Red;
                    b.Content = "X";
                    miVoltElobb = "X";
                }
                else
                {
                    b.Foreground = Brushes.Blue;
                    b.Content = "O";
                    miVoltElobb = "O";
                }
            }

            
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}