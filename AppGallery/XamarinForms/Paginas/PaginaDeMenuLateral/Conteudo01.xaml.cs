using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
	public partial class Conteudo01 : ContentPage
	{
		public Conteudo01()
		{
			InitializeComponent();
		}

		void AbrirMenu(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).IsPresented = true;
		}
	}
}
