using Avalonia.Controls;

namespace AppMapa2.Views
{
    public partial class CercadosPageView : UserControl
    {
        public CercadosPageView()
        {
            InitializeComponent();
        }
        private void AbrirPesta�a(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new Cercado();
            nuevaVentana.Show();
        }

        private void AbrirPesta�a2(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new RotarEntidad();
            nuevaVentana.Show();
        }
        private void AbrirPesta�a3(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new MoverEntidad();
            nuevaVentana.Show();
        }
    }
}
