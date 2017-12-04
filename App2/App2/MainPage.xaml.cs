using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PropertyChanged;
using System.Diagnostics;

namespace App2
{
    [AddINotifyPropertyChangedInterface]
    public partial class MainPage : ContentPage
    {
        public bool CurrentState { get; set; }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void OnCurrentStateChanged()
        {
            Debugger.Break();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CurrentState = !CurrentState;
        }
    }
}
