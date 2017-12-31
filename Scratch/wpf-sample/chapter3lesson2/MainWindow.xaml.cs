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

namespace chapter3lesson2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Forms.OpenFileDialog aDialog = new System.Windows.Forms.OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aDialog.ShowDialog();
            MediaElement1.Source = new Uri(aDialog.FileName);
            MediaElement1.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MediaElement1.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MediaElement1.Pause();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MediaElement1.Stop();
        }

        private void MediaElement1_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Media loading unsuccessful. " + e.ErrorException.Message);
        }
    }
}
