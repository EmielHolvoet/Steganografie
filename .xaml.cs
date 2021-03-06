using Microsoft.Win32;
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
using System.Drawing;


namespace SteganografieIT
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

        private void Select_Photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +   "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +  "Portable Network Graphic (*.png)|*.png";
            
            if (op.ShowDialog() == true)
            {

                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));

                Bitmap CurrentPhoto = new Bitmap(op.FileName);


                System.Drawing.Color pixel = CurrentPhoto.GetPixel(0, 0);

                Red.Content = pixel.R;

            }
        }
    }
}