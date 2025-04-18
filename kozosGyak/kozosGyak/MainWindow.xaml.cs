﻿using System.Text;
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
            for (int i = 0; i < oszlop; i++)
            {
                for (int k = 0; k < sor; k++)
                {
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Height = 25;
                    g.Width = 25;

                    g.Margin = new Thickness(i * 25, k * 25, 0, 0);
                    g.Click += kattinats;
                    grid.Children.Add(g);
                }

            }

            this.SizeToContent = SizeToContent.WidthAndHeight;

            aknaLerak();
            aknaMutat();
        }

        int[,] aknaHely;
        Random rand = new Random();
        void aknaLerak()
        {
            aknaHely = new int[sor, oszlop];


            for (int k = 0; k < aknaDB; k++)
            {
                int randomSor = rand.Next(sor);
                int randomOszlop = rand.Next(oszlop);
                if (aknaHely[randomSor, randomOszlop] == 10)
                {
                    k--;
                }
                else
                {
                    aknaHely[randomSor, randomOszlop] = 10;//ezegydarabakna
                }
            }



        }

        void aknaMutat()
        {
            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int j = 0; j < aknaHely.GetLength(1); j++)
                {
                    if (aknaHely[k, j] != 10)
                    {
                        gombok[k, j].Content = aknaHely[k, j];
                    }
                }

            }
        }

        int aknaSzamol(int sor, int oszlop)
        {
            int db = 0;
            if (sor - 1 > 0 && oszlop - 1 > 0 && aknaHely[sor - 1, oszlop - 1] == 10) { db++; }
            if (sor - 1 > 0 && oszlop >= 0 && aknaHely[sor - 1, oszlop] == 10) { db++; }
            if (sor - 1 > 0 && oszlop + 1 > this.oszlop && aknaHely[sor - 1, oszlop + 1] == 10) { db++; }

            if (sor >= 0 && oszlop - 1 > 0 && aknaHely[sor, oszlop - 1] == 10) { db++; }
            if (sor >= 0 && oszlop + 1 > this.oszlop && aknaHely[sor, oszlop + 1] == 10) { db++; }

            if (sor + 1 > 0 && oszlop - 1 > this.oszlop && aknaHely[sor + 1, oszlop - 1] == 10) { db++; }
            if (sor + 1 > 0 && oszlop >= this.oszlop && aknaHely[sor + 1, oszlop] == 10) { db++; }
            if (sor + 1 > 0 && oszlop + 1 > this.oszlop && aknaHely[sor + 1, oszlop + 1] == 10) { db++; }
            return db;
        }
        private void kattinats(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int k = 0; k < gombok.GetLength(1); k++)
                {
                    if (gombok[i, k] == button)
                    {
                        gombok[i, k].Content = aknaHely[i, k];
                        break;
                    }
                }
            }
        }
    }
}