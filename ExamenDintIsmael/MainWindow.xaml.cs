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

namespace ExamenDintIsmael
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock texto = (TextBlock)sender;

            texto.FontWeight = FontWeights.Bold;

        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock texto = (TextBlock)sender;

            texto.FontWeight = FontWeights.Normal;
        }



        public BitmapImage GetImage() {
            return new BitmapImage(
                new Uri(System.IO.Path.Combine(
                    Environment.CurrentDirectory, "../../assets/star.png"
                    )));
        }


       

        private void añadirEstrellaButton_Click(object sender, RoutedEventArgs e)
        {
            Image imagenEstrella = new Image();

            imagenEstrella.Source = GetImage();
            imagenEstrella.Width = 83;


            contenedorEstrellasWrapPanel.Children.Add(imagenEstrella);
            

            



        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;


            string textoTag = texto.Tag.ToString();
            if (e.Key == Key.F1)
            {
                

                texto.Text = textoTag;
            }

            


        }
    }
}
