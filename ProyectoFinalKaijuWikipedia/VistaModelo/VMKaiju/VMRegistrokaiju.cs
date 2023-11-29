using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoFinalKaijuWikipedia.Modelo;
using ProyectoFinalKaijuWikipedia.Datos;

namespace ProyectoFinalKaijuWikipedia.VistaModelo.VMKaiju
{
    public class VMRegistroKaiju: BaseViewModel
    {
        #region VARIABLES
        string _Txtnombre;
        string _Txtdescripcion;
        string _Txticono;
        string _Txtalias;
        string _Txtaltura;
        string _Txtpeso;
        #endregion
        #region CONSTRUCTOR
        public VMRegistroKaiju(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtdescripcion
        {
            get { return _Txtdescripcion; }
            set { SetValue(ref _Txtdescripcion, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }
        public string Txtalias
        {
            get { return _Txtalias; }
            set { SetValue(ref _Txtalias, value); }
        }
        public string Txtaltura
        {
            get { return _Txtaltura; }
            set { SetValue(ref _Txtaltura, value); }
        }
        public string Txtpeso
        {
            get { return _Txtpeso; }
            set { SetValue(ref _Txtpeso, value); }
        }
        #endregion
        #region PROCESOS    
        public async Task Insertar()
        {
            var funcion = new Dkaiju();
            var parametros = new MKaiju();
            parametros.Alias = Txtalias;
            parametros.Descripcion = Txtdescripcion;
            parametros.Icono = Txticono;
            parametros.Nombre = Txtnombre;
            parametros.Altura = Txtaltura;
            parametros.Peso = Txtpeso;

            await funcion.Insertarkaiju(parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS    
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
