using MvvmGuia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo.VMpokemon
{
    public class VMdetallepokemon: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mpokemon parametrosRecibe { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMdetallepokemon(INavigation navigation, Mpokemon parametrosTrae)
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
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {
            string enlace = "https://www.pokemon.com/el/pokedex/{0}"; // Coloca aquí tu enlace
            Launcher.TryOpenAsync(enlace);           
        }
        #endregion

        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
