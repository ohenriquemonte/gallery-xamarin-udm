using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
	public partial class PaginaInserida : ContentPage
	{
		public PaginaInserida()
		{
			InitializeComponent();
		}

		void AbrirPaginaInicial(System.Object sender, System.EventArgs e)
		{
			App.Current.MainPage = new NavigationPage(
				new Conteudo01()
			);
		}
	}
}
