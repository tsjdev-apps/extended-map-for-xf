using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ExtendedMapsApp.Controls
{
    public class ExtendedMap : Map
    {
        public static readonly BindableProperty PushPinsProperty =
            BindableProperty.Create(nameof(PushPins), typeof(IEnumerable<Pin>), typeof(ExtendedMap), Enumerable.Empty<Pin>(), propertyChanged: OnPushPinsChanged);


        public IEnumerable<Pin> PushPins
        {
            get => (IEnumerable<Pin>)GetValue(PushPinsProperty);
            set => SetValue(PushPinsProperty, value);
        }

        private static void OnPushPinsChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (!(bindable is ExtendedMap map))
                return;

            map.UpdatePushPins((IEnumerable<Pin>)newvalue);
        }

        private void UpdatePushPins(IEnumerable<Pin> pins)
        {
            Pins.Clear();

            foreach (var pin in pins)
                Pins.Add(pin);
        }
    }
}
