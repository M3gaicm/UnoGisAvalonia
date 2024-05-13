using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using ExCSS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Point = Avalonia.Point;
using Avalonia.Media;
using Avalonia.Markup.Xaml.Converters;

namespace AppMapa2.Views
{
    public partial class MainWindow : Window
    {
        private bool click = true;
        private bool click2 = true;
        private bool click3 = true;
        private bool click4 = true;
        private TextBlock _coordinatesTextBlock;
        private StackPanel _buttonStackPanel;
        private Button _botonArriba;
        private bool _botonesIntercambiados = false;
        public string SelectedOption { get; set; } = "Seleccionar opción";

        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools(); // Para habilitar las herramientas de desarrollo de Avalonia
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            _buttonStackPanel = this.FindControl<StackPanel>("buttonStackPanel");
           

            _coordinatesTextBlock = this.FindControl<TextBlock>("CoordinatesTextBlock");
            // Mover la asignación del controlador de eventos después de InitializeComponent()
            edicion = this.FindControl<Button>("edicion");
            cercados = this.FindControl<Button>("cercados");
            topologia = this.FindControl<Button>("topologia");
            geoprocesos = this.FindControl<Button>("geoprocesos");
            edicion.Click += (sender, e) => BtnToggleColor_Click(sender, e, ref click);
            cercados.Click += (sender, e) => BtnToggleColor_Click(sender, e, ref click2);
            topologia.Click += (sender, e) => BtnToggleColor_Click(sender, e, ref click3);
            geoprocesos.Click += (sender, e) => BtnToggleColor_Click(sender, e, ref click4);
        }

        private void BtnToggleColor_Click(object sender, RoutedEventArgs e, ref bool click)
        {
            var button = (Button)sender;
            if (click)
            {
                button.Background = new SolidColorBrush(Avalonia.Media.Color.Parse("#3c5ddb"));
                click = false;
            }
            else
            {
                button.Background = new SolidColorBrush(Avalonia.Media.Color.Parse("#3f3f5a"));
                click = true;
            }
        }


        public async void SelectImage_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Imagen",
                Filters = new List<FileDialogFilter>
                 {
            new FileDialogFilter { Name = "aqgis,ambgis", Extensions = { "aqgis", "ambgis" } }
                    }
            };

            var window = this.FindLogicalAncestorOfType<Window>();
            var selectedFiles = await openFileDialog.ShowAsync(this);
        }

        public void changeCursorHand(object sender, RoutedEventArgs e)
        {
            // Cambiar el cursor del ratón en la ventana principal
            this.Cursor = new Cursor(StandardCursorType.Hand);
        }
        public void changeCursorCroos(object sender, RoutedEventArgs e)
        {
            this.Cursor = new Cursor(StandardCursorType.Cross);
        }
        public void changeCursorZoom(object sender, RoutedEventArgs e)
        {
            this.Cursor = new Cursor(StandardCursorType.SizeNorthSouth);
        }
        public void abrirVentanaCalendario(object sender, RoutedEventArgs e)
        {
            var nuevaVentana = new Calendario();
            nuevaVentana.Show();
            
        }

        private void Button_PointerEntered(object sender, PointerEventArgs e)
        {
            var button = (Button)sender;
            var textBlock = this.FindControl<TextBlock>($"{button.Name}Info");
            if (textBlock != null)
            {
                textBlock.IsVisible = true;
            }
        }

        private void Button_PointerExited(object sender, PointerEventArgs e)
        {
            var button = (Button)sender;
            var textBlock = this.FindControl<TextBlock>($"{button.Name}Info");
            if (textBlock != null)
            {
                textBlock.IsVisible = false;
            }
        }

        protected override void OnPointerMoved(PointerEventArgs e)
        {
            base.OnPointerMoved(e);
            Point position = e.GetPosition(this);
            _coordinatesTextBlock.Text = $"X: {position.X:F2}, Y: {position.Y:F2}";
        }

        private void BotonArriba_Click(object sender, RoutedEventArgs e)
        {
            // Obtener todos los botones visibles
            edicion.IsVisible = false;
                // Si hay más de un botón visible, mostrar el botón oculto
               
            
        }


        private void BotonMenos_Click(object sender, RoutedEventArgs e)
        {
            // Si el botón oculto está visible
            edicion.IsVisible = true;
        }


    }
}
