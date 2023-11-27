using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoFinalKaijuWikipedia.Vistas.Kaiju;
using ProyectoFinalKaijuWikipedia.Datos;
using ProyectoFinalKaijuWikipedia.Modelo;

namespace ProyectoFinalKaijuWikipedia.VistaModelo.VMKaiju
{
    public class VMListaKaiju: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        List<MKaiju> _Listakaiju;
        #endregion
        #region CONSTRUCTOR
        public VMListaKaiju(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarkaiju();
        }
        #endregion
        #region OBJETOS
        public List<MKaiju> Listakaiju 
        { 
            get { return _Listakaiju; }
            set { SetValue(ref _Listakaiju, value); }
        }
        #endregion
        #region PROCESOS    
        public async Task Mostrarkaiju()
        {
            var funcion = new Dkaiju();
            Listakaiju = await funcion.Mostrarkaiju();
        }
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarkaiju());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS    
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
