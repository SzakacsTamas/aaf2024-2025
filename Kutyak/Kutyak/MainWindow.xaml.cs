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
using System.IO;

namespace Kutyak
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

        List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        List<KutyaFajta> kutyaFajtak=new List<KutyaFajta>();
        List<Kutya> kutyak=new List<Kutya>();
        private void loaded_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("KutyaNevek.csv");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(";");
                kutyaNevek.Add(new KutyaNev(Convert.ToInt32(vag[0]), vag[1]));

            }
            sorok = File.ReadAllLines("KutyaFajtak.csv");
            for(int i = 1;i < sorok.Length; i++)
            {
                string[] vag= sorok[i].Split(";");
                kutyaFajtak.Add(new KutyaFajta(Convert.ToInt32(vag[0]), vag[1], vag[2])); 
            }
            sorok = File.ReadAllLines("kutyak.csv");
            for(int i = 1; i < sorok.Length; i++)
            {
                string[] vag=sorok[i].Split(";");
                kutyak.Add(new Kutya(Convert.ToInt32(vag[0]), Convert.ToInt32(vag[1]), Convert.ToInt32(vag[2]), Convert.ToInt32(vag[3]), DateOnly.Parse(vag[4]), kutyaFajtak.Where(x =>x.id == int.Parse(vag[1])).First(), kutyaNevek.Where(x => x.id == int.Parse(vag[2])).First()));
            }
            
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = kutyaNevek.Count;
        }
        private void _6_Click(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok = kutyak.Select(x => x.kor).ToList();
            _6Display.Content = Math.Round(korok.Average(), 2);
        }
        private void _7_Click(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok = kutyak.Select(x => x.kor).ToList();
            int maxKor = korok.Max();
            Kutya idosKutya = kutyak.Where(x => x.kor == maxKor).First();
            _7Display.Content = idosKutya.nev.name + ", " + idosKutya.fajta.nev;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            var azNap = kutyak.Where(x => x.datum == DateOnly.FromDateTime((DateTime)picker.SelectedDate)).GroupBy(x => x.fajta.nev).Select(x => (x.Key, x.Count())).ToList();

            _8ListaDisplay.ItemsSource = azNap.Select(x => x.Key + " " + x.Item2 + " kutya");
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            var adatok = kutyak.GroupBy(x => x.datum).Select(x => (x.Count())).ToList();
            _9Display.Content = kutyak.GroupBy(x => x.datum).Where(x => x.Count() == adatok.Max()).Select(x => x.Key).First().ToShortDateString();
        }
    }
}