using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
	public partial class Conteudo02 : ContentPage
	{
		public Conteudo02()
		{
			InitializeComponent();
		}

		void VoltarParaPaginaAnterior(System.Object sender, System.EventArgs e)
		{
			// Navigation.NavigationStack[0] - Conteudo01
			// Navigation.NavigationStack[1] - Conteudo02
			Navigation.PopAsync();
		}

		void AbrirPagina03(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Conteudo03());
		}
	}
}
