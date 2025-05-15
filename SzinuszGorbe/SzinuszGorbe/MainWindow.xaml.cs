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
using System.Windows.Threading;

namespace SzinuszGorbe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //1.kordinata rendszer
    //2.kör(vekony)
    //3.fekete pont
    //4.sugar
    //5.magassag(piros)
    //6.szinusz görbe
    //7.korív(nagy)
    //8.körív(kicsi)
    //9.adattábla(szög egyebek)
    //sine curve and the unit circle
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int x = 0;
        bool novekszik= true;
        void rajzol(object sender, EventArgs e)
        {

            origoX = r * 1.1;
            origoY = Height / 2;
            canvas.Children.Clear();
            kordinataRajzol();


            kor(x);
            sugar(x);

            pirosVonal(x);
            pont(x);
            if (novekszik)
            {
                x += 1;
            }
            else
            {
                x = -1;
            }
            if (x >= 360)
            {
                novekszik=false;
            }
            if(x <= 0)
            {
                novekszik=true;
            }
            
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzol;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();




        }
        int r = 100;
        double origoY = 0;
        double origoX = 0;
        void kordinataRajzol()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = Height / 2;
            xTengely.X2 = Width;
            xTengely.Y2 = Height / 2;



            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = r * 1.1;
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;


            canvas.Children.Add(xTengely);
            canvas.Children.Add(yTengely);

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i * 90 + yTengely.X1;
                vonalka.Y1 = Height / 2 - 5;
                vonalka.X2 = i * 90 + yTengely.X1;
                vonalka.Y2 = Height / 2 + 5;
                canvas.Children.Add(vonalka);
            }

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = yTengely.X1 - 5;
                vonalka.Y1 = i * 90 + (xTengely.Y1 - 180);
                vonalka.X2 = yTengely.X1 + 5;
                vonalka.Y2 = i * 90 + (xTengely.Y1 - 180);
                canvas.Children.Add(vonalka);
            }
        }
        int korX = 0;
        int korY = 0;
        void kor(int x)
        {
            int dX = (int)(Math.Cos(x / 180.0 * Math.PI) * r);
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.Height = 2 * r;
            kor.Width = 2 * r;
            kor.Margin = new Thickness(origoX + x - dX - r, origoY - r, 0, 0);

            korX = Convert.ToInt32(x - r + origoX);
            korY = Convert.ToInt32(origoY);
            canvas.Children.Add(kor);
        }

        void sugar(int x)
        {
            int dX = (int)(Math.Cos(x / 180.0 * Math.PI) * r);
            int magassag = (int)(Math.Sin(x / 180.0 * Math.PI) * r);

            Line sugar = new Line();
            sugar.Stroke = Brushes.Black;
            sugar.StrokeThickness = 3;
            sugar.X1 = origoX + x - dX;
            sugar.Y1 = origoY;
            sugar.X2 = x + origoX;
            //sugar.Y2 = origoY-Math.Sin(x / 180.0 * Math.PI) * r;
            sugar.Y2 = origoY - magassag;
            canvas.Children.Add(sugar);
        }

        void pont(int x)
        {
            Ellipse pont = new Ellipse();
            pont.Stroke = Brushes.Black;
            pont.Height = r * .1;
            pont.Width = r * .1;
            pont.Margin = new Thickness(origoX - pont.Width / 2 + x, origoY - pont.Height / 2, 0, 0);
            pont.Fill = Brushes.Black;

            canvas.Children.Add(pont);
        }

        void pirosVonal(int x)
        {
            int magassag = (int)(Math.Sin(x / 180.0 * Math.PI) * r);

            Line vonal = new Line();
            vonal.Stroke = Brushes.Red;
            vonal.StrokeThickness = 3;
            vonal.X1 = x + origoX;
            vonal.Y1 = origoY;
            vonal.X2 = x + origoX;
            vonal.Y2 = origoY - magassag;

            canvas.Children.Add(vonal);
        }
    }
}