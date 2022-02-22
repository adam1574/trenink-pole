using System;
using System.Collections.Generic;
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

namespace trenink_pole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] pole = new int[100];

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerujPole(pole, -999,1000);
            TxtBox.Text = string.Join("; ",pole) ;
        }


        private void GenerujPole(int[] array, int min, int max)
        {
            Random random = new Random();
            for(int i = 0; i < pole.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
        }


        private int[] GenerujPole(int count, int min, int max)
        {
            int[] array = new int[count];

            Random random = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }


        private int soucetprvkuvpoli(int[] array)
        {
            int soucet = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soucet = soucet + array[i];
            }
        }
    }
}
