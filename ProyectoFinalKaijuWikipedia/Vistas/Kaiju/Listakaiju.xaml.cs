using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinalKaijuWikipedia.Vistas.Kaiju;
using ProyectoFinalKaijuWikipedia.VistaModelo.VMKaiju;

namespace ProyectoFinalKaijuWikipedia.Vistas.Kaiju
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listakaiju : ContentPage
    {
        VMListaKaiju vm;
        public Listakaiju()
        {
            InitializeComponent();
            vm = new VMListaKaiju(Navigation);
            BindingContext = vm;
            this.Appearing += Listakaiju_Appearing;
        }

        private async void Listakaiju_Appearing(object sender, EventArgs e)
        {
            await vm.Mostrarkaiju();
        }
    }
}