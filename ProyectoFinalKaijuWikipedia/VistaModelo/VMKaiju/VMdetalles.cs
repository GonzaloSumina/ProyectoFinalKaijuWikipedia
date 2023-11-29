using ProyectoFinalKaijuWikipedia.Modelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoFinalKaijuWikipedia.VistaModelo.VMKaiju
{
    public class VMdetalles : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public MKaiju parametrosRecibe { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMdetalles(INavigation navigation, MKaiju parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        // Propiedades adicionales para Alias, Altura y Peso
        public string Alias
        {
            get { return parametrosRecibe.Alias; }
            // Puedes agregar un setter si necesitas la capacidad de cambiar el valor
        }

        public string Altura
        {
            get { return parametrosRecibe.Altura; }
        }

        public string Peso
        {
            get { return parametrosRecibe.Peso; }
        }
        #endregion

        #region PROCESOS    
        public async Task ProcesoAsyncrono()
        {
        }

        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS    
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
