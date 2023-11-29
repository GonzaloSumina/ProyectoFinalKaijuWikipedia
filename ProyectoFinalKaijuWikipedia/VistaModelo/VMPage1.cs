using ProyectoFinalKaijuWikipedia.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoFinalKaijuWikipedia.VistaModelo
{
    public class VMPage1: BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _Tipousuario;
        DateTime _Fecha;
        #endregion
        #region CONSTRUCTOR
        public VMPage1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public string Tipousuario
        {
            get { return _Tipousuario; }
            set { SetValue(ref _Tipousuario, value); }
        }
        public string SeleecionarTipouser
        {
            get { return _Tipousuario; }
            set { SetProperty(ref _Tipousuario, value); 
                Tipousuario = _Tipousuario; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set
            {
                _Fecha = value;
                OnPropertyChanged(Fecha.ToString());
            }
        }
        #endregion
        #region PROCESOS    
        public async Task NavegarPage2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double respuesta = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            respuesta = n1 + n2;
            R = respuesta.ToString();
        }
        #endregion
        #region COMANDOS    
        public ICommand Navegarpage2command => new Command(async () => await NavegarPage2());
        public ICommand Sumarcommand => new Command(Sumar);
        #endregion
    }
}
