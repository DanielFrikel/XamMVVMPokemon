using MvvmGuia.Modelo;
using MvvmGuia.Vistas;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
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

        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/C03FXsz/pajaro.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a Base de Datos",
                    Icono = "https://i.ibb.co/zQQ2YW9/gato.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CRUD Pokemon",
                    Icono = "https://i.ibb.co/B2h1M8J/pikachu.png"
                }
            };
        }

        //public async Task Alerta(Musuarios parametros)
        //{
        //    await DisplayAlert(parametros.Nombre, $"Diste click en {parametros.Nombre}", "Aceptar");
        //}
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker")) 
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("CRUD Pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        //La p representa el objeto de la lista declarada en el command
        //En este caso es <Musuarios> entonces p es un objeto de tipo Musuarios.
        //public ICommand AlertaCommand => new Command<Musuarios>(async (p) => await Alerta(p));
        public ICommand NavegarCommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
