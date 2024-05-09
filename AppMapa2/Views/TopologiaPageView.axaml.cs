using Avalonia.Controls;
using Avalonia.Input;

namespace AppMapa2.Views
{
    public partial class TopologiaPageView : UserControl
    {
        public TopologiaPageView()
        {
            InitializeComponent();
        }
        private void AbrirPestaña(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            changeCursorHand();
            var nuevaVentana = new Cercado();
            nuevaVentana.Show();
        }

        private void AbrirPestaña2(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new RotarEntidad();
            nuevaVentana.Show();
        }
        private void AbrirPestaña3(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Crear y mostrar la nueva ventana
            var nuevaVentana = new MoverEntidad();
            nuevaVentana.Show();
        }
        public void changeCursorHand()
        {
            // Cambiar el cursor del ratón aquí
            // Por ejemplo, cambiarlo a un cursor personalizado

            // Cambiar el cursor del ratón en la ventana principal
            this.Cursor = new Cursor(StandardCursorType.Hand);
        }
    }
}
