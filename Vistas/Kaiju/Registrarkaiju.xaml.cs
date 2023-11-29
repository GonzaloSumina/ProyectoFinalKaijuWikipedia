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
    public partial class Registrarkaiju : ContentPage
    {
        public Registrarkaiju()
        {
            InitializeComponent();
            BindingContext = new VMRegistroKaiju(Navigation);
        }
    }
}