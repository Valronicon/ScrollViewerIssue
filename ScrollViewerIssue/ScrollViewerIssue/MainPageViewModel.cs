using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace ScrollViewerIssue
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Ring> Rings { get; internal set; } = new ObservableCollection<Ring> ();

        public ICommand AddRings { get; }

        public ICommand AddOneRing { get; }

        public ICommand InitCommand { get; }

        public Action OnRingsAdded { get; set; }

        public MainPageViewModel ()
        {
            AddRings = new RelayCommand (() =>
            {
                Rings.Clear ();

                Rings.Add (new Ring (Color.Beige, 1, "Ring 1", "Info 1"));
                Rings.Add (new Ring (Color.Beige, 2, "Ring 2", "Info 2"));
                Rings.Add (new Ring (Color.Beige, 3, "Ring 3", "Info 3"));
                Rings.Add (new Ring (Color.Beige, 4, "Ring 4", "Info 4"));
                Rings.Add (new Ring (Color.Beige, 5, "Ring 5", "Info 5"));

                RaisePropertyChanged (nameof (Rings));
                OnRingsAdded?.Invoke ();
            });

            InitCommand = new RelayCommand (() =>
            {
                Rings.Clear ();
            });

            AddOneRing = new RelayCommand (() =>
            {
                var random = new Random ();
                Rings.Add (new Ring (Color.Aqua, random.Next (999), "Added", "info"));
            });
        }


    }
}
