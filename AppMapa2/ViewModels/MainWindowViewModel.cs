using AppMapa2.Views;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AppMapa2.ViewModels
{
    public partial class MainWindowViewModel : ReactiveObject
    {

            
        private bool _isPaneOpen = false;


        private ListItemTemplate? _selectedListItem;
        public RelayCommand ShowView1Command { get; }
        public RelayCommand ShowView2Command { get; }
        public RelayCommand ShowView3Command { get; }
        public RelayCommand ShowView4Command { get; }
        public RelayCommand ShowView5Command { get; }
        public RelayCommand ShowView6Command { get; }
        public RelayCommand ShowView7Command { get; }
        public RelayCommand ShowViewCalendarioCommand { get; }


        private bool _isBackgroundExpanded = false;
        public RelayCommand ToggleBackgroundSizeCommand { get; }

        private ViewModelBase? _currentPage1;
        private ViewModelBase? _currentPage2;
        private ViewModelBase? _currentPage3;
        private ViewModelBase? _currentPage4;
        private ViewModelBase? _currentPage5;
        private ViewModelBase? _currentPage6;
        private ViewModelBase? _currentPage7;
        private ViewModelBase? _currentPageCalendario;

        private Stretch _backgroundStretch = Stretch.Fill;
        public Stretch BackgroundStretch
        {
            get => _backgroundStretch;
            set => this.RaiseAndSetIfChanged(ref _backgroundStretch, value);
        }


        private double _selectedHour = 0;
        public double SelectedHour
        {
            get => _selectedHour;
            set => this.RaiseAndSetIfChanged(ref _selectedHour, value);
        }


        // Métodos ShowView1 y ShowView2
        public bool IsBackgroundExpanded
        {
            get => _isBackgroundExpanded;
            set
            {
                this.RaiseAndSetIfChanged(ref _isBackgroundExpanded, value);

                // Actualizar el fondo de la ventana cuando cambie el estado
                if (value)
                {
                    // Si está ampliado, establecer Stretch en Fill
                    BackgroundStretch = Stretch.Fill;
                }
                else
                {
                    // Si no está ampliado, establecer Stretch en Uniform
                    BackgroundStretch = Stretch.UniformToFill;
                }
            }
        }

        private void ToggleBackgroundSize()
        {
            IsBackgroundExpanded = !IsBackgroundExpanded;
        }
         
        private void ShowView1()
        {
            // Si la vista actual es la misma que la vista 1, establecer el contenido correspondiente
            if (CurrentPage1 == null || !(CurrentPage1 is ButtonPageViewModel))
            {
                CurrentPage1 = new ButtonPageViewModel();
            }
            else
            {
                CurrentPage1 = null;
            }
        }

        private void ShowView2()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPage2 == null || !(CurrentPage2 is CercadosPageViewModel))
            {
                CurrentPage2 = new CercadosPageViewModel();
            }
            else
            {
                CurrentPage2 = null;
            }
        }

        private void ShowView3()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPage3 == null || !(CurrentPage3 is TopologiaPageViewModel))
            {
                CurrentPage3 = new TopologiaPageViewModel();
            }
            else
            {
                CurrentPage3 = null;
            }
        }
        private void ShowView4()
        {
            if (CurrentPage4 == null || !(CurrentPage4 is PruebaCuatroPageViewModel))
            {
                CurrentPage4 = new PruebaCuatroPageViewModel();
            }
            else
            {
                CurrentPage4 = null;
            }
        }


        private void ShowView5()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPage5 == null || !(CurrentPage5 is CalendarioPageViewModel))
            {
                CurrentPage5 = new CalendarioPageViewModel();
            }
            else
            {
                CurrentPage5 = null;
            }
        }

        private void ShowView6()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPage6 == null || !(CurrentPage6 is CalendarioPageViewModel))
            {
                CurrentPage6 = new CalendarioPageViewModel();
            }
            else
            {
                CurrentPage6 = null;
            }
        }
        private void ShowView7()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPage7 == null || !(CurrentPage7 is CalendarioPageViewModel))
            {
                CurrentPage7 = new CalendarioPageViewModel();
            }
            else
            {
                CurrentPage7 = null;
            }
        }

        private void ShowViewCalendario()
        {
            // Si la vista actual es la misma que la vista 2, establecer el contenido correspondiente
            if (CurrentPageCalendario == null || !(CurrentPageCalendario is CalendarioPageViewModel))
            {
                CurrentPageCalendario = new CalendarioPageViewModel();
            }
            else
            {
                CurrentPageCalendario = null;
            }
        }


        public MainWindowViewModel()
        {
            TriggerPaneCommand = new RelayCommand(TriggerPane);
            ShowView1Command = new RelayCommand(ShowView1);
            ShowView2Command = new RelayCommand(ShowView2);
            ShowView3Command = new RelayCommand(ShowView3);
            ShowView4Command = new RelayCommand(ShowView4);
            ShowView5Command = new RelayCommand(ShowView5);
            ShowView6Command = new RelayCommand(ShowView6);
            ShowView7Command = new RelayCommand(ShowView7);
            ShowViewCalendarioCommand = new RelayCommand(ShowViewCalendario);

            ToggleBackgroundSizeCommand = new RelayCommand(ToggleBackgroundSize);


        }

        public bool IsPaneOpen
        {
            get => _isPaneOpen;
            set => this.RaiseAndSetIfChanged(ref _isPaneOpen, value);
        }

       
        public ViewModelBase CurrentPage1
        {
            get => _currentPage1;
            set => this.RaiseAndSetIfChanged(ref _currentPage1, value);
        }
        public ViewModelBase CurrentPage2
        {
            get => _currentPage2;
            set => this.RaiseAndSetIfChanged(ref _currentPage2, value);
        }
        public ViewModelBase CurrentPage3
        {
            get => _currentPage3;
            set => this.RaiseAndSetIfChanged(ref _currentPage3, value);
        }
        public ViewModelBase CurrentPage4
        {
            get => _currentPage4;
            set => this.RaiseAndSetIfChanged(ref _currentPage4, value);
        }
        public ViewModelBase CurrentPage5
        {
            get => _currentPage5;
            set => this.RaiseAndSetIfChanged(ref _currentPage5, value);
        }
        public ViewModelBase CurrentPage6
        {
            get => _currentPage6;
            set => this.RaiseAndSetIfChanged(ref _currentPage6, value);
        }
        public ViewModelBase CurrentPage7
        {
            get => _currentPage7;
            set => this.RaiseAndSetIfChanged(ref _currentPage7, value);
        }
        public ViewModelBase CurrentPageCalendario
        {
            get => _currentPageCalendario;
            set => this.RaiseAndSetIfChanged(ref _currentPageCalendario, value);
        }

      
     

        public RelayCommand TriggerPaneCommand { get; }

        private void TriggerPane()
        {
            IsPaneOpen = !IsPaneOpen;
        }
    }

    public class ListItemTemplate
    {
        public ListItemTemplate(Type type)
        {
            ModelType = type;
            Label = type.Name.Replace("PageViewModel", "");
        }

        public string Label { get; }
        public Type ModelType { get; }
    }
}