using System;
using Sharpnado.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Initializer = Sharpnado.TaskLoaderView.Initializer;

namespace TaskLoaderView_SimpleDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TaskMonitorConfiguration.ConsiderCanceledAsFaulted = true;
            Initializer.Initialize(true, true);

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
