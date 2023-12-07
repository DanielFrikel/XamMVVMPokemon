using MvvmGuia.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _Tipousuario;
        DateTime _Fecha;
        string _Resultadofecha;
        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
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
        public string Resultadofecha
        {
            get { return _Resultadofecha; }
            set { SetValue(ref _Resultadofecha, value); }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set 
            { 
                SetValue(ref _Fecha, value);
                Resultadofecha = _Fecha.ToString("dd/MM/yyyy");
            }
        }
        public string Tipousuario
        {
            get { return _Tipousuario; }
            set { SetValue(ref _Tipousuario, value); }
        }

        public string SeleccionarTipouser
        {
            get { return _Tipousuario; }
            set 
            {
                SetProperty(ref _Tipousuario, value);
                Tipousuario = _Tipousuario;
            }
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
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            //await DisplayAlert("Titulo", Mensaje, "OK");
            await Navigation.PopAsync();
        }

        public async Task NavegarPagina2()
        {
            //await DisplayAlert("Titulo", Mensaje, "OK");
            await Navigation.PushAsync(new Pagina2());
        }

        public void Sumar()
        {
            
            double n1 = 0, n2 = 0, respuesta = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);

            respuesta = n1 + n2;
            R = respuesta.ToString();
        }
        #endregion

        #region COMANDOS
        public ICommand NavegarPagina2Command => new Command(async () => await NavegarPagina2());
        public ICommand SumarCommand => new Command(Sumar);
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
