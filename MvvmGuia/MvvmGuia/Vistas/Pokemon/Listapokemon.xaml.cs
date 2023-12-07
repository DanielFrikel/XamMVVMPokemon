using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmGuia.VistaModelo.VMpokemon;
using System.Data;

namespace MvvmGuia.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listapokemon : ContentPage
	{
		//VMlistapokemon vm;

		public Listapokemon ()
		{
			InitializeComponent ();
			//vm = new VMlistapokemon(Navigation);
			BindingContext = new VMlistapokemon(Navigation);
			//BindingContext = vm;			
            //this.Appearing += Listapokemon_Appearing;
        }

   //     private async void Listapokemon_Appearing(object sender, EventArgs e)
   //     {
			//await vm.Mostrarpokemon();
   //     }
    }
}