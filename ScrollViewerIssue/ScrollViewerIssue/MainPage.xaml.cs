using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ScrollViewerIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            InitializeComponent ();
            BindingContext = new MainPageViewModel ();
            ((MainPageViewModel) BindingContext).OnRingsAdded += OnRingsAdded;
        }

        private void OnRingsAdded ()
        {
            InvalidateMeasure ();
            ForceLayout ();
        }
    }
}
