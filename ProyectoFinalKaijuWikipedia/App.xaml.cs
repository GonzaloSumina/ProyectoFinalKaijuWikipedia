using ProyectoFinalKaijuWikipedia.Vistas;
using ProyectoFinalKaijuWikipedia.Vistas.Kaiju;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProyectoFinalKaijuWikipedia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Listakaiju());
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
