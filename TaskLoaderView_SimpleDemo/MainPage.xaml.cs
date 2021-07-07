using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskLoaderView_SimpleDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //The Load() function can be called from anywhere, for example
            //as a response to a button click.
            (BindingContext as ExampleTaskLoaderViewModel).Load();
        }
    }
}
