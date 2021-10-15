using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace ScrollViewerIssue
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Ring> Rings { get; }

        public ICommand AddRing { get; }

        public MainPageViewModel ()
        {
            Rings = new ObservableCollection<Ring> ()
            {
                new Ring (Color.Beige, 1, "Ring 1", "Info 1"),
                new Ring (Color.Blue, 2, "Ring 2", "Info 2"),
                new Ring (Color.Chartreuse, 3, "Ring 3", "Info 3"),
                new Ring (Color.Cyan, 4, "Ring 4", "Info 4"),
                new Ring (Color.Crimson, 5, "Ring 5", "Info 5"),
            };

            AddRing = new RelayCommand (() =>
            {
                var newRingNumber = Rings.Count + 1;
                Rings.Add (new Ring (Color.Green, newRingNumber, "Ring " + newRingNumber, "Was added"));
            });
        }


    }
}
