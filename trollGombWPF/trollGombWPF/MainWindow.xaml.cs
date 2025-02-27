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
        private List<Button> buttons;
        private Button[,] buttonMatrix;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            buttonMatrix = new Button[3, 3]
{
        { button1, button2, button3 },
        { button4, button5, button6 },
        { button7, button8, button9 }
};

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


            if (EllenorizGyoztest())
            {
                MessageBox.Show($"{b.Content} nyert!");
            }


        }

        private void resetGomb_Click(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                button.Content = "";
                
            }

            miVoltElobb = "O"; // Visszaállítjuk az első játékos karakterét, ha szükséges
        }
        private bool EllenorizGyoztest()
        {
            // Ellenőrizzük a sorokat
            for (int i = 0; i < 3; i++)
            {
                if (buttonMatrix[i, 0].Content != "" && buttonMatrix[i, 0].Content == buttonMatrix[i, 1].Content && buttonMatrix[i, 1].Content == buttonMatrix[i, 2].Content)
                {
                    return true; // Van győztes
                }
            }

            // Ellenőrizzük az oszlopokat
            for (int j = 0; j < 3; j++)
            {
                if (buttonMatrix[0, j].Content != "" && buttonMatrix[0, j].Content == buttonMatrix[1, j].Content && buttonMatrix[1, j].Content == buttonMatrix[2, j].Content)
                {
                    return true; // Van győztes
                }
            }

            // Ellenőrizzük az átlókat
            if (buttonMatrix[0, 0].Content != "" && buttonMatrix[0, 0].Content == buttonMatrix[1, 1].Content && buttonMatrix[1, 1].Content == buttonMatrix[2, 2].Content)
            {
                return true; // Van győztes
            }

            if (buttonMatrix[0, 2].Content != "" && buttonMatrix[0, 2].Content == buttonMatrix[1, 1].Content && buttonMatrix[1, 1].Content == buttonMatrix[2, 0].Content)
            {
                return true; // Van győztes
            }

            return false; // Nincs győztes
        }

    }
}