using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
	public partial class Conteudo01 : ContentPage
	{
		public Conteudo01()
		{
			InitializeComponent();
		}

		void AbrirPagina02(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Conteudo02());
		}
	}
}
