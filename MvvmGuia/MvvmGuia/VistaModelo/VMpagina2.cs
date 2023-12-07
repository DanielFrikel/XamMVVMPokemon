using MvvmGuia.Modelo;
using MvvmGuia.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace MvvmGuia.VistaModelo
{
    public class VMpagina2: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
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

        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Frikel",                   
                    Imagen = "https://i.ibb.co/C03FXsz/pajaro.png"
                },
                new Musuarios
                {
                    Nombre = "Jose",
                    Imagen = "https://i.ibb.co/zQQ2YW9/gato.png"
                },
                new Musuarios
                {
                    Nombre = "Felipe",
                    Imagen = "https://i.ibb.co/F82Kt4v/gato2.png"
                }
            };
        }

        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert(parametros.Nombre, $"Diste click en { parametros.Nombre}", "Aceptar");
        }
        #endregion

        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        //La p representa el objeto de la lista declarada en el command
        //En este caso es <Musuarios> entonces p es un objeto de tipo Musuarios.
        public ICommand AlertaCommand => new Command<Musuarios>(async (p) => await Alerta(p));
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
