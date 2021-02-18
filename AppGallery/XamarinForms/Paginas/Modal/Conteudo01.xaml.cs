using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.Modal
{
	public partial class Conteudo01 : ContentPage
	{
		public Conteudo01()
		{
			InitializeComponent();
		}

		void AbrirModal(System.Object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(
				new PaginaDeModal()
			);
		}
	}
}
