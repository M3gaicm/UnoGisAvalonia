using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMapa2.ViewModels
{
    public class ButtonPageViewModel : ViewModelBase
    {

        private string _contentText = "";

        public string ContentText
        {
            get => _contentText;
            set => this.RaiseAndSetIfChanged(ref _contentText, value);
        }
    }
}
