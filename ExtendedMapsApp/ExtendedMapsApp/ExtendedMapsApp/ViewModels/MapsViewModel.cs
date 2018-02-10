using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Maps;

namespace ExtendedMapsApp.ViewModels
{
    public class MapsViewModel : INotifyPropertyChanged
    {
        private List<Pin> _pins;
        public List<Pin> Pins
        {
            get => _pins;
            set { _pins = value; OnPropertyChanged(); }
        }

        public MapsViewModel()
        {
            Pins = new List<Pin>
            {
                new Pin { Position = new Position(41.902916, 12.453389), Address = "Italien", Label = "Vatikanstadt" }
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
