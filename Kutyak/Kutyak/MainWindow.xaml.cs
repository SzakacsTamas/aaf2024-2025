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
    }
}