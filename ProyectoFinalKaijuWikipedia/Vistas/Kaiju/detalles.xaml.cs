using ProyectoFinalKaijuWikipedia.Modelo;
using ProyectoFinalKaijuWikipedia.VistaModelo.VMKaiju;
using System;
using Xamarin.Forms;


namespace ProyectoFinalKaijuWikipedia.Vistas.Kaiju {

    public partial class detalles : ContentPage
    {
        private bool isButtonMoved = false;

        public detalles(MKaiju parametros)
        {
            InitializeComponent();
            recopilarButton.TranslationX = 0; // Posición inicial
            BindingContext = new VMdetalles(Navigation, parametros);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Anima el deslizamiento del botón hacia la derecha cuando la página aparece
            await recopilarButton.TranslateTo(0, 0, 1000, Easing.SpringOut);
        }

        private async void OnRecopilarButtonClicked(object sender, EventArgs e)
        {
            // Puedes agregar aquí cualquier lógica adicional que desees
            if (!isButtonMoved)
            {
                // Desliza el botón hacia la derecha al hacer clic por primera vez
                await recopilarButton.TranslateTo(200, 0, 1000, Easing.SpringOut);
                recopilarButton.BackgroundColor = Color.Green;
            }
            else
            {
                // Desliza el botón hacia la izquierda al hacer clic nuevamente
                await recopilarButton.TranslateTo(0, 0, 1000, Easing.SpringOut);
                recopilarButton.BackgroundColor = Color.DarkRed;
            }

            // Cambia el estado de la variable
            isButtonMoved = !isButtonMoved;
        }
    }
}
