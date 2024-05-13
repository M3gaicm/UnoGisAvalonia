using Avalonia.Controls;
using AppMapa2.Views;

namespace AppMapa2.Views
{
    public partial class ButtonPageView : UserControl
    {
        public ButtonPageView()
        {
            InitializeComponent();
        }

        private void AbrirPestaņa(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new InsertarEntidad();
            nuevaVentana.Show();
        }

        private void AbrirPestaņa2(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new RotarEntidad();
            nuevaVentana.Show();
        }
        private void AbrirPestaņa3(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new MoverEntidad();
            nuevaVentana.Show();
        }
    }
}
