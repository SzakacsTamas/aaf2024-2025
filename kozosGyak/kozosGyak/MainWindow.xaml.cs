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

namespace kozosGyak
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
        int sor = 10;
        int oszlop = 10;
        int aknaDB = 10;
        Button[,] gombok;
        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            Button[,] gombok = new Button[sor, oszlop];
            grid.Children.Remove(startGomb);
            for(int i=0; i<oszlop; i++)
            {
                for(int k = 0; k < sor; k++)
                {
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Height = 25;
                    g.Width = 25;
                    
                    g.Margin = new Thickness(i*25,k*25,0,0);
                    g.Click += kattinats;
                    grid.Children.Add(g);
                }

            }

            this.SizeToContent=SizeToContent.WidthAndHeight;
            aknaLerak();
        }
        void aknaLerak()
        {

        }
        private void kattinats(object sender, RoutedEventArgs e)
        {

        }
    }
}